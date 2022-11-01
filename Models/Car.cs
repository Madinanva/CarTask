using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public int Id { get; set; }
        public List<CarModel> CarModels { get; set; }
    }
}
