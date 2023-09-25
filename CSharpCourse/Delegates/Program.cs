namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Heloo");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
    }
}