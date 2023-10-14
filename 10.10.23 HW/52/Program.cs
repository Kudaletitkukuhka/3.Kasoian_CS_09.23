/* Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void PrintDoubleMatrix (int[,] matr)
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

double[] AverageInColumn(int[,] matrix)
{
     double[] average = new double[matrix.GetLength(1)];
     double arAverage;
     int x=0;
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
          double sum = 0;
          for (int i = 0; i < matrix.GetLength(0); i++)
          {
               sum = sum + Convert.ToDouble(matrix[i,j]);
          }
          arAverage = sum / Convert.ToDouble(matrix.GetLength(0));
          average[x]=arAverage;
          x=x+1;
     }
     return average;
}

void PrintMatrix(double[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
          System.Console.Write($"{list[i].ToString("F2")}\t");
     }
}


System.Console.Write("Введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] matrix = new int[m,n];
matrix=FillMatrix(matrix);
PrintDoubleMatrix(matrix);
System.Console.WriteLine();
double[] result = AverageInColumn(matrix);
PrintMatrix(result);