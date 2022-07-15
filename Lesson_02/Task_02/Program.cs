// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.//
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
 
if (a > 99)
{
    while (a > 999)
        a = a / 10;
    Console.WriteLine("Третья цифра =  " + a % 10);
}
    else
{
    Console.WriteLine("Нет третьей цифры");
}