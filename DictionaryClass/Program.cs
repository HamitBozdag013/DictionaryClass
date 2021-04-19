using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary sınıfı içinde belirleyeceğimiz bir key e uygun olarak değer saklar.
            //key türünü belirtmemiz şarttır(int, string ....)

          //  Dictionary<int, string> Person = new Dictionary<int, string>();

           // Add Person
           // Person.Add(1, "Hamit");
           //Person.Add(2, "Merve");
           // Person.Add(3, "Erva");

           //foreach (var person in Person)
           //{
           //   Console.WriteLine(person);
           // }

            ////Show Person Count  
            //var personCount = Person.Count();
            //Console.WriteLine("Person Count:" + personCount);

            ////Delete Person
            //Person.Remove(1);

            //Console.WriteLine();
            //foreach (var person in Person)
            //{
            //    Console.WriteLine(person);
            //}

            MyDictionary<int, string> Persons = new MyDictionary<int, string>();
            Persons.Add(1, "Hamit");
            Persons.Add(2, "Merve");
            Persons.Add(3, "Erva");
            


            Console.WriteLine(Persons.Count);


        }
    }
}
