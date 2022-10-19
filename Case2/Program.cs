/* 2) Написать программу которая считывает из консоли 2 числа A и B и определяет делится ли число А на B без остатка.
 Результатом выполнения программы должно быть вывода сообщения пользователю true или false.
true - если делится.
false - если не делится.*/
Console.Clear();
Console.WriteLine("Введите два числа, разделяя их клавишей Enter.");
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
bool check = CheckDev(A, B);
if (check == true) Console.WriteLine("true");
else Console.WriteLine("false");



bool CheckDev(int first, int second)
{
    return (first % second == 0 || second % first == 0);
}
