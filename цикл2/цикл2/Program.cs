using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        decimal percent = 0.07m; // 7% в месяц
        int i = 1;

        while (i <= months)
        {
            deposit += deposit * percent;
            i++;
        }

        Console.WriteLine($"Конечная сумма вклада: {deposit:F2}");
    }
}
