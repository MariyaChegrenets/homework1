Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.Write("max = ");
        Console.WriteLine(a);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(c);
    }
}
else if (b > c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(c);
}

