using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Web.Identity;
using ShopApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _sigInManager;
        private ICartService _cartServce;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> sigInManager, ICartService cartServce)
        {
            _userManager = userManager;
            _sigInManager = sigInManager;
            _cartServce = cartServce;
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View(new RegisterModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email=model.Email,
                Fullname=model.FullName,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // generate token
                //send email

                //create cart object
                _cartServce.InitializeCart(user.Id);
                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("","Bilinmeyen Bir Hata Oluştu");

            return View(model);
        }


        [HttpGet]
        public IActionResult Login()
        {

            return View(new LoginModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model,string returnUrl = null)
        {
            returnUrl = returnUrl ?? "~/";
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.Username);

            if (user==null)
            {
                ModelState.AddModelError("", "Kullanıcı Bulunamadı");
                return View(model);
            }

            var result = await _sigInManager.PasswordSignInAsync(model.Username, model.Password,true, false);
            if (result.Succeeded)
            {
                return Redirect(returnUrl);
            }
            ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Yanlış");
         
            return View(model);
        }



        public async Task<IActionResult> Logout()
        {
            await _sigInManager.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult Accessdenied()
        {
            return View();
        }
    }
}
