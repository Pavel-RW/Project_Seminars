// 43.Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double b1 = ReadConsole("Enter b1:");
double k1 = ReadConsole("Enter k1:");
double b2 = ReadConsole("Enter b2:");
double k2 = ReadConsole("Enter k2:");

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Error: lines coincide.");
    return;
}
else if (k1 == k2)
{
    Console.WriteLine("Error: lines are parallel.");
    return;
}

double[] intersectionPoint = IntersectionPoint(b1, k1, b2, k2);
double x = Math.Round(intersectionPoint[0], 1);
double y = Math.Round(intersectionPoint[1], 1);
Console.WriteLine($"IntersectionPoint: ({x}; {y})");

double ReadConsole(string prompt)
{
    Console.Write(prompt + " ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] result = { x, y };
    return result;
}
