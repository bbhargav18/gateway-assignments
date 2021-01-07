//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gatewayfinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class AccountUser
    {

        [Required(ErrorMessage ="Firstname is required")]
        [RegularExpression("[a-zA-Z ]*$", ErrorMessage = "Invalid Name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [RegularExpression("[a-zA-Z ]*$", ErrorMessage = "Invalid Name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Enter valid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [MinLength(10)]
        [MaxLength(10)]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*).{8,15}$", ErrorMessage = "Make strong password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare("Password",ErrorMessage ="Password doesn't Match")]
        public string ConfirmPassword { get; set; }
    }
}
