using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {

        List<string> skillsToLearn = new List<string> {"C#","JavaScript","Python" };
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet("/skills")]
        public IActionResult Skills()
        {
            string html = $@"
            <h1> Skills Tracker </h1>
            <h2> Coding Skills to Learn: </h2 >
            <ol >
                <li>{skillsToLearn[0]}</li>
                <li>{skillsToLearn[1]}</li>
                <li>{skillsToLearn[2]}</li>
            </ol >";

            return Content(html,"text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult Form(string date, string )
        {
            return View();
        }


        [HttpGet("/skills/form")]
        public IActionResult Formbuilder()
        {
            string html = $@"
            <form method='post' action='/skills'>
            <label name ='Date'><input type='date'/></label>

            <label for='C'>{skillsToLearn[0]}</label>
            <select name='{skillsToLearn[0]}' id='C'>
            <option value = 'Making Apps'> Making Apps </option>
            <option value = 'Master Coder'> Master Coder </option>
            <option value = 'Learning Basics'>Learning Basics</option>

            <label for='Java'>{skillsToLearn[1]}</label>
            <select name='{skillsToLearn[1]}' id='Java'>
            <option value = 'Making Apps'> Making Apps </option>
            <option value = 'Master Coder'> Master Coder </option>
            <option value = 'Learning Basics'>Learning Basics</option>
            </select >

            <label for='C'>{skillsToLearn[2]}</label>
            <select name='{skillsToLearn[2]}' id='C'>
            <option value = 'Making Apps'> Making Apps </option>
            <option value = 'Master Coder'> Master Coder </option>
            <option value = 'Learning Basics'>Learning Basics</option>
                                                " ;

            return View();
        }
    }
}
