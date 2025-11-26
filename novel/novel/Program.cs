using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ты просыпаешься в темной комнате. Что будешь делать?");
        Console.WriteLine("1 - Встать с кровати");
        Console.WriteLine("2 - Остаться лежать");
        int step1 = Convert.ToInt32(Console.ReadLine());

        if (step1 == 1)
        {
            Console.WriteLine("Ты встаёшь. Перед тобой дверь и окно. Куда пойдёшь?");
            Console.WriteLine("1 - К двери");
            Console.WriteLine("2 - К окну");
            int step2 = Convert.ToInt32(Console.ReadLine());

            if (step2 == 1)
            {
                Console.WriteLine("Ты открываешь дверь и выходишь в коридор. Там темно.");
                Console.WriteLine("1 - Идти вперёд");
                Console.WriteLine("2 - Вернуться");
                int step3 = Convert.ToInt32(Console.ReadLine());

                if (step3 == 1)
                {
                    Console.WriteLine("Ты идёшь вперёд и видишь лестницу.");
                    Console.WriteLine("1 - Подняться");
                    Console.WriteLine("2 - Спуститься");
                    int step4 = Convert.ToInt32(Console.ReadLine());

                    if (step4 == 1)
                    {
                        Console.WriteLine("Ты поднимаешься наверх и находишь свет.");
                        Console.WriteLine("1 - Идти на свет");
                        Console.WriteLine("2 - Спрятаться");
                        int step5 = Convert.ToInt32(Console.ReadLine());

                        if (step5 == 1)
                        {
                            Console.WriteLine("Ты нашёл выход! ☀️");
                            Console.WriteLine("Концовка 1 — Побег!");
                        }
                        else
                        {
                            Console.WriteLine("Ты спрятался и заснул навсегда...");
                            Console.WriteLine("Концовка 2 — Сон без конца 💤");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ты спустился вниз и попал в подвал.");
                        Console.WriteLine("1 - Исследовать");
                        Console.WriteLine("2 - Кричать о помощи");
                        int step6 = Convert.ToInt32(Console.ReadLine());

                        if (step6 == 1)
                        {
                            Console.WriteLine("Ты нашёл сундук с золотом!");
                            Console.WriteLine("Концовка 3 — Богатство 💰");
                        }
                        else
                        {
                            Console.WriteLine("Ты кричал... и что-то услышало тебя...");
                            Console.WriteLine("Концовка 4 — Ужас 😱");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ты вернулся и лёг обратно спать.");
                    Console.WriteLine("Концовка 5 — Лень — сила 😴");
                }
            }
            else
            {
                Console.WriteLine("Ты открыл окно и выбрался наружу. Свежий воздух!");
                Console.WriteLine("Концовка 1 — Побег!");
            }
        }
        else
        {
            Console.WriteLine("Ты остался лежать. Вскоре снова заснул...");
            Console.WriteLine("Концовка 5 — Лень — сила 😴");
        }

        Console.WriteLine("\nСпасибо за игру!");
        Console.ReadLine();
    }
}
