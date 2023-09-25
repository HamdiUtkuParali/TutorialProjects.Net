namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utku utku = new Utku("Hamdi",24);
            Console.WriteLine(utku.GetType());
        }
    }

    public class Utku
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Utku(string ad, int yas) 
        {
            Ad = ad;
            Yas = yas;
        }
    }
}