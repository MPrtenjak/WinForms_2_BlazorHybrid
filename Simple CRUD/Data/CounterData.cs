namespace Simple_CRUD.Data
{
    internal class CounterData
    {
        public int CurrentValue { get; private set; }

        public CounterData() => CurrentValue = 0;

        public void Increment() => CurrentValue++;
    }
}
