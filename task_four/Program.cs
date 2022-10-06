// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine("{0} Большее число", a);
    }
    else
    {
        Console.WriteLine("{0} Большее число", c);
    }
}
else if (b>c)
{
    Console.WriteLine("{0} Большее число", b);
}
else
{
    Console.WriteLine("{0} Большее число", c);
}