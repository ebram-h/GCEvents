using System;

namespace GCEvents
{
    public class Publisher
    {
        public void Raise()
        {
            SomeEvent?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SomeEvent;
    }
}
