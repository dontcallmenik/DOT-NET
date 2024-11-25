// Контактна інформація
Console.WriteLine("Контактна інформація:");
Console.Write("Ім'я: ");
string name = Console.ReadLine();
Console.Write("Телефон: ");
string phone = Console.ReadLine();
Console.Write("Пошта: ");
string email = Console.ReadLine();
Console.Write("Дата відвідування: ");
DateTime visitDate = DateTime.Parse(Console.ReadLine());

// Персональна інформація
Console.WriteLine("Персональна інформація:");
Console.Write("Вік: ");
int age = int.Parse(Console.ReadLine());
Console.Write("Улюблена кухня: ");
string cuisine = Console.ReadLine();

// Оцінка установи
Console.WriteLine("Оцінка установи:");
Console.WriteLine("Чому обрали нашу установу?");
Console.WriteLine("1. Недалеко від роботи/дому");
Console.WriteLine("2. Побачив рекламу");
Console.WriteLine("3. Порадили");
Console.WriteLine("4. Оптимальне співвідношення ціни та якості");
Console.Write("Ваш вибір: ");
int reason = int.Parse(Console.ReadLine());

// Рекомендації
Console.WriteLine("Чи будете рекомендувати нашу установу друзям та знайомим?");
Console.WriteLine("1. Так");
Console.WriteLine("2. Ні");
Console.Write("Ваш вибір: ");
int recommendation = int.Parse(Console.ReadLine());

// Зберігання даних (можна записати в файл або базу даних)
// ...

Console.WriteLine("Дякуємо за участь у опитуванні!");
Console.ReadKey();
    