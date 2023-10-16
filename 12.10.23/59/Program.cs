/* Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. 

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7

*Создать еще один массив в уменьшеном виде
*/

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

int[] FindLeastNumber(int[,] array)
{
     int min = array[0,0];
     int[] result = new int[] {0,0};
     for (int i = 0; i < array.GetLength(0); i++)
     {
          for (int j = 0; j < array.GetLength(1); j++)
          {
               if(array[i,j] < min) 
               {
                    min = array[i,j];
                    result[0] = i;
                    result[1] = j; 
               }
          }
     }
     return result;
}

void PrintContractedMatrix (int[,] matr, int[] delete)
{
     int a = 0;
     int b = 0;
     for (int i = 0; i < matr.GetLength(0); i=i+1+a)
     {
          for (int j = 0; j < matr.GetLength(1); j=j+1+b)
          {
               if (i != delete[0] && j != delete[1])
               {
                    System.Console.Write($"{matr[i,j]}\t");               
               }
          }
          System.Console.WriteLine();

     }
     
     System.Console.WriteLine();
}

int[,] PrintFinalArray(int[,] array, int[] delete)
{
     int[,] finalArray = new int[array.GetLength(0)-1,array.GetLength(1)-1];
     
     for (int i = 0; i < delete[0]; i++)
     {
          for (int j = 0; j < delete[1]; j++)
          {
               finalArray[i,j]=array[i,j];
          }
     }
     
     for (int i = 0; i < delete[0]; i++)
     {
          for (int j = delete[1]+1; j < array.GetLength(1); j++)
          {
               finalArray[i,j-1]=array[i,j];
          }
     }
     

     for (int i = delete[0]+1; i < array.GetLength(0); i++)
     {
          for (int j = 0; j < delete[1]; j++)
          {
               finalArray[i-1,j]=array[i,j];
          }
     }
     
     for (int i = delete[0]+1; i < array.GetLength(0); i++)
     {
          for (int j = delete[1]+1; j < array.GetLength(1); j++)
          {
               finalArray[i-1,j-1]=array[i,j];
          }
     }

     return finalArray;
}

/* int[,] ArrayWithoutMin(int[,] array, int[] minCoordinates)
{
     int[,] result = new int[(array.GetLength(0) - 1), (array.GetLength(1) - 1)];
     int add=0;
     for (int i = 0; i < array.GetLength(0); i=i+1+add)
     {
          for (int j = 0; j < array.GetLength(1); j=j+1+add)
          {
               while(minCoordinates[0]!=i) 
               {
                    while(minCoordinates[1]!=j)
                    {
                         result[i,j]=array[i+add,j+add];
                    }
               }
               add++;
          }
     }
     return result;
} */



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
int[] minCoordinates=FindLeastNumber(array);
System.Console.WriteLine($"-{minCoordinates[0]},{minCoordinates[1]}-");
int[,] final = PrintFinalArray(array,minCoordinates);
PrintMatrix(final);