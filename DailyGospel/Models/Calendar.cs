using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DailyGospel.Models
{
    public class Calendar
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Ngày")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Tên lễ")]
        public string NameMass { get; set; }

        [Display(Name = "Bài đọc 1")]
        [RegularExpression(@"^\d*[a-zA-Z]{2,3}\s\d+,\d+(-\d+)*(\.\d+(-\d+)*)*(;\d+,\d+(-\d+)*(\.\d+(-\d+)*)*)*$",
            ErrorMessage = "Nhập sai định dạng địa chỉ sách.")]
        public string FirstReading { get; set; }

        [Display(Name = "Bài đọc 2")]
        [RegularExpression(@"^\d*[a-zA-Z]{2,3}\s\d+,\d+(-\d+)*(\.\d+(-\d+)*)*(;\d+,\d+(-\d+)*(\.\d+(-\d+)*)*)*$",
            ErrorMessage = "Nhập sai định dạng địa chỉ sách.")]
        public string SecondReading { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Tin mừng")]
        [RegularExpression(@"^\d*[a-zA-Z]{2,3}\s\d+,\d+(-\d+)*(\.\d+(-\d+)*)*(;\d+,\d+(-\d+)*(\.\d+(-\d+)*)*)*$",
            ErrorMessage = "Nhập sai định dạng địa chỉ sách.")]
        public string Gospel { get; set; }
    }
}