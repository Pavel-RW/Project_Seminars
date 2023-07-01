// 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// void SwapRowsColumns(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < arr.GetLength(1); j++)
//         {
//             int temp = arr[i, j];
//             arr[i, j] = arr[j, i];
//             arr[j, i] = temp;
//         }
//     }
// }

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

void ReaplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

bool IsMatrixSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 60);
PrintMatrix(matrix);
Console.WriteLine();
if (IsMatrixSquare(matrix))
{
    ReaplaceRowsColumns(matrix);
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Matrix not square!");
}
