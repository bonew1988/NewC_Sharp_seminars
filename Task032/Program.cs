﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns]; //0, 1, 2

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}
Console.Clear();

Random randomizer = new Random();
int randomRows = randomizer.Next(4, 7),
    randomColumns = randomizer.Next(4, 7);

int[,] array2D = CreateMatrixRndInt(randomRows, randomColumns);
PrintMatrix(array2D);
Console.WriteLine("-------------------------------------------------------------");
int[,] IntMatrixLinesChanger(int[,] matrix)
{
    int temp = default,
        linesCount = matrix.GetLength(0),
        columnsCount = matrix.GetLength(1);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0) 
            {
            temp = matrix[i, j];
            matrix[i, j] = matrix[linesCount - 1, j];
            matrix[linesCount-1,j]=temp;
            }
        }
    }
    return matrix;
}

int[,]result = IntMatrixLinesChanger(array2D);
PrintMatrix(result);