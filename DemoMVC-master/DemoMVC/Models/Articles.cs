using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Models
{
    public class Articles
    {
        public String ArticlesID { get; set; }
        public string Author { get; set; }
        [AllowHtml]
        public string Articlescontent { get; set; }
    }
}