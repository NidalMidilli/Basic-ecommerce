using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace E_commerceAdmin.Controllers
{
    public class LoginController : Controller
    {
        IUserService userService;
        Context con = new Context();
        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult LoginPanel(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>LoginPanel(User user)
        {
            var informations = con.Users.FirstOrDefault(x => x.userName == user.userName && x.password == user.password);
            if(informations != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, informations.userName),
                    new Claim(ClaimTypes.Role,informations.rol)
                };
                var identity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal claimprincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(claimprincipal);

                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult RegisterPanel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterPanel(User user)
        {

            userService.AddUser(user);
            return RedirectToAction("LoginPanel");

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
