
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == 0) Console.Write("[");
        if (i == count - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int[] ConvertMatrixToArrayBySort(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    Array.Sort(array);
    return array;
}

void MatchFinder(int[] array)
{
    int temp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (temp != array[i])
        {
            Console.WriteLine($"{temp} встречается {count} раз.");
            temp = array[i];
            count = 1;
        }
        else count++;
    }
    Console.WriteLine($"{temp} встречается {count} раз.");
}

Console.Clear();
Random randomizer = new Random();
int randomRows = randomizer.Next(3, 4),
    randomColumns = randomizer.Next(3, 4);

int[,] array2D = CreateMatrixRndInt(randomRows, randomColumns, -10, 20);
PrintMatrix(array2D);
Console.WriteLine("------------------------------");
int[] arrayResult = ConvertMatrixToArrayBySort(array2D);
PrintArray(arrayResult);
Console.WriteLine("------------------------------");
MatchFinder(arrayResult);