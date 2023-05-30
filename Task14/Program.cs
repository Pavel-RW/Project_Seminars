// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool DevidedByTwoNumbers(int num, int num1, int num2)
{
return num % num1 == 0 && num % num2 == 0;
}

Console.Write("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = DevidedByTwoNumbers(number, 7, 23);
Console.WriteLine(result ? "Yes" : "No");