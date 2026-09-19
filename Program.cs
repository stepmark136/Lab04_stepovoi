// int vozrast1 = 15;

// if (vozrast1 >= 21)
// {
//     System.Console.WriteLine("Доступ разрешён");
// }
// System.Console.WriteLine("Программа продолжает работу");

// System.Console.WriteLine();

// int vozrast2 = 15;

// if (vozrast2 >= 18)
// {
//     System.Console.WriteLine("Доступ разрешен");
// }
// else
// {
//     System.Console.WriteLine("Доступ запрещен");
//     System.Console.WriteLine($"До совершеннолетия осталось {18 - vozrast2} лет.");
// }
 


//  int age = 65;

// if (age < 13)
// {
//     Console.WriteLine("Ребёнок");
// }
// else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }
// else if (age < 60)
// {
//     Console.WriteLine("Взрослый");
// }
// else
// {
//     Console.WriteLine("Пенсионер");
// }

// Console.WriteLine();

// int personAge = 12;
// double height = 1.4;
// bool hasAdultEscort = true;

// if ((personAge >= 14 && height >= 1.5) || hasAdultEscort)
// {
//     Console.WriteLine("Можно кататься");
// }
// else
// {
//     Console.WriteLine("Пока нельзя");
// }

// //ЗАДАЧА А 
// Console.WriteLine("--- Задача А ---");
// Console.Write("Введите число: ");
// int chisloA = int.Parse(Console.ReadLine());
// string rezA = (chisloA % 2 == 0) ? "Чётное" : "Нечётное";
// Console.WriteLine(rezA);
// Console.WriteLine();

// //ЗАДАЧА Г
// Console.WriteLine("--- Задача Г ---");
// Console.Write("Введите год: ");
// int godG = int.Parse(Console.ReadLine());
// if ((godG % 4 == 0 && godG % 100 != 0) || (godG % 400 == 0))
// {
//     Console.WriteLine("Год високосный");
// }
// else
// {
//     Console.WriteLine("Год не високосный");
// }
// Console.WriteLine();

//ВАРИАНТ 2
Console.WriteLine("--- Вариант 2 ---");
Console.Write("Введите ваш возраст: ");
int vozrastV2 = int.Parse(Console.ReadLine());
if (vozrastV2 >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}
Console.WriteLine();

//ВАРИАНТ 6
Console.WriteLine("--- Вариант 6 ---");
Console.Write("Введите баллы (0-100): ");
int bally = int.Parse(Console.ReadLine());
if (bally < 0 || bally > 100)
{
    Console.WriteLine("Неверное значение");
}
else if (bally >= 90)
{
    Console.WriteLine("Отлично");
}
else if (bally >= 75)
{
    Console.WriteLine("Хорошо");
}
else if (bally >= 60)
{
    Console.WriteLine("Удовлетворительно");
}
else
{
    Console.WriteLine("Неудовлетворительно");
}
Console.WriteLine();