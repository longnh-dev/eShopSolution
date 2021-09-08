using System;
using System.ComponentModel.DataAnnotations;

namespace eShopSolution.ViewModels.System.Users
{
    public class UserUpdateRequest
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [Display(Name = "Tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        public string LastName { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Display(Name = "Địa chỉ Email")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}