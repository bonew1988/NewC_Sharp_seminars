// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
//-------------------------------------------------------------
Console.Clear();
Console.WriteLine("Введите номер четверти (1-4): ");
Console.WriteLine("------------------------------");
string quart = Console.ReadLine();
string Quarter(string quart1)
{
    if (quart1 == "1") return "xc > 0 ; yc > 0";
    if (quart1 == "2") return "xc < 0 ; yc > 0";
    if (quart1 == "3") return "xc < 0 ; yc < 0";
    if (quart1 == "4") return "xc > 0 ; yc < 0";
    return "Введен некорректный номер четверти";
}
Console.WriteLine("------------------------------");
string result = Quarter(quart);
Console.WriteLine(result);