/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

// Способ с массивом

/*Console.WriteLine("Какое кол-во чисел хотите ввести? ");
int numbM = int.Parse(Console.ReadLine());
int[] arr = new int[numbM];
for (int i = 0; i < numbM; i++)
{
    Console.Write("M[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < numbM; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Кол-во положительных чисел среди введенных = " + count);*/


//Способ без массива

Console.WriteLine("Какое кол-во чисел хотите ввести? ");
int m = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    if (n > 0)
    {
        count++;
    }
}
Console.WriteLine("Кол-во положительных чисел среди введенных = " + count);