// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите натуральное число: ");
double number = Convert.ToDouble(Console.ReadLine());

double Multiplication(double num)
{
    double mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}
double result = Multiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} составит {result}");