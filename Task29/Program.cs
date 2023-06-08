// 29.Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] array)
{
    Console.WriteLine("Enter 8 array elements: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] array1 = new int[8];
FillArray(array1);
PrintArray(array1);