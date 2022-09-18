Console.WriteLine("Type a number ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    for (int i=1; i <= number; i++)
    {
        if (i%2==0)
        {
            Console.Write($"{i} ");
        }
    }
}
else
{
    Console.WriteLine("Not accepting negative numbers");
}
