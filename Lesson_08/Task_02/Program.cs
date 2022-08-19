/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
Console.WriteLine("Введите кол-во строк и столбцов первой матрицы через пробел: ");
string[] input1 = Console.ReadLine().Split();
int rowCount1 = int.Parse(input1[0]);
int colCount1 = int.Parse(input1[1]);

int[,] firstMatrix = GetArray(rowCount1, colCount1);
Console.WriteLine("Матрица 1: ");
PrintArray(firstMatrix);

Console.WriteLine("Введите кол-во строк и столбцов второй матрицы через пробел: ");
string[] input2 = Console.ReadLine().Split();
int rowCount2 = int.Parse(input2[0]);
int colCount2 = int.Parse(input2[1]);

int[,] secondMatrix = GetArray(rowCount2, colCount2);
Console.WriteLine("Матрица 2: ");
PrintArray(secondMatrix);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    Console.WriteLine("Матрица, получившаяся в рез-те умножения: ");
    int[,] resMatrix = Multiplication(firstMatrix, secondMatrix);
    PrintArray(resMatrix);
}

else
{
    Console.WriteLine("Матрицы нельзя перемножить: ");
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

int[,] Multiplication(int[,] a, int[,] b)
{
    {
        int[,] res = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    res[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return res;
    }
}