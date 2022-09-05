// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.WriteLine();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("-----------------");
int counter = 1;
int number2 = 10000;
int result2 = 0;
int Module(int num3)
{
    if (num3 < 0)
    {
        return -num3;
    }
    else return num3;
}
int Depth(int num, int count, int num2)
{
    if (num2 > 1000)
    {
        while (num2 > 1000)
        {
            num2 = num / count;
            count = count * 10;
        }
        return num2;
    }
    else return num2 = num;
}
int result = Module(number);
int result1 = Depth(result, counter, number2);

if (result1 < -99 || result1 > 99)
{
    result2 = result1 % 10;
    Console.WriteLine($"{result2}");
}
else Console.WriteLine($"нет третьей цифры");