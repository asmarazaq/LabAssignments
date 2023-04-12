using Microsoft.AspNetCore.Mvc;
using MockAssessment5b.Models;

namespace MockAssessment5b.Controllers
{

	public class HomeController : Controller
	{
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAge()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Result(Person person)
		{
			person.CanDrink = person.Age >= 21;
			person.CanDrive = person.Age >= 16;

			return View(person);
		}
       
            public IActionResult Form()
            {
                return View();
            }
        }
}
