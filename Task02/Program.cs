﻿// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.WriteLine("Enter Number a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Number b");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
Console.WriteLine($" MAX = {numberA} , MIN = {numberB} ");
}
else
{
Console.WriteLine($" MAX = {numberB} , MIN = {numberA} ");
}