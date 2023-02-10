Console.WriteLine("Введите 3 целых числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
if (A > B)
{
    if (A > C)
    {
        Console.WriteLine("Максимальное число = " + A);
    }
    else 
    {
        Console.WriteLine("Максимальное число = " + C);
    }
}
else
{
    if (B > C)
    {
        Console.WriteLine("Максимальное число = " + B);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + C);
    }
}