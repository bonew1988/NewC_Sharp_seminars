// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//-------------------------------------------------------

Console.Clear();
Console.WriteLine("Таблица кубов натуральных чисел");
Console.WriteLine("-------------");
Console.Write("Введите положительное целое число: ");
int digit = Convert.ToInt32(Console.ReadLine());
void Cube(int digit1)
{
    if(digit1>=1)
    {
        for (int i = 1; i <= digit1; i++)
        {
            Console.WriteLine($"{i} --> {i * i * i,4}");
        }
    }
    else Console.WriteLine($"Введено некорректное число");
}
Console.WriteLine();
Cube(digit);