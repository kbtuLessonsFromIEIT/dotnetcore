using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            
            Console.ReadKey();
        }
    }
}
