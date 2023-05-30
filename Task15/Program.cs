// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void CheckDayWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Yes - weekend");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Invalid input - not day week");
    }
    else Console.WriteLine("No - No weekend");
}

Console.WriteLine("Enter number day week");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckDayWeek(dayNumber);