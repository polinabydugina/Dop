﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop.Classes.Fabrics
{
    static class BoysFabric
    {
        public static Boys Create(string name, int age, int height)
        {
            return new Boys(name, age, height);
        }
    }
}
