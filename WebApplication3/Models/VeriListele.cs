using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class VeriListele
    {
        public List<Blog1> ErrorList { get; set; }

        public static List<Blog1> HatalarıListele()
        {
            using(blogEntities4 db = new blogEntities4())
            {
                return db.Blog1.ToList();
            }
        }


    }
}