// 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max, int round)
{
    Random rnd = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

double Max(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double Min(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double Diff(double max, double min)
{
    double diff = Math.Round(max - min, 2);
    return diff;
}

double[] array = CreateArrayRndDouble(5, 0, 100, 2);
PrintArrayDouble(array);
double max = Max(array);
double min = Min(array);
double diff = Diff(max, min);
Console.WriteLine($" => {max} - {min} = {diff}");