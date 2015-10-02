using System;

namespace GetterOnlyAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            Car car = new Car();
            Console.WriteLine(car.LicensePlate);

            Customer customer = new Customer("John", "Doe");
            Console.WriteLine(customer.Name);
            Console.ReadKey();
        }
    }
}
