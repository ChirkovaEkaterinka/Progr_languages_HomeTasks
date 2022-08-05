/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] GetArray(int n)
{
    double[] arr = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.NextDouble() * 100;
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
double[] array = GetArray(len);

PrintArray(array);

double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
}
Console.WriteLine("макс элемент массива = " + max);

double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
}
Console.WriteLine("мин элемент массива = " + min);

double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + diff);