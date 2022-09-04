// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int count = 1;
// int multiplier = 10;

int Depth(int num, int num1, int count1)
{
while (num1 >= 1000)
{
num1 = num / count1;
count1 = count1 * 10;
}
return num1;
}
if (number >= 1000)
{
int result = Depth(number, number1, count);
Console.WriteLine($"{result}");
}
else Console.WriteLine($"плохо");






// Console.Clear();
// Console.WriteLine("Автор: Новиков ВВ");
// Console.WriteLine("-----------------");
// Console.Write("Введите трехзначное число: ");
// int count1 = 1;
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = 10000;
// int depth = 10;
// Console.WriteLine();
// Console.WriteLine("-----------------");
// if (num1 >= -99 && num1 <= 99)
// {
//     Console.WriteLine($"Нет третьей цифры");
// }
// else if (num1 < 0)
// {
//     num1 = -num1;
// }
// else num1 = num1;
// while (num2 >= 1000)
// {
//     num2 = num1 / count1;
//     count1 = count1 * depth;
// }
// Console.WriteLine(num2 % 10);