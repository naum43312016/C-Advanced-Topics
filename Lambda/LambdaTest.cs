using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAdvancedTopics.Lambda
{
    public class LambdaTest
    {
        public void Test()
        {
            object[] mix = { 
                1, "string",'d',new List<int>(){1,2,3,4},
                new List<int>(){5,2,3,4,77,88,55},"dd",2,5,6,8,7
            };


            var allIntegers = mix.OfType<int>().Where(i => i<3);
            Console.WriteLine(string.Join(",", allIntegers));


            var allIntLists = mix.OfType<List<int>>().Where(
                l => l.Count>5).ToList();


            List<int> numbers = new List<int>()
            {
                5,6,7,8,4,85,888,96,25,15,36
            };
            string[] catNames = {"Lucky","Bella","Luna",
            "Simba","Oreo"};
            //Lambda example

            var oddNumbers = numbers.Where((n) =>
            {
                return n % 2 == 1;
            }).ToList();
            Console.WriteLine(string.Join(",", oddNumbers));

            double average = catNames.Average(cat => cat.Length);
            Console.WriteLine(string.Join(",", average));

            double minCatNameLenght = catNames.Min(cat => cat.Length);
            Console.WriteLine("Min:"+minCatNameLenght);
        }
    }
}
