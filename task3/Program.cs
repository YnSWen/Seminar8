// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] FirstMatrix = GetMatrix(3,3);
int [,] SecondMatrix = GetMatrix(3,3);
int [,] ResultMatrix = MultiplicationTwoMatrix(FirstMatrix,SecondMatrix);

Console.WriteLine("Первая матрица:");
PrintMatrix(FirstMatrix);

Console.WriteLine("Вторая матрица:");
PrintMatrix(SecondMatrix);

Console.WriteLine("Произведение двух матриц:");
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
/// Метод находит произведение двух матриц
/// </summary>
/// <param name="FirstMatrix">Первая матрица</param>
/// <param name="SecondMatrix">Вторая матрица</param>
/// <returns>Результирущая матрица</returns>
int [,] MultiplicationTwoMatrix (int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] ResultMatrix = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            ResultMatrix[i,j] = FirstMatrix[i,j] * SecondMatrix[i,j];
        }
    }
    return ResultMatrix;
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

