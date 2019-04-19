using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class VeriListeleController : Controller
    {
        // GET: VeriListele
        public ActionResult VerileriListele()
        {
            VeriListele veri = new VeriListele();
            veri.ErrorList = VeriListele.HatalarıListele();
            return View(veri);
        }
    }
}