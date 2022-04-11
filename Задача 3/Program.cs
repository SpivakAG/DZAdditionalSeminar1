Console.WriteLine("Введите число");
double number = Convert.ToDouble(Console.ReadLine());
double result = number % 2;
if (result == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число не четное");
}