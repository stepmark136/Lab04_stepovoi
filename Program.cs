 int age = 15;
 if (age >= 21)
 {
     System.Console.WriteLine("Доступ разрешён");
 }
 System.Console.WriteLine("Программа продолжает работу");

 int age = 15;
 if (age >= 18)
 {
     System.Console.WriteLine("Доступ разрешен");
 } else
 {
     System.Console.WriteLine("Доступ запрещен");
     System.Console.WriteLine($"До совершеннолетия осталось {18 - age} лет.");
 }