﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите положительное целое число больше 0");
string numberStr = Console.ReadLine(); 
int number = Convert.ToInt32(numberStr); 

if (number<1)
{
    Console.Write("число не соответствует условиям задачи"); 
}
else
{
for (int i = 1; i <= number; i++)
{
 if (i%2==0)
 Console.Write(i + ", ");
}
}