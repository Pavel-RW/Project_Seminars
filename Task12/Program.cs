// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remain(int number1, int number2)
{
    int res = number1 % number2;
    return res;
}

Console.Write("Enter first number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Remain(num1, num2);
// if (result == 0)
// {
//     Console.WriteLine($" {num1} multiple {num2}");
// }
// else
// {
//     Console.WriteLine($" {num1} no multiple {num2}, Remainder {result}");
// }

string printline = result == 0? "multiple" : $"no multiple, remainder {result}";
Console.WriteLine(printline);