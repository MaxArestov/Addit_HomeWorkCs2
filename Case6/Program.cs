// 6) Написать программу которая сравнивает два массива и выводит индексы элементов в которых числа не равны.
Console.Clear();
int N = 4;
int[] A = new int[N];
int[] B = new int[N];
FillArray(A);
FillArray(B);
PrintArray(A);
PrintArray(B);
Console.WriteLine($"Различаются цифры - {PrintDifference(A, B)}");

// int c = 0;
// Console.WriteLine("В массиве не совпадают цифры на позициях: ");
// while (c < N)
// {
//     if (A[c] != B[c])
//     {
//         Console.WriteLine(c);
//     }
//     c++;
// }





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
        array[index] = new Random().Next(1, 10);
        index++;
    }
}
string PrintDifference(int[] x, int[] y)
{
    int z = 0;
    int length = x.Length;
    string i = String.Empty;
    int[] u = new int[length];
    while (z < length)
    {
        if (x[z] != y[z]) 
        {
            i = (i + z);
        }
        z++;
    }
    return i;
}