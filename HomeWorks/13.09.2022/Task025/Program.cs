﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//----------------------------------------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("Возведение в степень числа");
Console.Write("Введите число, которое необходимо возвести в степень: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральную степень, в которую необходимо возвести число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int count = 1;
double numC = 1;
int numM = 0;
double Exponentiation(double num1, int num2, int i, double num3)
{
    i = 1;
    num3 = 1;
    while (i <= num2)
    {
        num3 = num3 * num1;
        i++;
    }
    return Math.Round(num3, 2);
}
if (numB < 0)
{
    Console.WriteLine($"-------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Вы ввели отрицательное число, данный алгоритм предназначен для нахождения только натуральной степени, возможно, Вы имели ввиду {-numB}");
    Console.WriteLine($"-------------------------------------------------------------------------------------------------------------------------------");

    numM = -numB;
}
else numM = numB;
double result = Exponentiation(numA, numM, count, numC);
Console.WriteLine($"{numA} в степени {numM} составит: {result}");