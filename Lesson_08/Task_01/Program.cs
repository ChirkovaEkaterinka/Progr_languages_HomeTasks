/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
Console.WriteLine("Введите кол-во строк и столбцов двумерного массива через пробел: ");
string[] input = Console.ReadLine().Split();
int rowCount = int.Parse(input[0]);
int colCount = int.Parse(input[1]);

int[,] matrix = GetArray(rowCount, colCount);
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);

Console.WriteLine("Сортирока по строкам: ");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)

        row[j] = matrix[i, j];
    BubbleSort(row);
    Insert(i, row, matrix);

}
PrintArray(matrix);


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

void BubbleSort(int[] inpArray)
{
    for (int i = 0; i < inpArray.Length; i++)
    {
        for (int j = 0; j < inpArray.Length - i - 1; j++)
        {
            if (inpArray[j] < inpArray[j + 1])
            {
                int temp = inpArray[j];
                inpArray[j] = inpArray[j + 1];
                inpArray[j + 1] = temp;
            }
        }
    }
}

void Insert(int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        dest[dim, k] = source[k];

    }
}



