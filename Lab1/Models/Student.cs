using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Student
    {
		public int Id { get; set; }

		[Required(ErrorMessage = "Hãy nhập tên.")]
		[StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 và tối đa 100 ký tự.")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Hãy nhập địa chỉ email.")]
		[RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com", ErrorMessage = "Địa chỉ email phải có đuôi gmail.com.")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Hãy nhập mật khẩu.")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}  $", ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Hãy chọn chi nhánh.")]
		public Branch? Branch { get; set; }

		[Required(ErrorMessage = "Hãy chọn giới tính.")]
		public Gender? Gender { get; set; }

		public bool IsRegular { get; set; }

		[DataType(DataType.MultilineText)]
		[Required(ErrorMessage = "Hãy nhập địa chỉ.")]
		public string? Address { get; set; }

		[Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 31/12/2005.")]
		[DataType(DataType.Date)]
		[Required(ErrorMessage = "Hãy nhập ngày sinh.")]
		public DateTime DateOfBorth { get; set; }

		[Required(ErrorMessage = "Hãy nhập điểm.")]
		[Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
		public double? Score { get; set; }
	}
}

