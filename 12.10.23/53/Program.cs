/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива
 */

int[,] FillMatrix(int row, int col)
{
     int[,] matr = new int[row,col];
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               matr[i,j] = new Random().Next(1,10);             
          }      
     }
     return matr;
}

void SwitchLastAndFirstRows (int[,] matrix)
{
     int[] cashMass = new int[matrix.GetLength(1)];
     for (int i = 0; i < matrix.GetLength(1); i++)
     {
          cashMass[i]=matrix[0,i];
          matrix[0,i]=matrix[matrix.GetLength(0)-1,i];
          matrix[matrix.GetLength(0)-1,i]=cashMass[i];
     }
}

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
     System.Console.WriteLine();
}


int rows=3;
int columns=4;
int[,] matrix = FillMatrix(rows,columns);
PrintMatrix(matrix);
SwitchLastAndFirstRows(matrix);
PrintMatrix(matrix);

