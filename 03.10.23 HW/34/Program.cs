/* Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

int[] Mass(int col)
{
     int [] array= new int [col];
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(100,1000);
          System.Console.Write($"{array[i]} ");
     }
     System.Console.WriteLine();
     return array;
}

int CheckMass (int[] array)
{
     int even = 0;
     for (int i = 0; i < array.Length; i++)
     {
          if (array[i]%2==0) even++;
     }
     return even;
}

int[] massive=Mass(5);
int result=CheckMass(massive);
System.Console.WriteLine(result);