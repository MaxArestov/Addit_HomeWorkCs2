/* 1) Написать программу которая находит сумму 4 чисел. Числа вводятся пользователем из консоли.
 Если пользователь ввел не число необходимо вывести пользователю сообщение "Введены некорректные данные".*/
Console.Clear();
bool checkOne = int.TryParse(Console.ReadLine(), out int a);
if (!checkOne)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
bool checkTwo = int.TryParse(Console.ReadLine(), out int b);
if (!checkTwo)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
bool checkThree = int.TryParse(Console.ReadLine(), out int c);
if (!checkThree)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
bool checkFour = int.TryParse(Console.ReadLine(), out int d);
if (!checkFour)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
int Sum = a + b + c + d;
Console.WriteLine($"Сумма введенных Вами чисел равна {Sum}");