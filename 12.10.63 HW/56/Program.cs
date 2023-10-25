using System.ComponentModel.DataAnnotations;
/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов. */

int[,] FillMatrix(int row, int col, int minValue, int maxValue)
{
     int[,] matr = new int[row,col];
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               matr[i,j] = new Random().Next(minValue,maxValue);             
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

int FindLeastRowSum (int[,] array)
{
     int min = 0;
     int x=0;
     for (int i = 0; i < array.GetLength(0); i++)
     {
          int sum = 0;
          for (int j = 0; j < array.GetLength(1); j++)
          {
               sum = sum + array[i,j];
          }
          if (i == 0) 
          {
               min = sum;
          }
          if (sum < min)
          {
               min = sum;
               x = i;
          }
     }
     return x;
    
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Минимальное значение массива: ");
int minV = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Максимальное значение массива: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[,] array = FillMatrix(rows,columns,minV,maxV);
PrintMatrix(array);
System.Console.WriteLine($"Индекс строки массива с наименьшей суммой элементов: {FindLeastRowSum(array)}");