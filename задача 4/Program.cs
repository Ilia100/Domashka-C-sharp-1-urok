/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("какое число больше");
Console.WriteLine("напишите 1 число:");
string num1 = Console.ReadLine();
Console.WriteLine("напишите 2 число:");
string num2 = Console.ReadLine();
Console.WriteLine("напишите 3 число:");
string num3 = Console.ReadLine();

int num1int = Convert.ToInt32(num1);
int num2int = Convert.ToInt32(num2);
int num3int = Convert.ToInt32(num3);
int result = 0;
if (num1int == num2int & num2int == num3int)
{
 result = num1int;
 Console.WriteLine("числа одинаковые");
}
else
{
   if (num1int > num2int & num1int > num3int)
   {
   result = num1int;
   Console.WriteLine("большее число " + result);
   }
   else
   {
      if (num2int > num1int & num2int > num3int)
      {
         result = num2int;
   Console.WriteLine("большее число " + result);
      }
      else 
      {
      result = num3int;
      Console.WriteLine("большее число " + result);
      }
   }
}
 
