using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpAdvancedTopics.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] catNames = {"Lucky","Bella","Luna",
            "Simba","Oreo"};
            int[] numbers = {5,6,7,8,234
            ,54,653,77,9};


            //LINQ Example
            var getTheNumbers = from number in numbers
                                where number <10
                                orderby number descending
                                select number;


            //LINQ contains
            var catsWithA = from cat in catNames
                       where cat.Contains("a")
                       && cat.Length >4
                       select cat;

            //LINQ on objects
            List<Person> people = new List<Person>()
            {
                new Person("Tod",180,70,Genger.Male),
                new Person("John",170,80,Genger.Male),
                new Person("Anna",150,48,Genger.Female),
                new Person("Kyle",164,77,Genger.Male),
                new Person("Maria",180,77,Genger.Female),
                new Person("John",160,55,Genger.Male)
            };

            var fourCharPeople = from p in people
                                 where p.Name.Length == 4
                                 orderby p.weight
                                 select p;


            foreach(var item in fourCharPeople)
            {
                Console.WriteLine($"Name: {item.Name} Weight: { item.weight} Height: {item.height} Gender: {item.Gender}");
            }
            //Console.WriteLine(fourCharPeople);
            Console.ReadKey();
        }
        internal enum Genger
        {
            Male,
            Female
        }
        internal class Person
        {

            public Person(string name, int height, int weight, Genger gender)
            {
                Name = name;
                this.height = height;
                this.weight = weight;
                Gender = gender;
            }

            public string Name { get; set; }

            public int height { get; set; }
            public int weight { get; set; }

            public Genger Gender { get; set; }

            
        }

    }
}
