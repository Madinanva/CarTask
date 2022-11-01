using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.ViewModels.Home;
namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Car> _cars;
        public HomeController()
        {
              _cars = new List<Car>
            {
                new Car{Id = 1, Brand = "Hyundai"},
                new Car{Id = 2, Brand = "Mercedes"},
                new Car{Id = 3, Brand = "Toyota"}
            };
        }
        public IActionResult Index()
        {
            CarModel carModel = new CarModel
            {
                Model = "Azera",
                Color = "White"
            };
            HomeVM homeVM = new HomeVM
            {
                CarModel = carModel,
                Cars = _cars

            };
            return View(homeVM);
        }
        public IActionResult Detail(int? id)
        {
            Car car = _cars.Find(g => g.Id == id);
            return View(car);
        }
    }
}
