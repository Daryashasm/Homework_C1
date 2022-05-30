Console.Write("Введите трехзначное число; А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 99 && numberA < 1000)
{
int n = 2;
int m = 1;
while (n > 1)
{
    m *= 10;
    n--;
}
int numberB = (numberA % m) + (numberA / (m * 10)) * m;
Console.WriteLine($"{numberB} - число после удаления 2 цифры");
}
else
{
    Console.WriteLine($"{numberA} - это не трехзначное число");
}