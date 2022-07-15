// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным //
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a > 0 & a < 6)
{
    Console.WriteLine("Это будний день ");

}
else
if (a > 6 & a < 8)
{
    Console.WriteLine("Это выходной! ");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}