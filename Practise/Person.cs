using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    internal class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }

        public int CompareTo(object obj)
        {
            return ((Person)obj).Age.CompareTo(this.Age);
        }

        public override string ToString()
        {
            return "TOsTRING"; 
        }
    }
    class Test : Person
    {

    }
}
