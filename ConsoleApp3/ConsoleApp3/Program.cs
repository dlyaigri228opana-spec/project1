// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите символ операции (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result;
        bool validOperation = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно!");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                break;

            default:
                validOperation = false;
                Console.WriteLine("Ошибка: введён неверный символ операции!");
                break;
        }
    }
}