// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();
Console.WriteLine("Копирование Массива");
Console.WriteLine("*******************");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] CopiArray(int[] array)
{
    int[] arr2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i];
    }
    return arr2;
}
int[] array1 = CreateArrayRndInt(10, 10, 20);
Console.WriteLine("Исходный Массив");
PrintArray(array1);
Console.WriteLine();
int[] array2 = CopiArray(array1);
Console.WriteLine("Новый Массив");
PrintArray(array2);
Console.WriteLine();