// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Автор: Новиков ВВ");
Console.WriteLine("-----------------");
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num1)
{
    return (num1 >= 6);
}
if (num <= 7 && num >= 1)
{
    bool result = Weekend(num);
    if (result) Console.WriteLine($"Выходной");
    else Console.WriteLine($"Будний");
}
else Console.WriteLine($"Введите корректный номер дня недели");