Console.Write("Введите номер дня: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay == 1)
{
    Console.WriteLine($"{numberDay} день недели - это ПОНЕДЕЛЬНИК");
}
else if (numberDay == 2)
{
     Console.WriteLine($"{numberDay} день недели - это ВТОРНИК");
}
else if (numberDay == 3)
{
     Console.WriteLine($"{numberDay} день недели - это СРЕДА");
}
else if (numberDay == 4)
{
     Console.WriteLine($"{numberDay} день недели - это ЧЕТВЕРГ");
}
else if (numberDay == 5)
{
     Console.WriteLine($"{numberDay} день недели - это ПЯТНИЦА");
}
else if (numberDay == 6)
{
     Console.WriteLine($"{numberDay} день недели - это СУББОТА");
}
else if (numberDay == 7)
{
     Console.WriteLine($"{numberDay} день недели - это ВОСКРЕСЕНЬЕ");
}
else
{
     Console.WriteLine($"{numberDay} - такого дня недели нет, в 1 неделе всего 7 дней");
}
