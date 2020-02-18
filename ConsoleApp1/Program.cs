using ClassLibrary1.Controller;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zdorov soroxman");

            Console.WriteLine("Yvedu imja");
            var name = Console.ReadLine();
            Console.WriteLine("Yvedu pol svij");
            var gender = Console.ReadLine();
            Console.WriteLine("kolus sa naroduv ");
            var birhdate = DateTime.Parse(Console.ReadLine());   /// treba shos zrobutu
            Console.WriteLine("kilko vashush ");
            var weight = double.Parse(Console.ReadLine());
            Console.WriteLine("kilko maesh rosta ");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birhdate, weight, height);
            userController.Save();

        }
    }

    
}
