using Microsoft.AspNetCore.Mvc;
using Controller_and_IActionResult.Models;
namespace Controller_and_IActionResult.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("/person")]
        public JsonResult Person()
        {
            // Create a new Person object and initialize its properties
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Anish",
                LastName = "Joshi",
                Age = 24
            };

            // Return the person object as a JsonResult
            return Json(person);
            //return JsonResult(person);
        }
    }
}
