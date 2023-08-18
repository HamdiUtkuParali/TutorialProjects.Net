namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;
            int number3 = 2147483647; //int üst sınırı, alt sınırı da bu sayının eksili hali.
            Console.WriteLine("Number1 is {1}",number1,number2);
            // Metine değişkenleri yazdırmak için {} kullanırız ve içine index numarasını yazarız.
            // Yukardaki örnekte number2'yi çağırıyoruz.

            long number4 = 2147483648; // int sınırlarının üstünde sayılar için kullanılır. Ancak hafızada daha çok yer kaplar.
            short number5 = 32767; // int sınırlarının altındaki sayılar için kullanılır. Hafızada daha az yer kaplar.
            byte number6 = 255; // 0-256 arasındaki sayıları tutar.
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n",number3, number4, number5, number6);

            bool condition = false;

            char character = 'A';
            string city = "Ankara";

            Console.WriteLine("Character is : {0} and its converted value is {1}",character, (int)character);

            double number7 = 10.25; // Ondalıklı sayıları tutar.
            decimal number8 = 10.25468934m; // Ondalıklı kısmın daha uzun olduğu değerleri tutabilir. Sayının sonuna 'm' konulmalıdır.

        }
    }
}