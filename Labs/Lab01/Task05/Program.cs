using System;

class Program
{
    static void Main()
    {
        // Введення координат точки
        Console.Write("Введіть координату x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        double y = double.Parse(Console.ReadLine());

        // Перевірка, чи точка потрапляє у прямокутник
        bool isInRectangle = (x >= 0 && x <= 1 && y >= 0 && y <= 1);

        // Перевірка, чи точка потрапляє у півколо
        bool isInSemicircle = (x * x + y * y <= 1 && y <= 0);

        // Якщо точка належить або до прямокутника, або до півкола
        if (isInRectangle || isInSemicircle)
        {
            Console.WriteLine("Точка потрапляє в задану область.");
        }
        else
        {
            Console.WriteLine("Точка не потрапляє в задану область.");
        }
    }
}
