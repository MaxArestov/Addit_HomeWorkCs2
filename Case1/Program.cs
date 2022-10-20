/* 1) Написать программу которая находит сумму 4 чисел. Числа вводятся пользователем из консоли.
 Если пользователь ввел не число необходимо вывести пользователю сообщение "Введены некорректные данные".*/
Console.Clear();
int a = 0;
bool check = true;
while (check)
{
    Console.Write("Plesase enter number: ");
    if (Int32.TryParse(Console.ReadLine(), out a))
    {
        check = false;
    }
    else Console.WriteLine("Введены некорректные данные");
}
int b = 0;
check = true;
while (check)
{
    Console.Write("Plesase enter number: ");
    if (Int32.TryParse(Console.ReadLine(), out b))
    {
        check = false;
    }
    else Console.WriteLine("Введены некорректные данные");
}
int c = 0;
check = true;
while (check)
{
    Console.Write("Plesase enter number: ");
    if (Int32.TryParse(Console.ReadLine(), out c))
    {
        check = false;
    }
    else Console.WriteLine("Введены некорректные данные");
}
int d = 0;
check = true;
while (check)
{
    Console.Write("Plesase enter number: ");
    if (Int32.TryParse(Console.ReadLine(), out d))
    {
        check = false;
    }
    else Console.WriteLine("Введены некорректные данные");
}
int Sum = a + b + c + d;
Console.WriteLine(Sum);