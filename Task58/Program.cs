// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18

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

bool CanMultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);

    return columns1 == rows2;
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            
            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            
            result[i, j] = sum;
        }
    }

    return result;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 10);

Console.WriteLine("Matrix 1:");
PrintMatrix(matrix1);
Console.WriteLine();

Console.WriteLine("Matrix 2:");
PrintMatrix(matrix2);
Console.WriteLine();

if (CanMultiplyMatrices(matrix1, matrix2))
{
    int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
    Console.WriteLine("Result:");
    PrintMatrix(resultMatrix);
}
else
{
    Console.WriteLine("Unable to multiply matrices.");
}
