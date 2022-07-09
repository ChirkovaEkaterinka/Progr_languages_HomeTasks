// Напиишите программу, которая на вход принимает число и выдает, является ли оно четным //
Console.WriteLine("Input number = ");
int a = int.Parse(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Введенное число - четное ");
}
else
{
    Console.WriteLine("Введенное число - НЕчетное ");
}