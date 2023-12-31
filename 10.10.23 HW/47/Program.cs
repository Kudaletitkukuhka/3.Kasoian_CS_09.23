﻿/*  Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] CreateMatrix(int m, int n, int minV, int maxV)
{
     double[,] matr = new double[m,n];
     for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               matr[i,j] = new Random().Next(minV,maxV) + Math.Round(new Random().NextDouble(), 1);           
          }      
     }
     return matr;
}

void PrintMatrix (double[,] matr)
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

int m=3;
int n=4;
int minLimitRandom = -10;
int maxLimitRandom = 10;

double[,] matrix = CreateMatrix(m,n,minLimitRandom,maxLimitRandom);
PrintMatrix(matrix);