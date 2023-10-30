using System;
using System.ComponentModel.DataAnnotations;

namespace CardcomApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "ID Number")]
        [RegularExpression(@"\d{1,9}", ErrorMessage = "ID Number is required and must be max 9 digits")]
        public string IdNum { get; set; }


        [Required]
        [Display(Name = "Full Name")]
        [RegularExpression(@"^([a-zA-Z\u0590-\u05FF ]+)$", ErrorMessage = "The Name field can only contain letters and spaces.")]
        [StringLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender (optional)")]
        public Gender? Gender { get; set; }

        [RegularExpression(@"\d+", ErrorMessage = "Phone number must must contain digits only")]
        [Display(Name = "Phone Number (optional)")]
        public string? PhoneNumber { get; set; }


    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}