using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.AsynchronousProgramming
{
    class Main
    {
        public void Run()
        {
            Task t = Task.Factory.StartNew(() =>
            {
                ConcChars('1', 200000);
            });
            Console.WriteLine("In progress");
            t.Wait();

            Console.WriteLine("Completed");
        }

        public void ConcChars(char charToCon,int count)
        {
            string c = "";
            for(int i = 0; i < count; i++)
            {
                c += charToCon;
            }
        }
    }
}
