namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ahmet";
            customer.LastName = "Kaya";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            customer.Order();

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person 
    {
        // Person sınıfının değişkenlerine ve metodlarına sahiptir.
        // Bunların yanı sıra kendine ait değişkenleri ve metodları da olabilir.

        public void Order()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} sipariş verdi!");
        }

    }

    // bir sınıf sadece bir sınıftan kalıtım alabilir.

}