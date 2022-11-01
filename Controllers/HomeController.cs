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
                new Car{
                    Id = 1,
                    Brand = "Hyundai",
                    CarModels = new List<CarModel>
                    {
                        new CarModel
                        {
                            Model = "Azera"
                        },
                        new CarModel
                        {
                            Model = "Creta"
                        },
                        new CarModel
                        {
                            Model = "Sonata"
                        },
                    }
                },
                new Car{
                    Id = 2, 
                    Brand = "Mercedes",
                    CarModels = new List<CarModel>
                    {
                        new CarModel
                        {
                            Model = "C-Class"
                        },
                         new CarModel
                        {
                            Model = "A-Class"
                        },
                          new CarModel
                        {
                            Model = "E-Class"
                        },
                    }
                },
                new Car{
                    Id = 3, 
                    Brand = "Toyota",
                    CarModels = new List<CarModel>
                    {
                        new CarModel
                        {
                            Model = "Auris"
                        },
                        new CarModel
                        {
                            Model = "Cruiser"
                        },
                        new CarModel
                        {
                            Model = "Prius"
                        },
                    }
                }
            };
        }
        public IActionResult Index()
        {
            CarModel carModel = new CarModel
            {
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
