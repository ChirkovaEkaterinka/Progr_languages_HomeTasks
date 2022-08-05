/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = GetArray(len);

PrintArray (array);

int sumOddPlace = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sumOddPlace += array[i];
    }
}
Console.WriteLine("Сумма элементов, стоящих на нечетных местах = " + sumOddPlace);
