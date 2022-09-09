// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
int[] arr = new int[8];

void ArrEight(int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr1[i]},");
        else
            Console.Write($"{arr1[i]}");
    }

    Console.WriteLine("]");
}
ArrEight(arr);
PrintArray(arr);
