//день недели по номеру дня

Console.Clear();
Console.Write("Ведите число от 1 до 7: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1 < 8 && num1 > 0)
{
    if(num1 == 1) Console.WriteLine("Понедельник ");
    else if(num1 == 2) Console.WriteLine("Вторник ");
    else if(num1 == 3) Console.WriteLine("Среда ");
    else if(num1 == 4) Console.WriteLine("Четверг ");
    else if(num1 == 5) Console.WriteLine("Пятница ");
    else if(num1 == 6) Console.WriteLine("Суббота ");
    else if(num1 == 7) Console.WriteLine("Воскресенье ");
}
else 
{
    Console.WriteLine("Ошибка, введите число от 1 до 7");
}
