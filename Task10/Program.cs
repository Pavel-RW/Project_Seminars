// 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int middle = (number % 100 - number % 10) / 10;
    Console.WriteLine($"middle figure number {middle}");
}
else
{
    Console.WriteLine("Invalid number");
}