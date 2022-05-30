Console.Write("Введите число; А = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число; B = ");
int numberB = int.Parse(Console.ReadLine());
if (numberA % numberB == 0)
{
    Console.WriteLine($"{numberA} кратно числу {numberB}");
}
else
{
    int n = ((numberA * 10) / numberB) % 10;
     Console.WriteLine($"{numberA} не кратно числу {numberB}, остаток после деления данных чисел друг на друга составляет - {n}");
}