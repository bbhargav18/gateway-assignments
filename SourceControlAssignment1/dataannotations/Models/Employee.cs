using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dataannotations.Models
{
    public class Employee
    {
        [Required]
        [RegularExpression("^[\\p{L} .'-]+$", ErrorMessage = "Invalid Name")]
        [Display(Name = "NAME")]
        public string username { get; set; }

        [Required]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Email format is not good")]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required]
        [Range(20, 35)]
        [Display(Name = "AGE")]
        public int Age { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*).{8,15}$", ErrorMessage = "strong password require")]
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and Retype password must be same")]
        [Display(Name = "REPASSWORD")]
        public string RePassword { get; set; }


        [Required]
        [validatecheckbox(ErrorMessage = "(Please check Terms and Conditions)")]
        public bool Terms { get; set; }

        public class validatecheckbox : RequiredAttribute
        {
            public override bool IsValid(object value)
            {
                return (bool)value;
            }
        }

    }
}