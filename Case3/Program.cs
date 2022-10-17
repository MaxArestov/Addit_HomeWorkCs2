/* 3) Написать программу которая сравнивает две строки. Пользователь вводит две строки.
 Если строки равны то выводится сообщение true если нет то false.*/
 Console.Clear();
 Console.WriteLine("Введите дважды текст, разделяя клавишей Enter.");
 string A = Console.ReadLine();
 string B = Console.ReadLine();
 if(A == B) Console.WriteLine("true");
 else Console.WriteLine("false");