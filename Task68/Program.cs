// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (NatNum(m) && NatNum(n))
{
    int result = AckermannFunc(m, n);
    Console.WriteLine($"Ackermann function M = {m}, N = {n} -> A({m},{n}) = {result}");
}
else
{
    Console.WriteLine($"Numbers must be not negative. Entered: M = {m}, N = {n}");
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
