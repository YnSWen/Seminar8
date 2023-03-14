// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


int[,] Matrix = GetMatrix(4,5);
int MinSumLine = FindMinSumLine(Matrix);
PrintMatrix(Matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов:{MinSumLine}");


/// <summary>
/// Этот метод заполняет двумерный массив
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="collums">Количество столбцов</param>
/// <returns>Заполненный двумерный массив целых чисел от 0 до 9</returns>
int[,] GetMatrix(int rows, int collums)
{
    int[,] matrix = new int[rows, collums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

/// <summary>
/// Метод ищет строку с наименьшей суммой элемнтов 
/// </summary>
/// <param name="matrix">Двумерный массив</param>
/// <returns>Номер строки с наименьшей суммой элементов</returns>
int FindMinSumLine(int[,] matrix)
{
    int MinSum = int.MaxValue;
    int MinSumLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = 0;
        int sum = 0;
        while (j < matrix.GetLength(1))
        {
            sum = sum + matrix[i, j];
            j++;
        }
        if (sum < MinSum)
        {
            MinSum = sum;
            MinSumLine = i;
        }
    }
    return MinSumLine;
}


/// <summary>
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="matrix">Двумерный массив</param>
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}