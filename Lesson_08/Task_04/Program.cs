// Задача 62. Заполните спирально массив 4 на 4.
Console.WriteLine("Введите размерность квадратной матрицы (введенное число обозначает кол-во строк и столцбов): ");
int size = int.Parse(Console.ReadLine());

int[,] myarray = new int[size, size];
int n = 1;
for (int k = 0; k <= myarray.GetLength(0) / 2; k++)
{
    for (int j = k; j < myarray.GetLength(1) - k; j++)
    {
        if (myarray[k, j] == 0)
        {
            myarray[k, j] = n;
        }
        n++;
    }

    for (int i = k + 1; i <= myarray.GetLength(0) - k - 1; i++)
    {
        if (myarray[i, myarray.GetLength(1) - 1 - k] == 0)
        {
            myarray[i, myarray.GetLength(1) - 1 - k] = n;
        }
        n++;
    }

    for (int j = myarray.GetLength(1) - 2 - k; j >= k; j--)
    {
        if (myarray[myarray.GetLength(0) - 1 - k, j] == 0)
        {
            myarray[myarray.GetLength(0) - 1 - k, j] = n;
        }
        n++;
    }

    for (int i = myarray.GetLength(0) - 2 - k; i >= k + 1; i--)
    {
        if (myarray[i, k] == 0)
        {
            myarray[i, k] = n;
        }
        n++;
    }
}

PrintArray(myarray);

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