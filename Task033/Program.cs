// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] IntMatrixLinesToColumnsChanger(int[,] matrix)
{
    int linesCount = matrix.GetLength(0),
        columnsCount = matrix.GetLength(1);
    int[,] newmatrix = new int[columnsCount, linesCount];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newmatrix[j, i] = matrix[i, j];
        }
    }
    return newmatrix;
}

Console.Clear();
Random randomizer = new Random();
int randomRows = randomizer.Next(4, 7),
    randomColumns = randomizer.Next(4, 7);

int[,] array2D = CreateMatrixRndInt(randomRows, randomColumns, 10, 20);
PrintMatrix(array2D);
Console.WriteLine("------------------------------");
if (randomRows == randomColumns)
{
    int[,] result = IntMatrixLinesToColumnsChanger(array2D);
    PrintMatrix(result);
}
else Console.WriteLine("Это сделать невозможно");
