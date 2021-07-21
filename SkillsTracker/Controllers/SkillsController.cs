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

        [Route("/skills")]
        public IActionResult Index()
        {
            string html = $@"
            <h1> Skills Tracker </h1>
            <h2> Coding Skills to Learn: </h2 >
            <ol >
                <li>{skillsToLearn[0]}</li>
                <li>{skillsToLearn[1]}</li>
                <li>{skillsToLearn[2]}</li>
            </ol >";

            return Content(html, "text/html");
            return View();
        }


        [HttpPost("/skills/form")]
        public IActionResult Form(string date, string skill1, string skill2, string skill3)
        {
            string html = $@"
            <h1>{date}</h1>
            <ol >
                <li>{skillsToLearn[0]}:{skill1}</li>
                <li>{skillsToLearn[1]}:{skill2}</li>
                <li>{skillsToLearn[2]}:{skill3}</li>
            </ol >  ";
            return Content(html,"text/html");
        }


        [HttpGet("/skills/form")]
        public IActionResult Formbuilder()
        {
            string html = $@"
            <form method='post' action='/skills/form'>

            <label>Date:<input type='date'name ='date'/></label>
            <br/>

            <label for='C'>{skillsToLearn[0]}:</label><br/>

            <select name='skill1' id='C'>
            <option value = 'Making Apps'> Making Apps </option>
            <option value = 'Master Coder'> Master Coder </option>
            <option value = 'Learning Basics'>Learning Basics</option>
            </select>
            <br/>

            <label for='Java'>{skillsToLearn[1]}:</label><br/>
            <select name='skill2' id='Java'>
            <option value = 'Making Apps'> Making Apps </option>
            <option value = 'Master Coder'> Master Coder </option>
            <option value = 'Learning Basics'>Learning Basics</option>
            </select>
            <br/>
            <label for='Python'>{skillsToLearn[2]}:</label><br/>
            <select name='skill3' id='Python'>
            <option value = 'Making Apps'> Making Apps </option>
            <option value = 'Master Coder'> Master Coder </option>
            <option value = 'Learning Basics'>Learning Basics</option>
            </select>
            <br/>
            <input type='submit'value='Submit'>
            </form>

" ;
            
            return Content(html,"text/html");
        }
    }
}
