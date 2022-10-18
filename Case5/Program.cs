/* Написать программу которая сравнивает два массива. На вход пользователь заполняет два массива.
 Если каждый элемент массива равен каждому элементу второго массива вывести true, если хотя бы один не равен то вывести false. */
Console.Clear();
int N = 5;
int[] A = new int[N];
int[] B = new int[N];
Console.WriteLine("Введите числа, относящиеся к массиву A, разделяя их клавишей Enter: ");
FillArray(A);
Console.WriteLine("Введите числа, относящиеся к массиву B, разделяя их клавишей Enter: ");
FillArray(B);
PrintArray(A);
PrintArray(B);
Console.WriteLine(A.SequenceEqual(B));





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