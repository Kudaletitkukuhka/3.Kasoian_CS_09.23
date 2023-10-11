/* Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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

int[] InvertMassive(int[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = array[i]*(-1);
          System.Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
     return array;
}

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int minAr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение элемента массива: ");
int maxAr = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateMassive(n,minAr, maxAr);
arr = InvertMassive(arr);
