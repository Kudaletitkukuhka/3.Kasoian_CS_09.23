/* Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте,
а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] CreateMass(int size, int minV, int maxV)
{
     int[] array = new int [size];
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(minV,maxV);
     }
     return array;
}

int[] ReverseMass(int[] array)
{
     int temp = 0;
     for (int i = 0; i < array.Length/2+array.Length%2; i++)
     {
          temp = array[i];
          array[i] = array[array.Length-1-i];
          array[array.Length-1-i]=temp;
     }
     return array;
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
          System.Console.Write($"{array[i]}\t");
     }
     System.Console.WriteLine();
}


int s = 5;
int minV = -10;
int maxV = 10;

int[] array = CreateMass(s, minV, maxV);
PrintArray(array);
array = ReverseMass(array);
PrintArray(array);