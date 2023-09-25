namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
        }
    }

    abstract class Database
    {
        // Abstract class'lar Interface'lerdeki gibi imza değişken ve metodlara sahip olabilirler.
        // Abstract class'larden nesne üretilemez.
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database 
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

}