/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int InPutInt(string msg)
{
    Console.WriteLine(msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InPutInt("Введите число");
Console.WriteLine($"Массив длиной {a} ");
int[] array = new int[a];
for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(a + 1);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
