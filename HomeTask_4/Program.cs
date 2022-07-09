// Напиишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N //
Console.Write("Input number N = ");
uint a = uint.Parse(Console.ReadLine());
uint i = 1;
while(i <= a)
{
    if(i % 2 == 0)
    {
    Console.WriteLine(i + " ");
}
i++;
}
