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
            switch (step)
            {
                case 1:
                    Console.WriteLine("Ты просыпаешься в темной комнате. Что будешь делать?");
                    Console.WriteLine("1 - Встать с кровати");
                    Console.WriteLine("2 - Остаться лежать");
                    string s1 = Console.ReadLine();

                    if (s1 == "1") step = 2;
                    else step = 3;
                    break;

                case 2:
                    Console.WriteLine("Ты встаёшь. Перед тобой дверь и окно. Куда пойдёшь?");
                    Console.WriteLine("1 - К двери");
                    Console.WriteLine("2 - К окну");
                    string s2 = Console.ReadLine();

                    if (s2 == "1") step = 4;
                    else step = 5;
                    break;

                case 3:
                    Console.WriteLine("Ты остался лежать. Вскоре снова заснул навсегда...");
                    Console.WriteLine("Концовка 1 — Лень — сила 😴");
                    gameOver = true;
                    break;

                case 4:
                    Console.WriteLine("Ты открываешь дверь и выходишь в тёмный коридор.");
                    Console.WriteLine("1 - Идти вперёд");
                    Console.WriteLine("2 - Вернуться");
                    string s3 = Console.ReadLine();

                    if (s3 == "1") step = 6;
                    else step = 3; // если вернулся — конец тот же
                    break;

                case 5:
                    Console.WriteLine("Ты открываешь окно и чувствуешь свежий воздух.");
                    Console.WriteLine("1 - Вылезти наружу");
                    Console.WriteLine("2 - Закрыть и вернуться");
                    string s4 = Console.ReadLine();

                    if (s4 == "1")
                    {
                        Console.WriteLine("Ты выбрался наружу и убежал прочь.");
                        Console.WriteLine("Концовка 2 — Побег 🌅");
                        gameOver = true;
                    }
                    else step = 4;
                    break;

                case 6:
                    Console.WriteLine("Коридор тянется далеко. Ты видишь лестницу вниз и дверь направо.");
                    Console.WriteLine("1 - Лестница вниз");
                    Console.WriteLine("2 - Дверь направо");
                    string s5 = Console.ReadLine();

                    if (s5 == "1") step = 7;
                    else step = 8;
                    break;

                case 7:
                    Console.WriteLine("Ты спустился в подвал. Здесь пахнет сыростью и чем-то металлическим...");
                    Console.WriteLine("1 - Осмотреться");
                    Console.WriteLine("2 - Вернуться наверх");
                    string s6 = Console.ReadLine();

                    if (s6 == "1") step = 9;
                    else step = 6;
                    break;

                case 8:
                    Console.WriteLine("Ты входишь в комнату с компьютером, экран мигает.");
                    Console.WriteLine("1 - Включить");
                    Console.WriteLine("2 - Игнорировать");
                    string s7 = Console.ReadLine();

                    if (s7 == "1") step = 10;
                    else step = 11;
                    break;

                case 9:
                    Console.WriteLine("Ты находишь сундук. Открыть его?");
                    Console.WriteLine("1 - Да");
                    Console.WriteLine("2 - Нет");
                    string s8 = Console.ReadLine();

                    if (s8 == "1")
                    {
                        Console.WriteLine("Из сундука выползает тьма и поглощает тебя...");
                        Console.WriteLine("Концовка 3 — Тьма 🕳️");
                        gameOver = true;
                    }
                    else step = 6;
                    break;

                case 10:
                    Console.WriteLine("Компьютер показывает сообщение: 'ВЫЙТИ ИЛИ ОСТАТЬСЯ?'");
                    Console.WriteLine("1 - Выйти");
                    Console.WriteLine("2 - Остаться");
                    string s9 = Console.ReadLine();

                    if (s9 == "1")
                    {
                        Console.WriteLine("Экран гаснет, и открывается тайная дверь.");
                        step = 12;
                    }
                    else
                    {
                        Console.WriteLine("Экран мерцает, и ты проваливаешься внутрь...");
                        Console.WriteLine("Концовка 4 — Поглощён цифровым миром 💻");
                        gameOver = true;
                    }
                    break;

                case 11:
                    Console.WriteLine("Ты проходишь мимо и спотыкаешься, ударяешься головой...");
                    Console.WriteLine("Концовка 5 — Несчастный случай 💀");
                    gameOver = true;
                    break;

                case 12:
                    Console.WriteLine("Ты заходишь в комнату с лестницей вверх и странным звуком за стеной.");
                    Console.WriteLine("1 - Подняться");
                    Console.WriteLine("2 - Проверить звук");
                    string s10 = Console.ReadLine();

                    if (s10 == "1") step = 13;
                    else step = 14;
                    break;

                case 13:
                    Console.WriteLine("Ты выходишь на крышу и видишь город!");
                    Console.WriteLine("1 - Прыгнуть вниз с парапета");
                    Console.WriteLine("2 - Спуститься по пожарной лестнице");
                    string s11 = Console.ReadLine();

                    if (s11 == "1")
                    {
                        Console.WriteLine("Ты прыгаешь... но парашюта нет.");
                        Console.WriteLine("Концовка 6 — Падение 🕊️");
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Ты аккуратно спускаешься вниз и оказываешься на улице!");
                        Console.WriteLine("Концовка 7 — Побег через крышу 🏙️");
                        gameOver = true;
                    }
                    break;

                case 14:
                    Console.WriteLine("Ты приоткрываешь стену и видишь маленький тоннель.");
                    Console.WriteLine("1 - Ползти туда");
                    Console.WriteLine("2 - Вернуться назад");
                    string s12 = Console.ReadLine();

                    if (s12 == "1") step = 15;
                    else step = 12;
                    break;

                case 15:
                    Console.WriteLine("Ты ползёшь долго, и наконец видишь свет в конце...");
                    Console.WriteLine("1 - Выползти");
                    Console.WriteLine("2 - Осторожно выглянуть");
                    string s13 = Console.ReadLine();

                    if (s13 == "1")
                    {
                        Console.WriteLine("Ты выбрался наружу в лес.");
                        Console.WriteLine("Концовка 8 — Свобода 🌲");
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Ты выглянул... и увидел странное существо.");
                        Console.WriteLine("Концовка 9 — Существо 👁️");
                        gameOver = true;
                    }
                    break;

                case 16:
                    Console.WriteLine("Ты идёшь по длинному коридору, но всё повторяется...");
                    Console.WriteLine("Концовка 10 — Петля времени ♾️");
                    gameOver = true;
                    break;

                default:
                    step = 16;
                    break;
            }

            if (!gameOver)
                step++;
        }

        Console.WriteLine("\nСпасибо за игру!");
        Console.ReadLine();
    }
}
