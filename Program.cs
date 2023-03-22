// See https://aka.ms/new-console-template for more information
using MyApplication.ABC;
using System;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
             int votingAge = 18;


             Console.WriteLine("Enter username:");

             string userName = Console.ReadLine();

             Console.WriteLine("Welcome to Abjima " + userName);

             Console.WriteLine("Enter your age:");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Your age is: " + age);

             if (age >= votingAge)
             {
                 Console.WriteLine("Old enough to vote!");
             }
             else
             {
                 Console.WriteLine("Not old enough to vote.");
             }

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);


        }
}
    namespace ABC
    {
        class Car
        {
           public string model;
           public string color;
           public int year;
        }
    }
}
