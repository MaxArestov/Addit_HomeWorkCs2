/* 1) Написать программу которая находит сумму 4 чисел. Числа вводятся пользователем из консоли.
 Если пользователь ввел не число необходимо вывести пользователю сообщение "Введены некорректные данные".*/
Console.Clear();
Console.WriteLine("Введите поочередно 4 числа, разделяя их пробелом.");
string a = Console.ReadLine();
bool check = StringDigit(a);
if (check == false)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
string b = Console.ReadLine();
check = StringDigit(b);
if (check == false)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
string c = Console.ReadLine();
check = StringDigit(c);
if (check == false)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
string d = Console.ReadLine();
check = StringDigit(d);
if (check == false)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
int Sum = Convert.ToInt32(a) + Convert.ToInt32(b) + Convert.ToInt32(c) + Convert.ToInt32(d);
Console.WriteLine(Sum);






bool StringDigit(string number)
{
    foreach (var item in number)
    {
        if (!char.IsDigit(item))
        {
            return false;
        }
    }
    return true;
}