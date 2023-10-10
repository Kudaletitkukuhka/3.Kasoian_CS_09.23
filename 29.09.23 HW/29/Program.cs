/* Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

 void CreateArray(int col)
 {
     int[] array = new int [8];
     for (int i = 0; i < array.Length; i++)
     {
          array[i]=new Random().Next(0,100);
          System.Console.Write(array[i]);
     }
 }

System.Console.Write("Введите количесвто элементов в массиве: ");
int col = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Ниже представлен массив из {col} элементов, заполненный случайными числами:");
 CreateArray(col);