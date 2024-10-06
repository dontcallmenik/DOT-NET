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

        // Виведення результату за допомогою тернарного оператора
        Console.WriteLine(isInRectangle || isInSemicircle
            ? "Точка потрапляє в задану область."
            : "Точка не потрапляє в задану область.");
    }
}
