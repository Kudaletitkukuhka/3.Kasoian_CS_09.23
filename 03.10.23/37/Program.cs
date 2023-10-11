/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10 */

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

int[] MultiplyMassive(int[] array)
{
     int size = array.Length / 2 + array.Length % 2;
     int [] mularr = new int[size];

     for (int i = 0; i < mularr.Length; i++)
     {
          if (i!= array.Length-i-1) 
          {
               mularr[i]=array[i]*array[array.Length-i-1];
               System.Console.Write($"{mularr[i]} ");
          }
          else 
          {
               mularr[i]=array[i];
               System.Console.Write($"{mularr[i]} ");
          }
     }
     return mularr;

}


int n=5;
int minAr = -200;
int maxAr = 200;

int[] arr = CreateMassive(n, minAr, maxAr);
int[] result = MultiplyMassive(arr);