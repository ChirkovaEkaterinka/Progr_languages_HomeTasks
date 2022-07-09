/*
Напишите программу, которая на вход принимает два числа и выдает максимальное из этих чисел
*/
Console.WriteLine("Input first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("max = " + a); 
}
else
{
    Console.WriteLine("max = " + b);
}