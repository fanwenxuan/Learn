﻿using System;
using MyLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person harry=new Person{Name="Harry"};
            Person mary=new Person{Name="Mary"};

            /***
            var baby1=harry.ProCreateWith(mary);
            Console.WriteLine($"ProCreateWith {mary.Name} has {mary.Children.Count} Children");

            var baby2=Person.ProCreate(harry,mary);
            Console.WriteLine($"static ProCreate {harry.Name} has {harry.Children.Count} Children");

            var baby3=harry*mary;
            Console.WriteLine($"static opertator * {harry.Name} has {harry.Children.Count} Children");

            var resultFac=Person.Factorial(6);
            Console.WriteLine($"Person.Factorial(6) {resultFac}");

            var d=new DelegateDemo(harry.DelegateMethodA);
            d+=new DelegateDemo(harry.DelegateMethodB);
            Console.WriteLine(d("helloworld"));
            ***/

            Dog dog=new Dog ();
            dog.Shout+=Dog_Shout;
            dog.Poke();
            dog.Poke();
            dog.Poke();
            dog.Poke();
            dog.Poke();
            
            Console.WriteLine("Bye!");
        }

        private static void Dog_Shout(object sender,EventArgs e)
        {
            Dog dog=(Dog)sender;
            Console.WriteLine($"{dog.Name} is this angry:{dog.AngerLevel}");
        }
    }
}