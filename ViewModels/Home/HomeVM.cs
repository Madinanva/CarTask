using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels.Home
{
    public class HomeVM
    {
        public Car Car { get; set; }
        public CarModel CarModel { get; set; }
        public List<Car> Cars { get; set; }
    }
}
