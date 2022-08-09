/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

Console.WriteLine("Введите угловой коэффициент первой прямой k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент второй прямой k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициент для первой прямой b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент для второй прямой b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Функция первой прямой y1 = {k1}*x + {b1}");
Console.WriteLine($"Функция второй прямой y2 = {k2}*x + {b2}");

double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round((k1 * x + b1), 2);

Console.WriteLine($"Точка пересечния двух прямых ({x} ; {y})");

