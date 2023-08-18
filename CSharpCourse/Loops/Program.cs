namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();

        }

        private static bool IsPrimeNumber(int number) 
        {
            bool result = true;
            for ( int i = 2; i < number-1; i++ ) 
            { 
                if ( number%i==0 ) 
                {
                    result = false;
                    i=number-1;
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            // Döngüde gezilen elemanlar üstünde değişiklik yapılamaz.
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 20;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}