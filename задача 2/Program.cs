/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("какое число больше");
Console.WriteLine("напишите 1 число:");
string num1 = Console.ReadLine();
Console.WriteLine("напишите 2 число:");
string num2 = Console.ReadLine();

int num1int = Convert.ToInt32(num1);
int num2int = Convert.ToInt32(num2);
int result = 0;
if (num1int == num2int)
{
 result = num1int;
 Console.WriteLine("числа одинаковые");
}
else
{
   if (num1int > num2int)
   {
   result = num1int;
   Console.WriteLine("большее число " + result);
   }
   else
   {
   result = num2int;
   Console.WriteLine("большее число " + result);
   }
}
 
