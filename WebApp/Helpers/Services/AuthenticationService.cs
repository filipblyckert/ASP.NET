using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Models.Identity;
using WebApp.Models.ViewModels;

namespace WebApp.Helpers.Services
{
    public class AuthenticationService
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AddressService _addressService;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthenticationService(UserManager<AppUser> userManager, AddressService addressService, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _addressService = addressService;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<bool> UserAlreadyExistsAsync(Expression<Func<AppUser, bool>> expression)
        {
          return  await _userManager.Users.AnyAsync(expression);   
        }

        public async Task<bool> RegisterUserAsync(UserRegisterViewModel viewModel)
        {
            AppUser appUser = viewModel;
            var roleName = "User";

            if(!await _roleManager.Roles.AnyAsync())
            {
                await _roleManager.CreateAsync(new IdentityRole("System Administrator"));
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            if (!await _userManager.Users.AnyAsync())
                roleName = "System Administrator";

            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
           if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, roleName);

                var addressEntity = await _addressService.GetOrCreateAsync(viewModel);
                if (addressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser, addressEntity);
                }
                return true;
            }

            return false;
        }


        public async Task<bool> LoginAsync(UserLoginViewModel viewModel)
        {
            var appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
            if(appUser != null)
            {
               var result = await _signInManager.PasswordSignInAsync(appUser, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            return false;
        }

    }
}
