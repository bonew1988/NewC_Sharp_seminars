﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Clear();
Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Square(int digit1, int count1)
{
    while(count1 <= digit1)
    {
        Console.WriteLine($"|{count1} -> {count1 * count1,3}|");
        count1 ++;
    }
}
Square(digit, count);