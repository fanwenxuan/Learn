using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public delegate int DelegateDemo(string str);
    public class Person:IComparable<Person>
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children=new List<Person> ();        
        

        public Person()
        {
            Name="Tome";
            DateOfBirth=DateTime.Parse("12/10/2010");
        }

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on {DateOfBirth:dddd,d MMMM yyyy}");
        }
        ///static method
        public static Person ProCreate(Person p1,Person p2)
        {
            var baby=new Person
            {
                Name=$"baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        //operator * 
        public static Person operator *(Person p1,Person p2)
        {
            return ProCreate(p1,p2);
        }

        public Person ProCreateWith(Person partner)
        {
            return ProCreate(this,partner);      
        }

        public static int Factorial(int number)
        {
            if(number<0)
            {
                throw new ArgumentException($"nameof {number} cannot be less than 0.");
            }
            return localFactorial(number);
            //local method 
            int localFactorial(int localNumber)
            {
                if(localNumber<1)
                    return 1;
                return localNumber*localFactorial(localNumber-1);

            }
        }

        public int DelegateMethodA(string s)
        {
            return s.Length;
        }

        public int DelegateMethodB(string s)
        {
            return s.Length+1;
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
