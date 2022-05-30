Console.Write("Введите число 1; А = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2; B = ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число 3; C = ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"Максимальное число - A = {numberA}");
}
else if (numberB > numberC)
{
     Console.WriteLine($"Максимальное число - B = {numberB}");
}
else
{
     Console.WriteLine($"Максимальное число - C = {numberC}");
}