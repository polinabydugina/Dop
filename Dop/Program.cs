using System;
using System.Collections;
using System.Collections.Generic;

using Dop.Classes;
List<Kids>kidsList = new List<Kids>();
kidsList.Add(new Girls("Мария", 18, 155));
kidsList.Add(new Girls("Анна", 15, 165));
kidsList.Add(new Girls("Дарья", 13, 163));
kidsList.Add(new Girls("Екатерина", 20, 170));
kidsList.Add(new Boys("Александр", 14, 174));
kidsList.Add(new Boys("Василий", 12, 180));
kidsList.Add(new Boys("Иван", 19, 195));
kidsList.Add(new Boys("Михаил", 17, 203));
SortByAge(kidsList);
void ListOutput()
{
    int i = 1;
foreach (Kids kids in kidsList)
    {
        Console.WriteLine($"\t{i}. {kids.PrintName()}");
        i++;
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
