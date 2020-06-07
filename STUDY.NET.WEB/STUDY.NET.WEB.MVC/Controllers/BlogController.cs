using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace STUDY.NET.WEB.MVC.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return new ContentResult { Content = "Hello blog!" };
        }

        [Route("{year:min(2000)}/{month:range(1, 12)}/{key:maxlength(5)}")]
        public IActionResult Post(int year, int month, string key)
        {
            return new ContentResult { Content = $"Year: {year} - Month: {month} - Key: {key}" };
        }
    }
}
