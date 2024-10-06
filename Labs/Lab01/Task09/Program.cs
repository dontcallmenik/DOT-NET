using System;

class Program
{
    static void Main()
    {
        // Зовнішній цикл - для 5 періодів
        for (int n = 0; n < 5; n++)
        {
            // Виведення заголовка таблиці
            Console.WriteLine("|   x   |      y     |");
            Console.WriteLine("|-------|------------|");

            // Внутрішній цикл для одного періоду
            for (double x = 0; x < 4; x += 0.25)
            {
                double y;

                // 1-й відрізок: лінійний графік
                if (x < 1)
                {
                    y = 2 * x - 1;
                }
                // 2-й відрізок: частина кола
                else if (x < 3)
                {
                    y = 1 - Math.Sqrt(1 - (x - 2) * (x - 2));
                }
                // 3-й відрізок: спадна лінія
                else
                {
                    y = 7 - 2 * x;
                }

                // Виведення рядка таблиці
                Console.Write($"| {x + n * 4,5:F2} | {y,10:F7} |");

                // Визначення позиції точки для графіка
                int h = (int)((y + 1) * 10);
                if ((y - 1) * 10 - h > 0.5)
                {
                    h++;
                }

                // Виведення точки на графіку
                for (int i = 0; i < h; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            // Пауза до введення команди оператора
            Console.WriteLine("Натисніть клавішу Enter для продовження...");
            Console.ReadLine();
        }
    }
}
