/**************************************************/
/*            Лабораторна робота №3               */
/*   Арифметичні операції та математичні функції  */
/*                  мови C#                       */
/*         Приклад вирішення. Варіант №14.        */
/**************************************************/

using System;

class Program
{
    static void Main()
    {
        // Вхідні дані
        Console.Write("Введіть значення змінних n, x, a: ");
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());

        // Обчислення t1
        double t1 = (1 / (2 * (n - 1) * Math.Pow(x, n - 1))) + (a / (2 * n * Math.Pow(x, n)));

        // Обчислення t2
        double t2 = (1 / (2 * a)) * Math.Pow(Math.Tan(a * x), 2) + (1 / a) * Math.Log(Math.Cos(a * x));

        // Виведення результатів
        Console.WriteLine($"\nt1 = {t1:F6}");
        Console.WriteLine($"t2 = {t2:F6}");
    }
}
