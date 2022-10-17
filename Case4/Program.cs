/* Написать программу которая заполняет массив рандомными числами. Количество рандомных чисел пользователь задает из консоли. Вывести заполненый массив в консоль.

Пример: Вввели 3 => 7, 4, 5 */
Console.Clear();
Console.Write("Введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] A = new int[N];
int index = 0;
while(index < N)
{
    A[index] = new Random().Next(1, 10001);
    index++;
}
foreach (var item in A) 
{
    Console.WriteLine(item);
}