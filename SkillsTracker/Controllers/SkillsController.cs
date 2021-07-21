using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        [Route("/skills")]
        public IActionResult Skills(string date, )
        {

            return View();
        }

        [HttpPost]
        [Route ("/skills/form")]
        public IActionResult Form()
        {
            string html = @"
<form method='post' action='/skills'>
<label name ='Date'><input type='date'/></label>
<label for='C'>C#:</label>
<select id = 'C'>
<option value = '
</select>
                                            " ;
        }
    }
}
