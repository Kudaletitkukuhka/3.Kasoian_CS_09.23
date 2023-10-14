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
       Console.WriteLine();
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
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      int size;
      if (rowPosition < matrix.GetLength(0) && columnPosition < matrix.GetLength(1)) 
      { 
        size=2;
      }
      else size=0;
      
      int[] result = new int [size];
      
      if (size>0) 
      {
        result[0]=matrix[rowPosition,columnPosition];
        result[1]=0;
      }
        
      return result;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      if (results.Length==0) Console.Write("There is no such index");
      else Console.Write($"The number in [{X}, {Y}] is {results[0]}");
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}