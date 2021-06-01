using System;

namespace Singleton_Design
{
    public class Program
    {
        static TableSevers Host1Server = TableSevers.GetTableServers();
        static TableSevers Host2Server = TableSevers.GetTableServers();

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Host1GetsWaiters();
                Host2GetsWaiters();
            }
        }

        public static void Host1GetsWaiters()
        {
            Console.WriteLine($"The Next Waiter Is : {Host1Server.GetNextWaiter()}");
        }    

        public static void Host2GetsWaiters()
        {
            Console.WriteLine($"The Next Waiter Is : {Host1Server.GetNextWaiter()}");
        }
    }
}
