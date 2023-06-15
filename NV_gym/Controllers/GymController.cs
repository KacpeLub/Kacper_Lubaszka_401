using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using NV_gym.Models;
using NV_gym.Services.Interfaces;

namespace NV_gym.Controllers
{
    public class GymController : Controller
    {
        private readonly IGymService _gymService;
        public GymController(IGymService gymService)
        {
             _gymService = gymService;
        }
        public IActionResult Index()
        {
            var silownia = new Gym
            {
                Id = 1,
                Name = "NidavellirWiejska",
                City = "Warszawa",
                Street = "Wiejska 16",
                Size = 280,
				Description = "Najlepsza silownia pod sloncem"
            };

            return View(silownia);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Gym body)
        {
            if (!ModelState.IsValid)  //sprawdza czy załadowane dane są zgodne z założeniami
            {
                return View(body);   //jeśli nie są to wracamy do widoku add z załadowanymi danymi 
            }

            var id = _gymService.Save(body);

            return RedirectToAction("Add");
        }

        [HttpGet]
		public IActionResult List()
		{
			var gym = _gymService.GetAll();
			return View(gym);
		}
        [HttpGet]
        public IActionResult Details(int id) 
        {
            var gym = _gymService.GetById(id);
            return View(gym);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var gym = _gymService.GetById(id);

            if (gym == null)
            {
                return NotFound();
            }

            return View(gym);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var gym = _gymService.GetById(id);

            if (gym == null)
            {
                return NotFound();
            }

            _gymService.Delete(id);

            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var gym = _gymService.GetById(id);

            if (gym == null)
            {
                return NotFound();
            }

            return View(gym);
        }
        [HttpPost]
        public IActionResult EditConfirm(int id, Gym updatedGym)
        {         

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", updatedGym);
            }
      
            _gymService.Update(id, updatedGym);

            return RedirectToAction("List");
        }

    }
}
