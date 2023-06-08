// 27.Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.


int SumDigitsInNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigitsInNumber(number);
Console.WriteLine($"Sum digits number {number} = {result}");