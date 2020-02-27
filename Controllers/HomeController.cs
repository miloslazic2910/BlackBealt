using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlackBealt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;


namespace BlackBealt.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _Context;
        public HomeController(MyContext Context)
        {
            _Context = Context;
        }
     
        [HttpGet("bright_ideas")]

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            }
            ViewBag.CurrentUser = _Context.Users.Where(u => u.UserId == (int)HttpContext.Session.GetInt32("UserId")).Single();
            ViewBag.AllIdeas = _Context.Ideas.Include(u => u.Owner).Include(l => l.LikedBy).OrderByDescending(l => l.LikedBy.Count).ToList();
            return View();
            
        }
        [HttpPost("newidea")]
        [ValidateAntiForgeryToken]

        public IActionResult PostNewIdea(Idea NewIdea) 
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            }                        
            if (ModelState.IsValid)
            {             
                               
                NewIdea.UserId = (int)HttpContext.Session.GetInt32("UserId");                 
                _Context.Ideas.Add(NewIdea);
                _Context.SaveChanges();
                 return RedirectToAction("Index");

            }
            ViewBag.CurrentUser = _Context.Users.Where(u => u.UserId == (int)HttpContext.Session.GetInt32("UserId")).Single();
            ViewBag.AllIdeas = _Context.Ideas.Include(u => u.Owner).Include(l => l.LikedBy).OrderByDescending(l => l.LikedBy.Count).ToList();
            return View("Index");
           
           
        }
        [HttpGet("like/{ideaId}")]

        public IActionResult PostLike(int ideaId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            }
            Like NewLike = new Like()
            {
                IdeaId = ideaId,
                UserId = (int)HttpContext.Session.GetInt32("UserId")
            };
            _Context.Likes.Add(NewLike);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("users/{userId}")]

        public IActionResult UserInfo(int userId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            } 
            ViewBag.SelectedUser = _Context.Users.Where(u => u.UserId == userId).Include(i => i.UsersIdeas).Include(l => l.UserLikes).Single(); 
            return View();
        }
        [HttpGet("bright_ideas/{ideaId}")]

        public IActionResult IdeaInfo(int ideaId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            } 
            ViewBag.SelectedIdea = _Context.Ideas.Where(i => i.IdeaId == ideaId).Include(u => u.Owner).Include(l => l.LikedBy).ThenInclude(u => u.User).Single(); 
            ViewBag.LikedBy = _Context.Likes.Where(i => i.IdeaId == ideaId).ToList();
            return View();
        }
        [HttpGet("deleteidea/{ideaId}")]

        public IActionResult DeleteIdea(int ideaId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index", "Login");
            } 
            var ToDelete = new Idea { IdeaId = ideaId };
            _Context.Ideas.Attach(ToDelete);
            _Context.Ideas.Remove(ToDelete);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
 }