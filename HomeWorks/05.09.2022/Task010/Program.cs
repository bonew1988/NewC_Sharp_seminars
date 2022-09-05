// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.WriteLine();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("-----------------");

int Module(int num)
{
    if (num < 0)
    {
        return -num;
    }
    else return num;
}
int result = Module(number);
if (result > 99 && result < 1000)
{
    result = result / 10 % 10;
    Console.WriteLine($"{result}");
}
else Console.WriteLine($"Вы ввели неверное число");