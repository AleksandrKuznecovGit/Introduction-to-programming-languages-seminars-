Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
Console.WriteLine("Максимальное число - "+a + " минимальное число "+b);
else Console.WriteLine("Максимальное число - " + b + " минимальное число " + a);