using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ÜniversiteSite.Models;

namespace ÜniversiteSite.Controllers
{
    public class AccountController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(Login p)
        {
            var bilgiler = c.Logins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("~/admin");

            }
            return View();
        }
    }
}
