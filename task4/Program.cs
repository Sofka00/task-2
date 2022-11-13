using System;


namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите число ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число ");
            c = int.Parse(Console.ReadLine());
            double x = (c - b) /(double) a;
            Console.WriteLine(x);

            



        }
    }
}
