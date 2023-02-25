/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int InPutInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Rows = InPutInt("Введите количество строк: ");
int Columns = InPutInt("Введите количество столбцов: ");
int MaxValue = 10;
int MinValue = 1;
int[,] array = ArrayGenerator(Rows, Columns, MaxValue, MinValue);

Console.WriteLine("Среднее арифметическое столбцов:");

double arithmeticalMean = 0;

for (int j = 0; j < Columns; j++)
{
    for (int i = 0; i < Rows; i++)
    {
        arithmeticalMean += array[i, j];
    }
    arithmeticalMean = Math.Round(arithmeticalMean / Rows, 3);
    Console.Write(arithmeticalMean + "\t|");
    arithmeticalMean = 0;
}
Console.WriteLine();
int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int maxValue, int minValue)
{
    int[,] array = new int[lenghtRows, lenghtColum];
    for (int i = 0; i < lenghtRows; i++)
    {
        for (int j = 0; j < lenghtColum; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
            Console.Write(array[i, j] + "\t|");
        }
        Console.WriteLine("строка " + (i + 1));
    }
    return array;
}