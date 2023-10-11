/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76 */

int[] Mass(int col)
{
     int [] array= new int [col];
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(-100,100);
          System.Console.Write($"{array[i]} ");
     }
     System.Console.WriteLine();
     return array;
}

int FindDif (int[] array)
{
     int min = array[1];
     int max = array[1];
     for (int i = 0; i < array.Length; i++)
     {
          if (min>array[i]) min=array[i];
     }
     
     for (int i = 0; i < array.Length; i++)
     {
          if (max<array[i]) max=array[i];
     }
     int dif=max-min;
     return dif;
}

int[] mass=Mass(5);
int result=FindDif(mass);
System.Console.WriteLine(result);