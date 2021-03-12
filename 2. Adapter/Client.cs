using System;

namespace _2._Adapter
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            ITarget adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}