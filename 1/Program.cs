Console.WriteLine("this program  returns the square of a number!");
Console.WriteLine("insert a number:");
string numberstr = Console.ReadLine();
int numberint = Convert.ToInt32(numberstr);
int result = numberint * numberint;
Console.WriteLine($"the square of {numberstr} = {result}");
Console.WriteLine("the square of " + numberstr + " = " + result);
Console.WriteLine("the square of {0} = {1}", numberstr, result);