using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop.Classes
{
    abstract class Kids
    {
        public string colorhair = "black";
        public string coloreye = "blue";
        public string Name { get; set; }
        public int Age { get; set; }
        public  int Height { get; set; }
        public string PrintName()
        {
            return $"{Name}, Возраст: {Age}, Рост: {Height}, Цвет волос:{colorhair}, Цвет глаз:{coloreye}";
        }

    }
}
