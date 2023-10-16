using System;
/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

int[,] FillMatrix(int row, int col, int minimalV, int maximumV)
{
     int[,] matr = new int[row,col];
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               matr[i,j] = new Random().Next(minimalV,maximumV);             
          }      
     }
     return matr;
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

void CountNumbers (int[,] array, int minimalV, int maximumV)
{
     int[] count = new int [maximumV-minimalV];
     int add = 0;
     while (minimalV+add < maximumV)
     {    
          for (int i = 0; i < array.GetLength(0); i++)
          {
               for (int j = 0; j < array.GetLength(1); j++)
               {
                    if (array[i,j] == (minimalV+add)) count[add]++;
               }
          }
          add++;
     }
     for (int i = 0; i < count.Length; i++)
     {
          if(count[i]!=0) System.Console.WriteLine($"{minimalV + i} встречается {count[i]} раз(а)");
     }
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Минимальное значение массива: ");
int minV = Convert.ToInt32(Console.ReadLine());
System.Console.Write("МАксимальное значение массива: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[,] array = FillMatrix(rows,columns,minV,maxV);
PrintMatrix(array);
CountNumbers(array, minV, maxV);
