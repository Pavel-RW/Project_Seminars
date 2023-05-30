// 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("Enter coordinates two points plane: ");
// Console.WriteLine("Enter X value first point: ");
// int x1Coord = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Y value first point: ");
// int y1Coord = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter X value second point: ");
// int x2Coord = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter X value second point: ");
// int y2Coord = Convert.ToInt32(Console.ReadLine());

// double dist = Dist(x1Coord, y1Coord, x2Coord, y2Coord);
// double dRound = Math.Round(dist, 2, MidpointRounding.ToZero);

// Console.WriteLine($"Distance between given points = {dRound}");
// double Dist(int x1, int y1, int x2, int y2)
// {
//     int xDiff = x2 - x1;
//     int yDiff = y2 - y1;
//     int sum = xDiff * xDiff + yDiff * yDiff;
//     double result = Math.Sqrt(sum);

//     return result;
// }


//////////////////////////////////////////////////////////////////



////  double DistCoord(int ax, int ay, int bx, int by)
//// {
//// double sumCathetus = (bx-ax)*(bx-ax) + (by-ay)*(by-ay);
//// double d = Math.Sqrt(sumCathetus);
//// return d;
//// }

//// Console.WriteLine("Enter x value first point");
//// int x1 = Convert.ToInt32(Console.ReadLine());
//// Console.WriteLine("Enter y value first point");
//// int y1 = Convert.ToInt32(Console.ReadLine());
//// Console.WriteLine("Enter x value second point");
//// int x2 = Convert.ToInt32(Console.ReadLine());
//// Console.WriteLine("Enter y value second point");
//// int y2 = Convert.ToInt32(Console.ReadLine());

//// double result = DistCoord(x1, y1, x2, y2);
//// double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
//// Console.WriteLine(resultRound);


///////////////////////////////////////////////////////////////


int EnterCoord(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Dist(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

int xOfA = EnterCoord("Enter x for A");
int yOfA = EnterCoord("Enter y for A");
int xOfB = EnterCoord("Enter x for B");
int yOfB = EnterCoord("Enter y for B");

double result = Dist(xOfA, yOfA, xOfB, yOfB);
System.Console.WriteLine("Distance between dots: ");
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));