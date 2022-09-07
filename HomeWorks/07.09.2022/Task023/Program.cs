// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//-------------------------------------------------------
Console.Clear();
Console.Write("Введите положительное целое число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Cube(int digit1, int count1)
{
    while (count1 <= digit1)
    {
        Console.WriteLine($"{count1} --> {count1 * count1 * count1,5}");
        count1++;
    }
}
Console.WriteLine();
if (digit >= 1)
{
    Cube(digit, count);
}
else Console.WriteLine($"Введено некорректное число");