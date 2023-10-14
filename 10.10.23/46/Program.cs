/* Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4
1 4 8 19
5 -2 33 -2
77 3 8 1 */


void PrintMatrix (int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               System.Console.Write($"{matr[i,j]}\t");               
          }
          System.Console.WriteLine();          
     }
}

int[,] FillMatrix(int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               matr[i,j] = new Random().Next(1,10);               
          }      
     }
     return matr;
}

System.Console.Write("Введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
matrix=FillMatrix(matrix);
PrintMatrix(matrix);
