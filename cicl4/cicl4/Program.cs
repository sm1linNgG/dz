using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число (от 0 до 10): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число (от 0 до 10): ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
            {
                int result = a * b;
                Console.WriteLine($"Результат умножения: {result}");
                break; // выходим из цикла, так как числа допустимы
            }
            else
            {
                Console.WriteLine("Ошибка: введенные числа недопустимы. Попробуйте снова.\n");
            }
        }
    }
}
