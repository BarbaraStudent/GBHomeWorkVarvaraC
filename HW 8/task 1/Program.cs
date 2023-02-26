/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.*/
int InPutInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Rows = InPutInt("Введите количество строк: ");
int Columns = InPutInt("Введите количество столбцов: ");
int[,] Matrix = new int[Rows, Columns];
FillArrayRandomNumbers(Matrix);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(Matrix);

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < Matrix.GetLength(1) - 1; z++)
        {
            if (Matrix[i, z] < Matrix[i, z + 1]) 
            {
                int temp = 0;
                temp = Matrix[i, z];
                Matrix[i, z] = Matrix[i, z + 1];
                Matrix[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(Matrix);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


