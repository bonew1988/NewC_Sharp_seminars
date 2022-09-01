// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("-----------------");
int count = 2;
int parity = 2;
while (count <= num1)
{
    if (num1 % 2 == 0)
    {
        Console.Write($"{count} ");
        count = count + parity;
    }
    else
    {
        Console.Write($"{count} ");
        count = count + parity;
    }
}
Console.WriteLine();