/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц. */

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


int[,] MultiplyArrays(int[,] array, int[,] array2)
{
     int[,] multiply = new int[array.GetLength(0),array2.GetLength(1)];
     if (array.GetLength(0) == array2.GetLength(1) && array.GetLength(1) == array2.GetLength(0))
     {
          for (int i = 0; i < array.GetLength(0); i++)
          {

               for (int j = 0; j < array2.GetLength(1); j++)
               {
                    multiply[i,j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                         multiply[i,j] += array[i,k] * array2[k,j];
                    }
               }
          }
          return multiply;
     }
     else return multiply;
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

int[,] array2 = FillMatrix(columns,rows,minV,maxV);
PrintMatrix(array2);

int[,] result = MultiplyArrays(array,array2);
PrintMatrix(result);
