﻿/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
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
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);

int[,] numbers = GetArray(row, col);
PrintArray(numbers);

double aversum = 0;
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = sum + numbers[i, j];
    }
    aversum = Math.Round(sum / numbers.GetLength(0), 1);
    Console.WriteLine($"Среднее значение по столбцу {j}: "+ aversum);
}


