/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int InPutInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Rows = InPutInt("Введите количество строк: ");
int Columns = InPutInt("Введите количество столбцов: ");
int MaxValue = 100;
int MinValue = 1;
double[,] array = new double[Rows, Columns];

for (int i = 0; i < Rows; i++)
{
    for (int j = 0; j < Columns; j++)
    {
        array[i, j] = new Random().NextDouble();
        array[i, j] = array[i, j] * (MaxValue - MinValue) + MinValue;
        array[i, j] = Math.Round(array[i, j], 2);
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine("  " + (i + 1));
}