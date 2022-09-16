﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
//---------------------------------------
Console.Clear();
int num = default;
Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.Write("Ошибка ввода. Введите целое число: ");
}

int ConvertNumber(int number)
{
    int result = 0;
    int count = 1;
    while (number != 0)
    {
        result += (number % 2) * count;
        number /= 2;
        count *= 10;
    }
    return result;
}
Console.WriteLine($"Данное число в двоичном счислении: {ConvertNumber(num)}");