// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("-----------------");

if (num1 > 99 && num1 < 1000)
{
    Console.WriteLine($"{num1 / 10 % 10}");
}
else Console.WriteLine($"Вы ввели невеное число");