using OOP;
using System;

internal class OOPV2
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Person.DisplayInfo()}, WELCOME TO OOP LESSON 2");
        Thread.Sleep( 1000 );

        string[] cars = { "Benz", "Toyota", "Mustang" };

        foreach (var item in cars)
        {
            Console.WriteLine(item);
            Thread.Sleep(1000);
        }
    }
}