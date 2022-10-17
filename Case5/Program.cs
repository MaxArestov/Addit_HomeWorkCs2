/* Написать программу которая сравнивает два массива. На вход пользователь заполняет два массива.
 Если каждый элемент массива равен каждому элементу второго массива вывести true, если хотя бы один не равен то вывести false. */
Console.Clear();
int[] A = new int[5];
int[] B = new int[5];
foreach (var item in A)
{
    Console.Write("Введите число: ");
    Int.Parse(Console.ReadLine());
}
foreach (var item in B)
{
    Console.Write("Введите число: ");
    Int.Parse(Console.ReadLine());
}
if (A[5] == B[5])
{
    Console.Write("True");
}
else Console.Write("False");