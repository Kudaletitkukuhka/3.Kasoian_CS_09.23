/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

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

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int minAr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение элемента массива: ");
int maxAr = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateMassive(n,minAr, maxAr);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arr.Length; i++)
{
     if (arr[i]>=0) sumPos += arr[i];
     else sumNeg += arr[i];
}

System.Console.WriteLine($"Cумма отрицательных чисел массива равна {sumNeg}");
System.Console.Write($"Cумма положительных чисел массива равна {sumPos}");