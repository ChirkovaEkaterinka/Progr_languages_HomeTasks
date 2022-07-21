/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N)
{
    int x=count*count*count; 
    Console.Write(x + " ");
    count++;
}


/*int CubesOfNumbers(int N)
{
    int count = 1;
    while (count <= N)
    {
        int x = count * count * count;
        return x;
        //Console.WriteLine(x + " ");
        count++;
    }
   
}
Console.WriteLine(CubesOfNumbers(N));*/