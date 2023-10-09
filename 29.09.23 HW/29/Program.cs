/* Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

 System.Console.WriteLine("Ниже представлен массив из 8 элементов, заполненный нулями и единицами в случайном порядке:");

 void CreateArray()
 {
     int[] array = new int [8];
     for (int i = 0; i < array.Length; i++)
     {
          array[i]=new Random().Next(0,100);
          System.Console.Write(array[i]);
     }
 }

 CreateArray();