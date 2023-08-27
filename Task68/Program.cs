// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("Enter the first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (NatNum(m) && NatNum(n))
{
    int result = AckermannFunc(m, n);
    Console.WriteLine($"Ackermann func  {m} and {n} = {result}");
}
else
{
    Console.WriteLine($"Numbers must be non-negative. Entered: m = {m}, n = {n}");
}

bool NatNum(int num) // Метод для проверки на натуральность
{
    return num >= 0;
}

int AckermannFunc(int m, int n) // Метод для вычисления функции Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}
