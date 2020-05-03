using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coutaq.Core.SaveToRelativePath("test.txt", "Hello World");
        }
    }
}
