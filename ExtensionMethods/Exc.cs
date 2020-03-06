using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.ExtensionMethods
{
    public static class Exc
    {
        public static void printArr(this int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
