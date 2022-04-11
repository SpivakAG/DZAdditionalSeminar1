Console.WriteLine("Введите число 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA > numberB)
{
    max = numberA;
}
else 
{
    max = numberB;
}
    Console.Write("Max=");
    Console.Write(max);