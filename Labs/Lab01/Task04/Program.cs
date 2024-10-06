using System;

class Program
{
    static void Main()
    {
        try
        {
            // Вхідні дані
            Console.Write("Введіть значення змінних n, x, a: ");
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            // Перевірка на ділення на нуль і недопустимі значення
            if (n == 1)
            {
                throw new ArgumentException("Значення n не може бути рівним 1, оскільки це призведе до ділення на нуль.");
            }

            if (a == 0)
            {
                throw new ArgumentException("Значення a не може бути рівним 0, оскільки це призведе до ділення на нуль.");
            }

            if (Math.Cos(a * x) <= 0)
            {
                throw new ArgumentException("Косинус не може бути меншим або рівним 0 для логарифма, оскільки це призведе до математичної помилки.");
            }

            // Обчислення t1
            double t1 = (1 / (2 * (n - 1) * Math.Pow(x, n - 1))) + (a / (2 * n * Math.Pow(x, n)));

            // Обчислення t2
            double t2 = (1 / (2 * a)) * Math.Pow(Math.Tan(a * x), 2) + (1 / a) * Math.Log(Math.Cos(a * x));

            // Виведення результатів
            Console.WriteLine($"\nt1 = {t1:F6}");
            Console.WriteLine($"t2 = {t2:F6}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: введені некоректні дані. Будь ласка, переконайтеся, що вводите числові значення.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Помилка: спроба ділення на нуль.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Невідома помилка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Обчислення завершено.");
        }
    }
}
