using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        blogEntities4 db = new blogEntities4();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin formData, string returnUrl,AuthLogin data)
        { 
           
           
            blogEntities4 db = new blogEntities4();
            Blog1 kayit = new Blog1();
            string name,surname, pass;
            Boolean cafer = false;
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                foreach (var err in db.Blog1)
                {
                    name = err.Name;
                    surname = err.Surname;
                    pass = err.Password;

                    if (name == data.Username && pass == data.Password)
                    {
                        FormsAuthentication.SetAuthCookie(err.Name, true);

                        cafer = true;
                    }
                }
            }

            if(cafer == false)
            {
                return View("Hata");
               
            }
   
            if (!String.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToRoute("Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");
        }
        
    }
}