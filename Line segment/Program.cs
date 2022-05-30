Console.Write("Введите число из отрезка [10, 99]; А = ");
int numberA = int.Parse(Console.ReadLine());
if (numberA > 9 && numberA < 100)
{
    int number1 = (numberA % 10);
    int number2 = (numberA / 10);
        if (number1 > number2)
        {
        Console.WriteLine($"{number1} - это наибольшая цифра числа {numberA}");
        }
        else
        {
        Console.WriteLine($"{number2} - это наибольшая цифра числа {numberA}");
        }
}
else
{
     Console.WriteLine($"{numberA} - данное число не попадает в отрезок [10, 99]");
}