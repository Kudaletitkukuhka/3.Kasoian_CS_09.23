using System;
/* Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет 

*/

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

int[,] FillIncreasingMatrix(int[,] matrix, int k)
{
     for (int i=0; i < matrix.GetLength(0); i++)
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
               if(i==0 && j==0)  matrix[i,j] = 1;
               else matrix[i,j] = matrix[0,0]+k*i*matrix.GetLength(1)+k*j;
          }
     return matrix;
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
}

void CheckElement(int[,] matr, int m, int n)
{
     if (m < matr.GetLength(0) && n < matr.GetLength(1)) System.Console.WriteLine(matr[m,n]);
     else System.Console.WriteLine("Вы вышли за пределы массива. Попробуйте еще раз");
}

int k = 3;
System.Console.Write("Введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] matrix = new int[m,n];
matrix=FillIncreasingMatrix(matrix, k);
PrintMatrix(matrix);
System.Console.WriteLine();

System.Console.Write("Введите индекс строки искомого числа: ");
int strok=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбца искомого числа: ");
int stolb=Convert.ToInt32(Console.ReadLine());

CheckElement(matrix,strok,stolb);