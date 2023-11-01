using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop.Classes.Fabrics
{
    class BoysFabric
    {
        public Boys Create(string name, int age, int height)
        {
            return new Boys(name, age, height);
        }
    }
}
