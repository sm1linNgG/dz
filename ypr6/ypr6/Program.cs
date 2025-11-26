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

        switch (operation)
        {
            case 1:
                Console.WriteLine("Операция: Сложение");
                break;
            case 2:
                Console.WriteLine("Операция: Вычитание");
                break;
            case 3:
                Console.WriteLine("Операция: Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }

        Console.ReadLine();
    }
}

