// 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


bool NatNum(int num)
{
    return num >= 1;
}

int SumNatNum(int m, int n)
{
    if (m == n) return m;
    if (m > n) return SumNatNum(n, m);
    return m + SumNatNum(m + 1, n);
}

Console.Write("Enter First number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (NatNum(m) && NatNum(n))
{
    int sum = SumNatNum(m, n);
    Console.WriteLine($"Sum natural numbers  {m} to {n} = {sum}.");
}
else
{
    Console.WriteLine($"Numbers must be natural. Entered: m = {m}, n = {n}");
}