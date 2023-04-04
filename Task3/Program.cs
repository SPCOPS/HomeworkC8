    int[,] InputArray(int m, int n, int min, int max)
    {
      int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        matrix[i, j] = new Random().Next(min, max + 1);
      }
      
    }
      return matrix;
    }
    void PrintArray(int[,] Matrix)
    {
     for (int i = 0; i < Matrix.GetLength(0); i++)
     {
       for (int j = 0; j < Matrix.GetLength(1); j++)
       {
         Console.Write($"{Matrix[i, j]} ");
       }
       Console.WriteLine();
     }
    }
    int [,] Multi(int[,] matrixA, int[,] matrixB)
    {
      int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
      for (int i = 0; i < matrixA.GetLength(0); i++)
      {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
          for (int k = 0; k < matrixA.GetLength(1); k++)
          {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
          }
        }
      }
      return matrixC;
    }
Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int rowA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 массива: ");
int columnA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 массива: ");
int rowB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 массива: ");
int columnB = int.Parse(Console.ReadLine()!);
if (columnA != rowB)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}
int[,] A = InputArray(rowA, columnA, 0, 10);
int[,] B = InputArray(rowB, columnB, 0, 10);
Console.WriteLine();
Console.WriteLine("Матрица 1:");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintArray(B);
Console.WriteLine();
Console.WriteLine("Результат умножения матриц:");
PrintArray(Multi(A,B));