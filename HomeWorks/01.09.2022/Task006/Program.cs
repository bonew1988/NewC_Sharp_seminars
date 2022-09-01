// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
{
    Console.WriteLine("четное");
}
else Console.WriteLine("нечетное");

