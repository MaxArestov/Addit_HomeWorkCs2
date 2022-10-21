/* Написать программу которая сравнивает два массива. На вход пользователь заполняет два массива.
 Если каждый элемент массива равен каждому элементу второго массива вывести true, если хотя бы один не равен то вывести false. */
Console.Clear();
int n = 5;
int[] a = new int[n];
int[] b = new int[n];
Console.WriteLine("Введите числа, относящиеся к массиву a, разделяя их клавишей Enter: ");
FillArray(a);
Console.WriteLine("Введите числа, относящиеся к массиву b, разделяя их клавишей Enter: ");
FillArray(b);
PrintArray(a);
PrintArray(b);
Difference(a, b);





void PrintArray(int[] mass)
{
    int line = mass.Length;
    int count = 0;
    Console.WriteLine("Элементы массива: ");
    while (count < line)
    {
        Console.WriteLine(mass[count]);
        count++;
    }
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void Difference(int[] x, int[] y)
{
    Console.WriteLine(x.SequenceEqual(y));
}