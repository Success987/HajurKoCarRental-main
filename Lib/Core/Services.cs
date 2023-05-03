using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HajurKoCarRental.Lib.Core;

public class Services
{
    public async Task<bool> Login(string userName, string password)
    {
        // var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        // var user = await userManager.FindAsync(userName, password);
        //
        // if (user == null) return false;
        // var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        // var identity = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
        // authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, identity);
        // return true;
        return false;
    }
}