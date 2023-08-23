using System;

namespace Simple_CRUD.Data
{
    internal class MessageBroker
    {
        public event EventHandler DatabaseChangedEvent;

        public void NotifyDatabaseChange()
        {
            DatabaseChangedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
