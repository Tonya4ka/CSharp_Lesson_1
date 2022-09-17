Console.Clear();
Console.WriteLine("Type a number ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Type a number ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
Console.WriteLine($"{number2} is min and {number1} is max");
}
else
{
Console.WriteLine($"{number1} is min and {number2} is max");
}