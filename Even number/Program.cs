Console.Write("Введите число; А = ");
int numberA = int.Parse(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine($"Число A = {numberA} - четное");
}
else
{
     Console.WriteLine($"Число - А = {numberA} - нечетное");
}
