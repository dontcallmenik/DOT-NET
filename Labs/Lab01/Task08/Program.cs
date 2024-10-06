using System;

class Program
{
    static void Main()
    {
        // Введення похибки та кількості членів ряду
        Console.Write("Введіть точність (eps): ");
        double eps = double.Parse(Console.ReadLine());

        Console.Write("Введіть максимальну кількість членів ряду: ");
        int maxTerms = int.Parse(Console.ReadLine());

        double sum = 0;  // Сума членів ряду
        double term;     // Поточний член ряду
        int n = 0;       // Лічильник членів ряду

        // Основний цикл для обчислення суми ряду
        while (n < maxTerms)
        {
            // Обчислення чергового члена ряду
            term = Math.Pow(-1, n) * (n + 1) / (Math.Pow(n, 3) + 1);

            // Якщо поточний член за абсолютним значенням менший за похибку, виходимо з циклу
            if (Math.Abs(term) < eps)
            {
                Console.WriteLine($"Досягнута похибка eps = {eps} на {n + 1}-му члені ряду.");
                break;
            }

            // Накопичення суми
            sum += term;

            // Якщо обчислено 10 членів ряду, вивести проміжну суму
            if (n == 9)
            {
                Console.WriteLine($"Сума 10-ти членів ряду = {sum:F7}");
            }

            n++;  // Переходимо до наступного члена ряду
        }

        // Перевірка, чи обчислено повну кількість членів ряду
        if (n == maxTerms)
        {
            Console.WriteLine($"Досягнута максимальна кількість членів ряду = {maxTerms}.");
        }

        // Виведення остаточного значення суми
        Console.WriteLine($"Повна сума ряду = {sum:F7}");
    }
}
