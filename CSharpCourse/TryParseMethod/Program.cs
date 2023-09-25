namespace TryParseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sayi;
            bool Sonuc = int.TryParse("123", out Sayi);
            if (Sonuc)
            {
                //Dönüşüm gerçekleştirildi.
                Console.WriteLine("Dönüşüm gerçekleştirildi.");
            }
            else
            {
                //Dönüşüm mümkün değilse burası tetiklenecektir.
                Console.WriteLine("Dönüşüm gerçekleştirilemedi.");
            }
        }
    }
}