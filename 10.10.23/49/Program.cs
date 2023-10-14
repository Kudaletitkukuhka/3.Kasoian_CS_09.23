/* Задайте двумерный массив. Найдите элементы, у
которых оба индекса не чётные, и замените эти элементы 
на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */

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

int[,] MultiplyEvenIndex(int[,] matr)
{
          for (int i = 0; i < matr.GetLength(0); i++)
     {
          for (int j = 0; j < matr.GetLength(1); j++)
          {
               if(i%2==1 && j%2==1) matr[i,j]=matr[i,j]*matr[i,j];             
          }      
     }
     return matr;
}


System.Console.Write("Введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
matrix=FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
matrix=MultiplyEvenIndex(matrix);
PrintMatrix(matrix);
