using System;

namespace HomeWork._23._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 - трудностей не было
            Console.Write("Введите число A: ");
            int A  = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());
            B = (A = (A==B)?0:((A>B)?A:B));
            Console.WriteLine($"A = {A} B = {B}");
            // Задание 2 - трудностей не было
            Console.Write("Введите число A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите операцию: ");
            string sign = Console.ReadLine();
            switch (sign) 
            {
                case "+":
                System.Console.WriteLine($"A + B = {a + b}");
                break;
                case "-":
                System.Console.WriteLine($"A - B = {a - b}");
                break;
                case "*":
                System.Console.WriteLine($"A * B = {a * b}");
                break;
                case "/":
                Console.WriteLine((b==0)?"Нельзя делить на ноль!":$"A / B = {Math.Round(a/b,1)}");
                break;
            }
            //Задание 3
            string text = "Ваше число находится в диапазоне";
            Console.Write("Введите число: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine((d >= 0  &&  d < 15)?$"{text} [0 - 14]":
            (d > 14  && d < 36)?$"{text} [15 - 35]":
            (d > 35  && d < 50)?$"{text} [36 - 50]":
            (d == 50)?$"{text} [36 - 50] и [50 - 100]":
            (d > 50  && d < 101)?$"{text} [50 - 100]":
            "Ваше число находится вне диапазона [0 - 100]");
            Console.ReadKey();
        }
    }
}
