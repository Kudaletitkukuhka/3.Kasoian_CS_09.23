using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
               System.Console.Write($"{matrix[i,j]}\t");               
          }
          System.Console.WriteLine();          
      }


    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
               int[,] matrix = new int[n,m];
          for (int i=0; i < matrix.GetLength(0); i++)
          {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               if(i==0 && j==0)  matrix[i,j] = 1;
               else matrix[i,j] = matrix[0,0]+k*i*matrix.GetLength(1)+k*j;
            }
          }
          return matrix;
    }
  
    static void PrintListAvr (double [] list)
    {
           Console.WriteLine("The averages in columns are:");     
           for (int i = 0; i < list.Length; i++)
           {
              System.Console.Write($"{list[i].ToString("F2")}\t");
           }
    }

    static double [] FindAverageInColumns (int [,] matrix)
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
          average[x] = arAverage;
          x=x+1;
     }
     return average;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}