/*  Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
 */

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
               matr[i,j] = i+j;             
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
