/* Написать программу которая заполняет массив рандомными числами. Количество рандомных чисел пользователь задает из консоли. Вывести заполненый массив в консоль.

Пример: Вввели 3 => 7, 4, 5 */
Console.Clear();
Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
FillArray(a);
PrintArray(a);












void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    Random random = new Random();
    while(index < length)
    {
        array[index] = random.Next(1, 1001);
        index++;
    }
}

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