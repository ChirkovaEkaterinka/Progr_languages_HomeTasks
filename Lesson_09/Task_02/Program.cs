/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число M = ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Сумма натуральных чисел от M до N : " + SumNaturalNum(m, n));

int SumNaturalNum(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return start + SumNaturalNum(++start, end);
}