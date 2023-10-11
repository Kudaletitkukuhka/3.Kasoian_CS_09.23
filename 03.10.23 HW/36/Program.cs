/* Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

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

int OddPos (int[] array)
{
     int sum = 0;
     for (int i = 0; i < array.Length; i++)
     {
          if (i%2==1) sum+=array[i];
     }
     return sum;
}

int[] mass=Mass(5);
int result=OddPos(mass);
System.Console.WriteLine(result);

for (int i = 0; i < length; i++)
{
     
}