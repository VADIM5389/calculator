using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1,num2, result = 0;char operation;
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return;
                }
                break;
                default:
                Console.WriteLine("Ошибка: неверная операция.");
                return;
            }
            Console.WriteLine($"Результат операции: {result}");
            Console.ReadKey();
        }
    }
}
