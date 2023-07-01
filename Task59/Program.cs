// 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, 
// На выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] FindMin(int[,] matrix)
{
    int[] minIndexes = new int[2];
    int minElem = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minElem > matrix[i, j])
            {
                minElem = matrix[i, j];
                minIndexes[0] = i;
                minIndexes[1] = j;
            }
        }
    }
    return minIndexes;
}

int[,] RemoveRowCol(int[] indexes, int[,] matrix)
{
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1) - 1;
    int[,] newMatrix = new int[rows, columns];

    int m = 0;
    for (int i = 0; i < rows; i++)
    {
        if (m == indexes[0]) m++;
        int n = 0;
        for (int j = 0; j < columns; j++)
        {
            if (n == indexes[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return newMatrix;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 30);
PrintMatrix(matrix);
Console.WriteLine();

int[] minIndexes = FindMin(matrix);
int[,] newMatrix = RemoveRowCol(minIndexes, matrix);
PrintMatrix(newMatrix);
