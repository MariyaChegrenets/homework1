Console.Write("введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = "); 
    Console.WriteLine(b);
}
else{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}