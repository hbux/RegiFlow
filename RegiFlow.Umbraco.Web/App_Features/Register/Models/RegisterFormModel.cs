using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Models
{
    [Serializable]
    public class RegisterFormModel
    {
        public BasicDetailsFormModel Basics { get; set; }
    }

    [Serializable]
    public partial class BasicDetailsFormModel
    {
        [DisplayName("Email address")]
        [Required(ErrorMessage = "Please enter your email address")]
        [MaxLength(64, ErrorMessage = "Email address exceeds maximum length of 64 characters")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [MaxLength(64, ErrorMessage = "Password exceeds maximum length of 64 characters")]
        public string Password { get; set; }

        [DisplayName("Confirm password")]
        [Required(ErrorMessage = "Please re-enter your password")]
        [MinLength(8, ErrorMessage = "Confirm password must be at least 8 characters")]
        [MaxLength(64, ErrorMessage = "Confirm password exceeds maximum length of 64 characters")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Yes! I would like to receive special offers and updates about RegiFlow and other products and services from RegiFlow by email")]
        public bool AgreeToReceivePromotionalEmails { get; set; }
    }
}