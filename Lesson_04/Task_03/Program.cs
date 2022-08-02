/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

/*int[] FillArray(int n)
{
    int[] Array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rnd.Next(0, 100);
    }
    return Array;
}

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int[] Arr = FillArray(size);
for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i]+ " ");
}*/

int[] array = new int[8];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100);
    Console.Write(array[i] + " ");
}
