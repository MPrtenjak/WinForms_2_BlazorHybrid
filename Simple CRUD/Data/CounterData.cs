using System;

namespace Simple_CRUD.Data
{
    internal class CounterData
    {
        public int CurrentValue { get; private set; }
        public event EventHandler CurrentValueChangedEvent;

        public CounterData() => CurrentValue = 0;

        public void Increment()
        {
            CurrentValue++;
            CurrentValueChangedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
