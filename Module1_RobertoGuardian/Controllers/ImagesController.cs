using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Module1_RobertoGuardian.Models;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module1_RobertoGuardian.Controllers
{
    public class ImagesController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetAllImages()
        {
            IList<Images> imageList = new List<Images>();


            return View();
        }
    }
}
