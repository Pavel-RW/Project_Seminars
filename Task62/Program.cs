// 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


static int[,] FillSpiralMatrix(int rows, int cols, int min)
{
    int[,] matrix = new int[rows, cols];
    int value = min;
    int layer = 0;
    while (value <= rows * cols + min - 1)
    {
        for (int i = layer; i < cols - layer; i++)
        {
            matrix[layer, i] = value++;
        }

        for (int i = layer + 1; i < rows - layer; i++)
        {
            matrix[i, cols - layer - 1] = value++;
        }

        for (int i = cols - layer - 2; i >= layer; i--)
        {
            matrix[rows - layer - 1, i] = value++;
        }

        for (int i = rows - layer - 2; i > layer; i--)
        {
            matrix[i, layer] = value++;
        }

        layer++;
    }

    return matrix;
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillSpiralMatrix(4, 4, 10);
PrintMatrix(matrix);
