/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int InPutInt(string msg)
{
    Console.WriteLine(msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int number = InPutInt("Введите число N: ");
Console.Write("Таблица кубов числа N  ");
for (int N = 1; N <= number; N++)
    
    Console.Write($"{N*N*N} ");


