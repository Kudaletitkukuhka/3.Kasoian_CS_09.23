/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

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

bool CheckMassive(int x, int[] array)
{
     bool check = false;
     for (int i = 0; i < array.Length; i++)
     {
          if (array[i] == x||array[i] == -x) 
          {
               check = true;
          }
     }
     return check;
}

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int minAr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение элемента массива: ");
int maxAr = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateMassive( n, minAr, maxAr );

Console.Write("Какое число мы ищем? ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(CheckMassive(x,arr));
