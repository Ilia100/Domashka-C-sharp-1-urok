/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
if (a>999 || a<100)
{
Console.WriteLine ("число не трехзначное");
}
else 
{int b = a % 10;
Console.WriteLine ("последнее число " + b);
}