Console.Write("Введите трехзначное число; А = ");
int numberA = int.Parse(Console.ReadLine());
if (numberA > 99 && numberA < 1000)
{
    int number = (numberA % 10);
    Console.WriteLine($"{number} - это последняя цифра введенного трехзначного числа");
}
else
{
     Console.WriteLine($"{numberA} - это не трехзначное число");
}