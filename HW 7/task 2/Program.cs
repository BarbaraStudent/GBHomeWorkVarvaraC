/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 1 -> 1 */

int InPutInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Rows = InPutInt("Введите количество строк: ");
int Columns = InPutInt("Введите количество столбцов: ");
int MaxValue = 10;
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

Console.Write("введите искомое число --> ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool numberFound = false;

for (int i = 0; i < Rows; i++)
{
    for (int j = 0; j < Columns; j++)
    {
        if (array[i, j] == findNumber)
        {
            Console.WriteLine($"Число найено: Строка {i + 1} ; Колонка {j + 1}");
            numberFound = true;
        }
    }
}

if (numberFound != true) Console.WriteLine("Число НЕ найдено");