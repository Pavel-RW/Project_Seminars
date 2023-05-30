// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Enter number: ");
string? num = Console.ReadLine();

void CheckNum(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"You number {num}   palindrome");
    }
    else Console.WriteLine($"You number {num}   No palindrome");
}
if (num!.Length == 5)
{
    CheckNum(num);
}
else Console.WriteLine($"Enter correct number");