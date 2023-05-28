using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;
using WebApp.Models.Identity;

namespace WebApp.Models.ViewModels
{
    public class UserRegisterViewModel
    {
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "You must provide a firstname")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "You must provide a lastname")]
        public string LastName { get; set; } = null!;

        [Display(Name = "StreetName")]
        [Required(ErrorMessage = "You must provide a streetname")]
        public string StreetName { get; set; } = null!;

        [Display(Name = "PostalCode")]
        [Required(ErrorMessage = "You must provide a postalcode")]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must provide a city")]

        public string City { get; set; } = null!;

        [Display(Name = "Moblie")]
        public string? Mobile { get; set; }

        [Display(Name = "Company")]
        public string? Company { get; set; }


        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must provide an email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must provide a valid email address")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter a valid password")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "You must provide a valid password ")]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must confirm your password ")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Upload Profile Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "I have read and accepted the terms and conditions")]
        [Required(ErrorMessage = "You must agree to the terms and conditions")]
        public bool TermsAndConditions { get; set; } = false;



        public static implicit operator AppUser(UserRegisterViewModel viewModel)
        {
            return new AppUser
            {
                UserName = viewModel.Email,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                PhoneNumber = viewModel.Mobile,
                CompanyName = viewModel.Company,


            };
        }

        public static implicit operator AddressEntity(UserRegisterViewModel viewModel)
        {
            return new AddressEntity
            {
                StreetName = viewModel.StreetName,
                PostalCode = viewModel.PostalCode,
                City = viewModel.City,
            };
        }


    }
}
