using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication3.Controllers;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            var namespaces = new[] { typeof(PostsController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Home","", new { controller = "Posts", action = "Index" },namespaces );
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" });
            routes.MapRoute("Logout", "Logout", new { controller = "Auth", action = "Logout"});
            routes.MapRoute("Register", "register", new { controller = "Register", action = "register" },namespaces);
            routes.MapRoute("VeriListele", "verilerilistele", new { controller = "VeriListele", action = "verilerilistele" }, namespaces);

        }
    }
}
