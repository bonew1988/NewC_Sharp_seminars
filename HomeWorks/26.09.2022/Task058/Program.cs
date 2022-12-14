// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//-------------------------------------------------------------------------------------------------------


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

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return result;
}

Console.Clear();
Random rand = new Random();
int randRows = rand.Next(3, 5),
    randColumns = rand.Next(3, 5);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Первая матрица");
Console.WriteLine("*******************************");
int[,] array2D1 = CreateMatrixRndInt(randRows, randColumns, 1, 10);
PrintMatrix(array2D1);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Вторая матрица");
Console.WriteLine("*******************************");
int[,] array2D2 = CreateMatrixRndInt(randRows, randColumns, 1, 10);
PrintMatrix(array2D2);
Console.WriteLine();


if (array2D1.GetLength(0) != array2D2.GetLength(1))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Операция невозможна");
}
else
{
    int[,] multyresult = MatrixMultiplication(array2D1, array2D2);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Результат произведения матриц");
    Console.WriteLine("*******************************");
    PrintMatrix(multyresult);
}