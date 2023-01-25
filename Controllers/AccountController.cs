using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzureAD.Example.Controllers;

[Route("client/[controller]")]
public class AccountController : ControllerBase
{
    [AllowAnonymous]
    [HttpGet("Login")]
    public ActionResult Login(string? returnUrl)
    {
        var redirectUri = !string.IsNullOrEmpty(returnUrl) ? returnUrl : "/";
        var properties = new AuthenticationProperties { RedirectUri = redirectUri };
        
        return Challenge(properties);
    }

    [Authorize]
    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        return SignOut(
            new AuthenticationProperties { RedirectUri = "/" },
            CookieAuthenticationDefaults.AuthenticationScheme,
            OpenIdConnectDefaults.AuthenticationScheme);
    }
}