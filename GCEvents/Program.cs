using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCEvents
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var publisher = new Publisher();

            //// No reference to subscribers after the loop.
            //for (int i = 0; i < 100; i++)
            //{
            //    var sub = new Subscriber(publisher);
            //    //await Task.Delay(100);
            //}

            //publisher.Raise();

            //await Task.Delay(1000);

            //GC.Collect();
            //Console.ReadKey();

            // #2

            var publisher = new Publisher();

            {
                var container = new SubscribersContainer(publisher);
            }

            publisher.Raise();

            await Task.Delay(1000);

            GC.Collect();

            await Task.Delay(1000);

            GC.Collect();

            Console.ReadKey();
        }
    }
}
