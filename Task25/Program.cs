// 25.Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter natural number B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B <= 0)
{
    Console.WriteLine(" B - Not natural number");
    return;
}

int result = 1;
for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine($"A to degree B = {result}");