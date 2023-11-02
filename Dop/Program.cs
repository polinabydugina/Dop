using System;
using System.Collections;
using System.Collections.Generic;

using Dop.Classes;
using Dop.Classes.Fabrics;

Girls girl1 = GirlsFabric.Create("Мария", 18, 155);
Girls girl2 = GirlsFabric.Create("Анна", 15, 165);
Girls girl3 = GirlsFabric.Create("Дарья", 13, 163);
Girls girl4 = GirlsFabric.Create("Екатерина", 20, 170);
Boys boy1 = BoysFabric.Create("Александр", 14, 174);
Boys boy2 = BoysFabric.Create("Василий", 12, 180);
Boys boy3 = BoysFabric.Create("Иван", 19, 195);
Boys boy4 = BoysFabric.Create("Михаил", 17, 203);
List<Kids> kidsList = new List<Kids> { girl1, girl2, girl3, girl4, boy1, boy2, boy3, boy4 };
SortByAge(kidsList);
void ListOutput()
{
foreach (Kids kids in kidsList)
    {
        Console.WriteLine(kids.PrintName());
    }
}

void SortByAge(List<Kids> kids)
{
    for (int j = 0; j < kids.Count-1; j++)
    {
        for (int i = 0; i < kids.Count-1; i++)
        {
            if (kids[i].Age > kids[i + 1].Age)
            {
                var temp = kids[i];
                kids[i] = kids[i + 1];
                kids[i + 1] = temp;
            }
        }
    }
    ListOutput();
}
