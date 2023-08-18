namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Add(20);
            Console.WriteLine(result);
        }

        static int Add(int a, int b=30)
        {
            return a + b; 
        }
        //Baştaki parametrelere default değer verip sondakilere vermemezlik yapamazsın.

        static int Add(int a, int b, int c) 
        {
            return a + b + c;
        }
        //Overloading.

        static int Add2(params int[] numbers)
        {
            return numbers.Sum();
        }
        //Parametre sayısı belirsiz olduğunda 'params' kullanırız.
        //Birden fazla parametre olduğunda başta 'Params' parametresi verip
        //sonra normal parametre veremezsin. Yani sadece sondaki parametre params olabilir.
    }
}