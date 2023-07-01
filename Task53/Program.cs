//  53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую
//  и последнюю строку массива.

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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

void SwapRowsColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

bool IsMatrixSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 100);
PrintMatrix(matrix);
Console.WriteLine();
SwapRowsColumns(matrix);
PrintMatrix(matrix);
Console.WriteLine();