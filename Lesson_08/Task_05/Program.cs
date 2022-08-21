/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */


System.Console.Write("Введите размерность трехмерного массива через пробел: ");
string[] input = Console.ReadLine().Split();
int[,,] array3D = FillArray(input);
PrintArray(array3D);


int[,,] FillArray(string[] input)
{
    int[,,] array = new int[int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2])];
    int n = 10;
    for (int x = 0; x < int.Parse(input[0]); x++)
    {
        for (int y = 0; y < int.Parse(input[1]); y++)
        {
            for (int z = 0; z < int.Parse(input[2]); z++)
            {
                array[x, y, z] = n;
                n++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        System.Console.WriteLine($"Координата Z = {z} : ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j, z]} : [{i},{j},{z}]" + "\t");
            }
            System.Console.WriteLine();
        }
    }
}