namespace GetterOnlyAutoProperties
{
    class Customer
    {
        public string Name { get; }

        public Customer(string first, string last)
        {
            Name = first + " " + last;
        }
    }
}
