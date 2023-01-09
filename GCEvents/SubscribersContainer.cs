using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCEvents
{
    public class SubscribersContainer
    {
        public SubscribersContainer(Publisher publisher)
        {
            Subs = new Subscriber[100];
            for (int i = 0; i < 100; i++)
            {
                Subs[i] = new Subscriber(publisher);
            }
        }

        public Subscriber[] Subs { get; set; }

        ~SubscribersContainer()
        {
            for (int i = 0; i < Subs.Length; i++)
            {
                Subs[i].Dispose();
            }
        }
    }
}
