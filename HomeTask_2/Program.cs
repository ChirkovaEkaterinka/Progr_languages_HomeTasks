/* Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
*/
Console.WriteLine("Input first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Input third number: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if(a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("maximum = " );
Console.WriteLine(max);
