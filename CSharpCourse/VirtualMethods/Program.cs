namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            sqlServer.Update();
        }
    }

    class Database
    {
        // virtual metodlar alt sınıflar tarafından override edilebilir,
        // override etmek zorunda değillerdir.
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }

        public void Update() 
        {
            Console.WriteLine("Updated by default");
        }

    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer");
            //base.Add(); bunun anlamı Database.Add(); dır.

        }
    }

    


}