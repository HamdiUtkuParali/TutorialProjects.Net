namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            string[] students = {student1, student2, student3};

            foreach (string student in students) { Console.WriteLine(student); }


            string[,] regions = new string[7, 3]
            {
                {"Istanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Denizli"},
                {"Bingöl","Muş","Ağrı"},
                {"Adıyaman","Batman","Siirt"},
            };
            
        }
    }
}