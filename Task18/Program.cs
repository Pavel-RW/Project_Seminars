// адача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Enter quarter number: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string range = Quarter(quarter);
string result = range == null
? "Incorrect quarter number entered"
: $"Range possible coordinates specified quarter: {range}";
Console.WriteLine(result);

string Quarter(int q)
{
if (q == 1) return "x > 0 ; y > 0";
if (q == 2) return "x < 0 ; y > 0";
if (q == 3) return "x < 0 ; y < 0";
if (q == 4) return "x > 0 ; y < 0";
return null;
}