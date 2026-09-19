//  int age = 15;
//  if (age >= 21)
//  {
//      System.Console.WriteLine("Доступ разрешён");
//  }
//  System.Console.WriteLine("Программа продолжает работу");

//  int age = 15;
//  if (age >= 18)
//  {
//      System.Console.WriteLine("Доступ разрешен");
//  } else
//  {
//      System.Console.WriteLine("Доступ запрещен");
//      System.Console.WriteLine($"До совершеннолетия осталось {18 - age} лет.");
//  }

 


 int age = 65;

if (age < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (age < 18)
{
    Console.WriteLine("Подросток");
}
else if (age < 60)
{
    Console.WriteLine("Взрослый");
}
else
{
    Console.WriteLine("Пенсионер");
}

Console.WriteLine();

int personAge = 12;
double height = 1.4;
bool hasAdultEscort = true;

if ((personAge >= 14 && height >= 1.5) || hasAdultEscort)
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}