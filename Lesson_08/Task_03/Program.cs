/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Введите кол-во строк и столбцов двумерного массива через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);

int[,] matrix = GetArray(row, col);
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);

LessSumRow(matrix);

void LessSumRow(int[,] array)
{
    int sumrow = 0;
    int[] sumrowArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrow += array[i, j];
        }
        sumrowArray[i] = sumrow;
        Console.WriteLine();
        Console.WriteLine($"сумма " + (i + 1) + " строки равна " + sumrow);
        sumrow = 0;
    }
    Console.WriteLine();
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumrowArray[i] < sumrowArray[min])
            min = i;
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов равен " + (min + 1));
}

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}