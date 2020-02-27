using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BlackBealt.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace BlackBealt.Controllers
{
    public class LoginController : Controller
    {
        private MyContext _Context;
        public LoginController(MyContext Context)
        {
            _Context = Context;
        }

        [HttpGet("")]

        public IActionResult Index()
        {
            ViewBag.valErrors = ModelState.Values;
            return View();
        }
        [HttpPost("register")]
        [ValidateAntiForgeryToken]

        public IActionResult Register(RegisterViewModel NewUser)
        {
            User Validate = _Context.Users.Where(user => user.UserName == NewUser.UserName).SingleOrDefault(); 
            if (ModelState.IsValid && Validate == null)
            {
                User ValidUser = new User()  {
                    UserName = NewUser.UserName,
                    UserAlias = NewUser.UserAlias,
                    Email = NewUser.Email,
                    Password = NewUser.Password
                };
                _Context.Users.Add(ValidUser);
                _Context.SaveChanges();
                Validate = _Context.Users.Where(user => user.UserName == ValidUser.UserName).SingleOrDefault();
                HttpContext.Session.SetInt32("UserId", (int)Validate.UserId);
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ViewBag.valErrors = ModelState.Values;
                return View("Index");
            }
        }
        [HttpPost("login")]
        [ValidateAntiForgeryToken]

        public IActionResult Login(LoginViewModel User)
        {
            if (ModelState.IsValid)
            {
                User Validate = _Context.Users.Where(user => user.Email == User.Email).SingleOrDefault(); 
                if (Validate != null){
                    if ((string)Validate.Password == User.Password){
                        HttpContext.Session.SetInt32("UserId", (int)Validate.UserId);
                        return RedirectToAction("Index", "Home");
                    }
                    else 
                    {
                        ModelState.AddModelError("error", "Wrong Password Or Email");   
                        ViewBag.valErrors = ModelState.Values;              
                        return View("Index");
                    }
                }
                else {
                    ModelState.AddModelError("error", "Wrong Password Or Email");   
                        ViewBag.valErrors = ModelState.Values;              
                        return View("Index");
                }
            }
            else 
            {
                ViewBag.valErrors = ModelState.Values;                
                return View("Index");
            }
        }
        [HttpGet("logout")]

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
