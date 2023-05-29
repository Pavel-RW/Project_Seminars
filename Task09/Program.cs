// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number start 10 to 99 ->{number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
//     Console.WriteLine($"largest digit of a number ->{firstDigit}");
// else
//     Console.WriteLine($"largest digit of a number ->{secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"largest digit of a number ->{maxDigit}");
// // Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

int maxDigit = MaxDigit(number);
Console.WriteLine($"largest digit of a number -> {maxDigit}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}