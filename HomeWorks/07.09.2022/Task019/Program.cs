// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//-------------------------------------------------------------

Console.Clear();
Console.WriteLine("Проверка пятизначного числа на палиндром");
Console.WriteLine("----------------------------------------");
Console.WriteLine();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("-----------------");
int Module(int num)
{
    if (num < 0)
    {
        return -num;
    }
    else return num;
}
int result = Module(number);
void Reverse(int num1)
{
    if (num1 / 10000 == num1 % 10 && num1 % 100 / 10 == num1 % 10000 / 1000)
    {
        Console.WriteLine($"Палиндром");
    }
    else Console.WriteLine($"НЕ палиндром");
}
if (result > 9999 & result <= 99999)
{
    Reverse(result);
}
else Console.WriteLine($"Введено некорректное число");