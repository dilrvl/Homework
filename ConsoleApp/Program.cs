using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная 1.
            Console.WriteLine("Лабораторная 1.");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();         
            Console.WriteLine($"Привет, {name}!"); 

            //Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое.Предусмотреть обработку исключительной ситуации, возникающей при
            //делении числа на ноль.
            try
            {
                Console.Write("Введите первое целое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                // Запрашиваем второе число
                Console.Write("Введите второе целое число: ");
                double num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результатом деления {num1} на {num2}, будет  {num1 / num2}");
            }
            catch (DivideByZeroException)
            {
                // Обработка исключения деления на ноль
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            } 

            //Домашнее задание.
            Console.WriteLine("Домашнее задание");
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Коэффициент a не может быть равным 0.");
                return;
            }
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                // Один корень 
                double x = -b / (2 * a);
                Console.WriteLine($"Один корень): x = {x}");
            }
            else
            {
                // Нет действительных корней
                Console.WriteLine("Нет корней.");
            } 


        }    
    }
}