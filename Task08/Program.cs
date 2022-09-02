// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int a1)
{
    return (a1 % 7 == 0 && a1 % 23 == 0);
}

bool result = Multiplicity(a);

if (result) Console.WriteLine($"{a} кратно 7 и 23");
else Console.WriteLine($"{a} некратно 7 и 23");