using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class DemoCompare : IComparable<DemoCompare>
    {
        public int Age;

        public string Name;
        public int CompareTo(DemoCompare other)
        {
            //return Age.CompareTo(other.Age);
            return Name.CompareTo(other.Name);
        }
    }
}