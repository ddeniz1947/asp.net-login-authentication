using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class RegisterController : Controller
    {

        blogEntities4 db = new blogEntities4();
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterLog model,RegisterLog formData)
        {
            Blog1 kayit = new Blog1();
            kayit.Number = model.Number;
            kayit.Name = model.Name;
            kayit.Surname = model.SurName;
            kayit.Password = model.Password;
            db.Blog1.Add(kayit);

            db.SaveChanges();

            if (!ModelState.IsValid)
            {
                return View(formData);
            }
            return Content("Name : " + formData.Name + "E - Mail :" + formData.Email);
           
           
        }

        // GET: Register
        /*
        public ActionResult Register()
        {
            return View();
        }*/
/*
        [HttpPost]
        public ActionResult Register(RegisterLog formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }
            return Content("Name : " + formData.Name + "E - Mail :" + formData.Email);
        }

    */
    }
}