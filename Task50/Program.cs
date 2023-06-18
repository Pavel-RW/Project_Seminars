// 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого элемента в массиве нет


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

(int rows, int columns) GetIndexes(int matrixRows, int matrixColumns)
{
    int rows = -1, columns = -1;
    bool areIndexesValid = false;
    while (!areIndexesValid)
    {
        Console.Write("Enter element position (\"rows, columns\"): ");
        string input = Console.ReadLine();
        string[] indexes = input.Split(',');
        if (indexes.Length != 2 || (rows = Convert.ToInt32(indexes[0])) < 0 || (columns = Convert.ToInt32(indexes[1])) < 0)
        {
            Console.WriteLine("Error. Enter two numbers separated by commas.");
            continue;
        }

        if (rows < 0 || rows >= matrixRows || columns < 0 || columns >= matrixColumns)
        {
            Console.WriteLine($"Error. Enter position ({rows}, {columns}) outside array.");
            continue;
        }

        areIndexesValid = true;
    }

    return (rows, columns);
}

int GetElement(int[,] matrix, int rows, int columns)
{
    return matrix[rows, columns];
}

int[,] array2d = CreateMatrixRndInt(7, 7, -100, 100);
PrintMatrix(array2d);
(int rows, int columns) = GetIndexes(array2d.GetLength(0), array2d.GetLength(1));
int value = GetElement(array2d, rows, columns);
Console.WriteLine($"Element value ({rows}, {columns}): {value}");
