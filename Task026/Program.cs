// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
Random random = new Random();
int fibonacci = random.Next(2, 10);
void Fibonacci(int fibonacci1)
{
    int f1 = 0;
    int f2 = 1;
    Console.Write($"{f1} {f2} ");
    int result = default;
    for (int i = 2; i < fibonacci1; i++)
    {
        result = f1 + f2;
        Console.Write($"{result} ");
        f1 = f2;
        f2 = result;
    }
}
Console.WriteLine($"Ряд Фибоначчи для {fibonacci} :");
Fibonacci(fibonacci);
Console.WriteLine();