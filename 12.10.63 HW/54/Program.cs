/* Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива. */

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

void ChangeOrderDecreasing(int[,] array)
{
     for (int k = 0; k < array.GetLength(0); k++)
     {
          int temp = array[k,0];
          for (int i = 0; i < array.GetLength(1) - 1; i++)
     // traverse i+1 to array length
          for (int j = i + 1; j < array.GetLength(1); j++)
 
     // compare array element with 
     // all next element
          if (array[k,i] < array[k,j]) 
          {
               temp = array[k,i];
               array[k,i] = array[k,j];
               array[k,j] = temp;
          }
     }
     
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
ChangeOrderDecreasing(array);
PrintMatrix(array);