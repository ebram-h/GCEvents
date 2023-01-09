using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCEvents
{
    public class Subscriber
    {
        public Subscriber(Publisher publisher)
        {
            // Comment this and the object won't be collected.
            publisher.SomeEvent += handler;
        }

        private void handler(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled");
        }

        ~Subscriber()
        {
            Console.WriteLine("Subscriber collected.");
        }
    }
}
