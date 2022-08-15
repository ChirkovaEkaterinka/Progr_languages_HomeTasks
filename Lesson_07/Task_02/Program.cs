/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> такого числа в массиве нет */

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

Console.WriteLine("Введите кол-во строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);

int[,] numbers = GetArray(row, col);
PrintArray(numbers);

Console.WriteLine("Введите позицию искомого элемента в двумерном массиве сначала строку, затем столбец через пробел: ");
string[] incoordinates = Console.ReadLine().Split();
int rownum = int.Parse(incoordinates[0]);
int colnum = int.Parse(incoordinates[1]);


if (rownum > row || colnum > col)
{
    Console.WriteLine("Такого элемента нет в массиве");
}
else
{
    Console.WriteLine($"Число в массиве с номером строки [{rownum}] и номером столбца [{colnum}] равно: " + numbers[rownum, colnum]);
}
