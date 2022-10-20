/* 3) Написать программу которая сравнивает две строки. Пользователь вводит две строки.
 Если строки равны то выводится сообщение true если нет то false.*/
 Console.Clear();
 Console.WriteLine("Введите текст, разделяя клавишей Enter.");
 string a = Console.ReadLine();
 string b = Console.ReadLine();
Dif(a, b);








void Dif(string x, string y)
{
    bool check = x == y;
    if (check)
    {
        Console.WriteLine("true"); 
    }
    else Console.WriteLine("false");
}