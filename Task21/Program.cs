// 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Enter x point 1: ");
int y1 = ReadInt("Enter y point 1: ");
int z1 = ReadInt("Enter z point 1: ");
int x2 = ReadInt("Enter x point 2: ");
int y2 = ReadInt("Enter y point 2: ");
int z2 = ReadInt("Enter z point 2: ");

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double length = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Cut length  {length}");