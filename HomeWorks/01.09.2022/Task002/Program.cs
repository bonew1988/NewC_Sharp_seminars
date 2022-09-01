// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//--------------------------------------------------------------------------------------------------------------------

Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.Write("Введите число #1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

Console.WriteLine("-----------------");
Console.WriteLine($"Максимальное значение: {max}");
Console.WriteLine($"Минимальное значение: {min}");
