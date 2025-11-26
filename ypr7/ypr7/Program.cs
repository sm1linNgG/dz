using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.Write("Ваш выбор: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (operation)
        {
            case 1:
                result = a + b;
                Console.WriteLine($"Результат сложения: {result}");
                break;
            case 2:
                result = a - b;
                Console.WriteLine($"Результат вычитания: {result}");
                break;
            case 3:
                result = a * b;
                Console.WriteLine($"Результат умножения: {result}");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }

        Console.ReadLine();
    }
}
