// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] matrix = GetMatrix(4, 6); // Зададим матрице размер, например: 5х8

Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);

Console.WriteLine();

Console.WriteLine("Результирующий массив:");
int[,] ResultMatrix = SortArray(matrix);
PrintMatrix(ResultMatrix);


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
/// Этот метод упорядочивает значения элементов в строке матрицы,
/// от большего элемента к меньшему
/// </summary>
/// <param name="matrix">Двумерный массив</param>
/// <returns>Отсортированный массив</returns>
int[,] SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = 0;
            while (k < matrix.GetLength(1) - 1)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i,k] = temp;
                }
                k++;
            }
        }
    }
    return matrix;
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




