/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число : ");
int digit = int.Parse(Console.ReadLine());
string Polindrom(int x)
{
    if (x / 10000 == x % 10 & (x / 1000) % 10 == (x % 100) / 10) 
    {
        return "является полиндромом ";
    }
          return "НЕ является полиндромом";
}
if (digit >= 10000 && digit <= 99999)
{
   Console.WriteLine("Число " + Polindrom(digit));
}
else
{
    Console.WriteLine("Ошибка ввода");
}
