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
 
