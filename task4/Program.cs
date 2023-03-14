// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,]Array3D = Get3DArray(2,2,2);
Print3DArray(Array3D); 

/// <summary>
/// Метод заполняет трехмерный массив случайными двухзначными числами
/// </summary>
/// <param name="rows">строки</param>
/// <param name="collums">столбцы</param>
/// <param name="z"></param>
/// <returns>Заполненный трехмерный массив</returns>
int[,,] Get3DArray(int rows, int collums, int z)
{
    int[,,] Array3D = new int[rows, collums, z];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            for (int m = 0; m < z; m++)
            {
             Array3D[i, j, m] = new Random().Next(10,100);
            }
        }
    }
    return Array3D;
}

/// <summary>
/// Метод печатает трехмерный массив с добавленными индексами
/// </summary>
/// <param name="Array3D">Трехмерный массив</param>
void Print3DArray (int[,,] Array3D)
{
  for (int i = 0; i < Array3D.GetLength(0); i++)
  {
    for (int j = 0; j < Array3D.GetLength(1); j++)
    {
      for (int z = 0; z < Array3D.GetLength(2); z++)
      {
        Console.Write( $"{Array3D[i,j,z]} ({i},{j},{z}); ");
      }
      Console.WriteLine();
    }
  }
}