/* Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования. */

int[] CreateArray (int size, int MinV , int MaxV)
{
     int[] array = new int[size];
     for (int i = 0; i < size; i++)
     {
          array[i] = new Random().Next(MinV,MaxV);
     }
     return array;
}

int[] CopyArray (int[] array)
{
     int[] copy = new int[array.Length];
     for (int i = 0; i < copy.Length; i++)
     {
          copy[i] = array[i];
     }
     return copy;
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
          System.Console.Write($"{array[i]}\t");
     }
     System.Console.WriteLine();
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());;

int[] newarray=CreateArray(size, min, max);
PrintArray(newarray);
int[] copyarray=CopyArray(newarray);
PrintArray(copyarray);
