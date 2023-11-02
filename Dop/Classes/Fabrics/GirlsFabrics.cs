using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop.Classes.Fabrics
{
    static class GirlsFabric
    {
        public static Girls Create(string name, int age, int height)
        {
            return new Girls(name, age, height);
        }
    }
}
