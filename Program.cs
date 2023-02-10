Console.WriteLine("Введите целое число");
int A = int.Parse(Console.ReadLine());
int B = A;
A = - A;
while (A <= B)
{
    Console.Write(A + ", ");
    A ++;
}