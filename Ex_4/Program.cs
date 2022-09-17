Console.Clear();
Console.WriteLine("Type a number ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Type a number ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Type a number ");
int number3 = int.Parse(Console.ReadLine());

if ((number1 > number2) & (number1 > number3))
{
Console.WriteLine($"{number1} is max");
}
else if ((number1 > number2) & (number1 < number3))
{
Console.WriteLine($"{number3} is max");
}
else if ((number1 < number2) & (number2 > number3))
{
Console.WriteLine($"{number2} is max");
}
else if ((number1 < number2) & (number2 < number3))
{
Console.WriteLine($"{number3} is max");
}