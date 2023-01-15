/*
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("this program  returns the square of a number!");
Console.WriteLine("insert a number:");
string numberstr = Console.ReadLine();
int numberint = Convert.ToInt32(numberstr);
int result = numberint * numberint;
Console.WriteLine($"the square of {numberstr} = {result}");
Console.WriteLine("the square of " + numberstr + " = " + result);
Console.WriteLine("the square of {0} = {1}", numberstr, result);