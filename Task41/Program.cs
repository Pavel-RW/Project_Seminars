// 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] CreateFillArray(int M)
{
    int[] arr = new int[M];

    for (int i = 0; i < M; i++)
    {
        Console.Write($"Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }

    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Enter quantity number: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr1 = CreateFillArray(M);
int count = CountPositiveNumbers(arr1);
PrintArray(arr1);
Console.Write($"Quantity number more 0: {count}");