/*******************************************************/
/*            Лабораторна  робота №1                   */
/*         Типи даних і введення-виведення             */
/*        Приклад виконання. Варіант № 14              */
/*******************************************************/

using System;

class Program
{
    static void Main()
    {
        // Оголошення змінних
        string name1, name2, name3;
        uint code1, code2, code3; // Кількість рядків коду
        float time1_sgi1, time1_sgi2; // Час виконання на SGI Challenge та SGI Indy

        // Введення даних для першої програми
        Console.Write("1. Введіть: назву програми, кількість рядків коду, час на SGI Challenge, час на SGI Indy > ");
        string[] input1 = Console.ReadLine().Split(' ');
        name1 = input1[0];
        code1 = uint.Parse(input1[1]);
        time1_sgi1 = float.Parse(input1[2]);
        time1_sgi2 = float.Parse(input1[3]);

        // Введення даних для другої програми
        Console.Write("2. Введіть: назву програми, кількість рядків коду, час на SGI Challenge, час на SGI Indy > ");
        string[] input2 = Console.ReadLine().Split(' ');
        name2 = input2[0];
        code2 = uint.Parse(input2[1]);
        time1_sgi1 = float.Parse(input2[2]);
        time1_sgi2 = float.Parse(input2[3]);

        // Введення даних для третьої програми
        Console.Write("3. Введіть: назву програми, кількість рядків коду, час на SGI Challenge, час на SGI Indy > ");
        string[] input3 = Console.ReadLine().Split(' ');
        name3 = input3[0];
        code3 = uint.Parse(input3[1]);
        time1_sgi1 = float.Parse(input3[2]);
        time1_sgi2 = float.Parse(input3[3]);

        // Налаштування кольорів для різних частин таблиці
        Console.ForegroundColor = ConsoleColor.Green; // Колір для рамки таблиці
        Console.WriteLine("┌───────────────────┬───────────────────────┬────────────────────────┬──────────────────┐");
        Console.WriteLine("│   Час виконання деяких програм, які застосовують паралельні алгоритми   │");
        Console.WriteLine("├───────────────────┬───────────────────────┬────────────────────────┬──────────────────┤");
        Console.WriteLine("│   Назва програми  │ Кількість рядків коду │ Час SGI Challenge (сек) │ Час SGI Indy (сек)│");
        Console.WriteLine("├───────────────────┼───────────────────────┼────────────────────────┼──────────────────┤");

        // Виведення даних для кожної програми з різними кольорами
        Console.ForegroundColor = ConsoleColor.Yellow; // Колір для тексту (назви програм)
        Console.Write("│ {0,-17} │", name1);
        Console.ForegroundColor = ConsoleColor.Cyan; // Колір для чисел (кількість рядків і час)
        Console.Write(" {0,21} │ {1,22:F2} │ {2,16:F2} │\n", code1, time1_sgi1, time1_sgi2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("│ {0,-17} │", name2);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(" {0,21} │ {1,22:F2} │ {2,16:F2} │\n", code2, time1_sgi1, time1_sgi2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("│ {0,-17} │", name3);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(" {0,21} │ {1,22:F2} │ {2,16:F2} │\n", code3, time1_sgi1, time1_sgi2);

        // Виведення нижньої межі таблиці
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("└───────────────────┴───────────────────────┴────────────────────────┴──────────────────┘");

        // Повернення кольору до стандартного для інших виводів
        Console.ResetColor();
    }
}
