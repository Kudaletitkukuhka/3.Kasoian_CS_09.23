void Mass(int col)
{
     int [] array= new int [col];
     for (int i = 0; i < array.Length; i++)
     {
          array[i] = new Random().Next(0,10);
          System.Console.Write($"{array[i]} ");
     }
}

System.Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Mass(n);
