using System;


namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine("Введите число ");
            a = double.Parse(Console.ReadLine());   
           Console.WriteLine("Введите второе число");
            b = double.Parse(Console.ReadLine());
                
             
            
            double resultOne = a * b;
            Console.WriteLine("Произведение чисел равно " + resultOne);
            double resultTwo = a%b;
            Console.WriteLine("Остаток от деления чисел равен " + resultTwo);
        }
    }
}
