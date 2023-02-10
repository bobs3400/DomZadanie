Console.WriteLine("Введите 1 целое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 целое число");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("Наибольшее число  " + numberA);
    Console.WriteLine("Наименьшее число  " + numberB);
}
else
{
   Console.WriteLine("Наибольшее число  " + numberB);
    Console.WriteLine("Наименьшее число  " + numberA); 
}