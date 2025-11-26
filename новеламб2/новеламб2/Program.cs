using System;

class Program
{
    static void Main()
    {
        int step = 1;
        bool gameOver = false;

        Console.WriteLine("=== Новелла: ПРОБУЖДЕНИЕ ===\n");

        while (!gameOver && step <= 20)
        {
            // --- ШАГ 1 ---
            if (step == 1)
            {
                Console.WriteLine("Ты просыпаешься в темной комнате. Что будешь делать?");
                Console.WriteLine("1 - Встать с кровати");
                Console.WriteLine("2 - Остаться лежать");
                string c = Console.ReadLine();

                if (c == "1") step = 2;
                else step = 3;
            }

            // --- ШАГ 2 ---
            else if (step == 2)
            {
                Console.WriteLine("Ты встаёшь. Перед тобой дверь и окно.");
                Console.WriteLine("1 - К двери");
                Console.WriteLine("2 - К окну");
                string c = Console.ReadLine();

                if (c == "1") step = 4;
                else step = 5;
            }

            // --- КОНЦОВКА 1 ---
            else if (step == 3)
            {
                Console.WriteLine("Ты остался лежать и заснул навсегда.");
                Console.WriteLine("Концовка 1 — Лень — сила 😴");
                gameOver = true;
            }

            // --- ШАГ 4 ---
            else if (step == 4)
            {
                Console.WriteLine("Ты вышел в тёмный коридор.");
                Console.WriteLine("1 - Идти вперёд");
                Console.WriteLine("2 - Вернуться");
                string c = Console.ReadLine();

                if (c == "1") step = 6;
                else step = 3;  // возвращение ведёт к концовке 1
            }

            // --- ШАГ 5 ---
            else if (step == 5)
            {
                Console.WriteLine("Окно приоткрыто. Свежий воздух.");
                Console.WriteLine("1 - Вылезти");
                Console.WriteLine("2 - Закрыть и уйти");
                string c = Console.ReadLine();

                if (c == "1")
                {
                    Console.WriteLine("Ты выбрался наружу.");
                    Console.WriteLine("Концовка 2 — Побег 🌅");
                    gameOver = true;
                }
                else step = 4;
            }

            // --- ШАГ 6 ---
            else if (step == 6)
            {
                Console.WriteLine("Коридор длинный. Лестница вниз и дверь направо.");
                Console.WriteLine("1 - Лестница");
                Console.WriteLine("2 - Дверь направо");
                string c = Console.ReadLine();

                if (c == "1") step = 7;
                else step = 8;
            }

            // --- ШАГ 7 ---
            else if (step == 7)
            {
                Console.WriteLine("Подвал. Сырость. Что делать?");
                Console.WriteLine("1 - Осмотреться");
                Console.WriteLine("2 - Вернуться");
                string c = Console.ReadLine();

                if (c == "1") step = 9;
                else step = 6;
            }

            // --- ШАГ 8 ---
            else if (step == 8)
            {
                Console.WriteLine("Комната с мигающим компьютером.");
                Console.WriteLine("1 - Включить");
                Console.WriteLine("2 - Игнорировать");
                string c = Console.ReadLine();

                if (c == "1") step = 10;
                else step = 11;
            }

            // --- ШАГ 9 ---
            else if (step == 9)
            {
                Console.WriteLine("Ты нашёл сундук. Открыть?");
                Console.WriteLine("1 - Да");
                Console.WriteLine("2 - Нет");
                string c = Console.ReadLine();

                if (c == "1")
                {
                    Console.WriteLine("Сундук поглощает тебя.");
                    Console.WriteLine("Концовка 3 — Тьма 🕳️");
                    gameOver = true;
                }
                else step = 6;
            }

            // --- ШАГ 10 ---
            else if (step == 10)
            {
                Console.WriteLine("Компьютер спрашивает: 'ВЫЙТИ ИЛИ ОСТАТЬСЯ?'");
                Console.WriteLine("1 - Выйти");
                Console.WriteLine("2 - Остаться");
                string c = Console.ReadLine();

                if (c == "1") step = 12;
                else
                {
                    Console.WriteLine("Компьютер затягивает тебя внутрь...");
                    Console.WriteLine("Концовка 4 — Цифровой плен 💻");
                    gameOver = true;
                }
            }

            // --- ШАГ 11 ---
            else if (step == 11)
            {
                Console.WriteLine("Ты спотыкаешься и теряешь сознание...");
                Console.WriteLine("Концовка 5 — Несчастный случай 💀");
                gameOver = true;
            }

            // --- ШАГ 12 ---
            else if (step == 12)
            {
                Console.WriteLine("Тайная дверь. Лестница вверх и шум за стеной.");
                Console.WriteLine("1 - Подняться");
                Console.WriteLine("2 - Проверить звук");
                string c = Console.ReadLine();

                if (c == "1") step = 13;
                else step = 14;
            }

            // --- ШАГ 13 ---
            else if (step == 13)
            {
                Console.WriteLine("Крыша! Вид на город.");
                Console.WriteLine("1 - Прыгнуть");
                Console.WriteLine("2 - Спуститься по лестнице");
                string c = Console.ReadLine();

                if (c == "1")
                {
                    Console.WriteLine("Ты падаешь...");
                    Console.WriteLine("Концовка 6 — Падение 🕊️");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Ты спустился вниз.");
                    Console.WriteLine("Концовка 7 — Побег через крышу 🏙️");
                    gameOver = true;
                }
            }

            // --- ШАГ 14 ---
            else if (step == 14)
            {
                Console.WriteLine("Тоннель за стеной.");
                Console.WriteLine("1 - Ползти");
                Console.WriteLine("2 - Вернуться");
                string c = Console.ReadLine();

                if (c == "1") step = 15;
                else step = 12;
            }

            // --- ШАГ 15 ---
            else if (step == 15)
            {
                Console.WriteLine("Свет впереди.");
                Console.WriteLine("1 - Выползти");
                Console.WriteLine("2 - Осторожно выглянуть");
                string c = Console.ReadLine();

                if (c == "1")
                {
                    Console.WriteLine("Ты в лесу!");
                    Console.WriteLine("Концовка 8 — Свобода 🌲");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Ты увидел странное существо.");
                    Console.WriteLine("Концовка 9 — Существо 👁️");
                    gameOver = true;
                }
            }

            // --- ШАГ 16 = нейтральная концовка ---
            else if (step == 16)
            {
                Console.WriteLine("Ты ходишь по коридору, и он повторяется...");
                Console.WriteLine("Концовка 10 — Вечная петля ♾️");
                gameOver = true;
            }

            // если step > 16
            else
            {
                step = 16; // ведём в петлю
            }

            if (!gameOver)
                step++;
        }

        Console.WriteLine("\nСпасибо за игру!");
        Console.ReadLine();
    }
}

