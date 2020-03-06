using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.Delegates
{
    class DelegateC
    {
        public delegate bool Filters(string item);
        public void print(string[] items,Filters filter)
        {
            
            foreach(var item in items){
                if(filter(item))
                    Console.WriteLine(item);
            }
        }
    }
}
