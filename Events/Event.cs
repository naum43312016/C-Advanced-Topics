using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpAdvancedTopics.Events
{
    class Event
    {
        public void Run()
        {
            Shooter s = new Shooter();
            s.ActionCompleted += Subscriber;

            s.OnShoot();
        }

        public static void Subscriber(object sender, EventArgs e)
        {
            Console.WriteLine("hit");
        }
         
    }

    internal class Shooter
    {
        private Random rng = new Random();

        public delegate void ActionHandler(object sender,EventArgs e);


        public event ActionHandler ActionCompleted;


        public void OnShoot()
        {
            while (true)
            {
                if(rng.Next(0,100) %2 == 0)
                {
                    if (ActionCompleted != null)
                    {
                        ActionCompleted.Invoke(this,EventArgs.Empty);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Missed");
                }

                Thread.Sleep(500);
            }
        }

    }
}
