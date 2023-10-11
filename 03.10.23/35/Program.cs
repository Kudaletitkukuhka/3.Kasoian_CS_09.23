/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
 */

 
int[] CreateMassive(int size, int minValue, int maxValue)
{
     int[] array = new int[size];
     for (int i = 0; i < size; i++)
     {
          array[i] = new Random().Next(minValue,maxValue + 1);
          System.Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
     return array;
}

int CheckMassive(int[] array)
{
     int check = 0;
     for (int i = 0; i < array.Length; i++)
     {
          if (array[i] > 10 && array[i] < 99) 
          {
               check++;
          }
     }
     return check;
}

int n=123;
int minAr = -200;
int maxAr = 200;

int[] arr = CreateMassive( n, minAr, maxAr );

int result = CheckMassive(arr);
System.Console.WriteLine(result);
