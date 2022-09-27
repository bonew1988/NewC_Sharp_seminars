// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    int sumInMethod = number % 10;
    if (number != 0)
    {
        sumInMethod += SumDigits(number / 10);
    }
    return sumInMethod;
}

int result = SumDigits(num);
Console.WriteLine(result);
