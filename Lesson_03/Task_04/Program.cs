/* Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
На втором шаге пользователь вводит параметры, необходимые для рассчета.*/

Console.WriteLine("Эта программа находит площади фигур: \n 1. Круг \n 2. Прямоугольник \n 3. Треугольник");
Console.WriteLine("Для выбора фигуры введите ее номер: ");
int figure = int.Parse(Console.ReadLine());

if (figure == 1)
{
    Console.WriteLine("Введите радиус круга: ");
    int R = int.Parse(Console.ReadLine());
    double S1 = Math.PI * R * R;
    Console.WriteLine("Площадь круга = " + Math.Round(S1, 2));
}
if (figure == 2)
{
    Console.WriteLine("Введите сторону a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону b: ");
    int b = int.Parse(Console.ReadLine());
    int S2 = a * b;
    Console.WriteLine("Площадь прямоугольника = " + S2);
}
if (figure == 3)
{
    Console.WriteLine("Введите сторону a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите вычоту h: ");
    int h = int.Parse(Console.ReadLine());
    int S3 = a * h / 2;
    Console.WriteLine("Площадь треугольника = " + S3);
}
if (figure > 3)
{
    Console.WriteLine("Нет такой фигуры в списке");
}