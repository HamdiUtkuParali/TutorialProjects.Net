﻿namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate();

            Console.WriteLine();

            myDelegate += customerManager.ShowAlert;
            myDelegate();

        }

    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
    }
}