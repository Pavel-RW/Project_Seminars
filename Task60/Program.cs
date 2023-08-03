// 60. Cформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.

// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


static int[,,] CreateUniqueRandom3DArray(int sizeX, int sizeY, int sizeZ, int minValue, int maxValue)
{
    int[,,] array = new int[sizeX, sizeY, sizeZ];
    HashSet<int> usedNumbers = new HashSet<int>();

    Random random = new Random();
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)
            {
                int randomNumber;

                do
                {
                    randomNumber = random.Next(minValue, maxValue);
                } while (usedNumbers.Contains(randomNumber));

                usedNumbers.Add(randomNumber);
                array[i, j, k] = randomNumber;
            }
        }
    }

    return array;
}

static void Print3DArrayWithIndices(int[,,] array)
{
    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);

    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = CreateUniqueRandom3DArray(2, 2, 2, 10, 100);
Print3DArrayWithIndices(array);


