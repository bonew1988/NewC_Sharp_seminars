// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
//---------------------------------------------------------------------------------------------------------------------------------------------
Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Введите размер трехмерного массива: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"Введите длину массива (X): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите высоту массива (Y): ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите глубину массива (Z): ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int content = x * y * z;
if (content > 90)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Элементов в массиве больше, чем уникальных натуральных двузначных чисел");
}
else
{
    int[,,] resultCoub = CreateCoubUniqueTwoDigitNumber(x, y, z, 10);
    Console.ForegroundColor = ConsoleColor.Green;
    PrintCoub(resultCoub);
}

int[,,] CreateCoubUniqueTwoDigitNumber(int rows, int columns, int depth, int num)
{
    int[,,] coub = new int[rows, columns, depth];
    for (int i = 0; i < coub.GetLength(0); i++)
    {
        for (int j = 0; j < coub.GetLength(1); j++)
        {
            for (int k = 0; k < coub.GetLength(2); k++)
            {
                coub[i, j, k] = num++;
            }

        }

    }
    return coub;
}

void PrintCoub(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ");
                Console.Write($"({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}









// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void WriteArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"Z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void CreateArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }