namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IPerson
    {
        // Interface soyut bir olgudur. Interface'den nesne üretemeyiz.
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        void Speak();

    }

    class Customer : IPerson
    {
        // Interface'i kullanan sınıf, interface'in tüm değişiken ve metodlarını tanımlayarak kullanmak zorundadır.

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Speak() 
        {
            Console.WriteLine("Hello");
        }

        // Bunların yanı sıra kendi değişkenleri ve metodları da olabilir.

        public int CustomerId { get; set; }

    }

    // Bir sınıf birden fazla interface kullanabilir.
}