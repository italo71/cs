using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Insira um numero: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"O numero informado foi {num}");
        }
    }
}