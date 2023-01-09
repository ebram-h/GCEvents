using System;

namespace GCEvents
{
    public class Subscriber
    {
        private readonly Publisher publisher;

        public Subscriber(Publisher publisher)
        {
            // Comment this and the object will be collected.
            publisher.SomeEvent += handler;
            this.publisher = publisher;
        }

        private void handler(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled");
        }

        public void Dispose()
        {
            publisher.SomeEvent -= handler;
        }

        ~Subscriber()
        {
            Console.WriteLine("Subscriber collected.");
        }
    }
}
