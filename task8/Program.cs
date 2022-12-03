Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= N)
{
    if(a % 2 == 0)
    {
        Console.WriteLine(a);
        a += 1;
    }
    else
    {
        a += 1;
    }
}
    
    
