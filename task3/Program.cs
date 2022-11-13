using System;


namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine( a + " " + b ); 

        }
    }
}
