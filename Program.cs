using OOP;
using System;

internal class OOPV2
{
    static void Main(string[] args)
    {
        List<Person> student = new List<Person>()
        {
            new Person
            {
                Name = "Hycon",
                Age = 25,
                Month = 9,
                MatricNumber = 2782,
            },
            new Person
            {
                Name = "Olamide",
                Age = 17,
                Month = 5,
                MatricNumber = 2780,
            }

        };

        foreach (var s in student)
        {
        Console.WriteLine($"{s.DisplayInfo()} \nWELCOME TO ADVANCED OOP LESSON 2\n");
        }
        
    }
}