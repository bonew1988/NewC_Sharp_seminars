// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//----------------------------------------------------------------------------------------------

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3}| ");
            else
                Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

void SortDescOrderArrayRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(1) - 1; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int temp = matrix[i, l + 1];
                    matrix[i, l + 1] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }
        }
    }
}
Console.Clear();
Random rand = new Random();
int randRows = rand.Next(5, 5),
    randColumns = rand.Next(5, 5);
Console.WriteLine("Исходный массив");
Console.WriteLine("*******************************************************");
int[,] array2D = CreateMatrixRndInt(randRows, randColumns, 1, 99);
PrintMatrix(array2D);
Console.WriteLine("Отсортированный массив");
Console.WriteLine("*******************************************************");
SortDescOrderArrayRows(array2D);
PrintMatrix(array2D);
