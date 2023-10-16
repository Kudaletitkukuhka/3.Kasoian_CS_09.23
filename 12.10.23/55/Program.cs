using System;
/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя */


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

int[,] SwitchRowsAndColumns (int[,] matrix)
{
     int[,] switchMass = new int[matrix.GetLength(1),matrix.GetLength(0)];
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
               switchMass[i,j]=matrix[j,i];
          }
     }
     return switchMass;
}

void SwitchRowsAndColumns2 (int[,] matrix)
{
     int temp = 0;
     int num = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
          for (int j = num; j < matrix.GetLength(1); j++)
          {
               temp = matrix[i,j];
               matrix[i,j] = matrix[j,i];
               matrix[j,i] = temp;
          }
          num++;
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

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

if(rows == columns)
{
     int[,] matrix = FillMatrix(rows,columns);
     PrintMatrix(matrix);
     SwitchRowsAndColumns2(matrix);
     PrintMatrix(matrix);
}
else System.Console.WriteLine("Перевернуть массив нельзя");

