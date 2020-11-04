using System;
using System.Collections.Generic;

namespace first_class_method_tostring
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfPersons = 3;
            var persons = new List<Person>();

            for (int i = 0; i < amountOfPersons; i++)
            {
                persons.Add(new Person(Console.ReadLine()));
            }

            persons.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
