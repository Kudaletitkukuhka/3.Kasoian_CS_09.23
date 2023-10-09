/* Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
 */

 System.Console.WriteLine("Ниже представлен массив из 8 элементов, заполненный нулями и единицами в случайном порядке:");

 void CreateArray()
 {
     int[] array = new int [8];
     for (int i = 0; i < array.Length; i++)
     {
          array[i]=new Random().Next(0,2);
          System.Console.Write(array[i]);
     }
 }

 CreateArray();