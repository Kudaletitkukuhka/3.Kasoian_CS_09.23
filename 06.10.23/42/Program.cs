/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
double result = 0;
while (num >= 1)
{
     result=num%2*Math.Pow(10, count) + result; 
     num=num/2;
     count++;
}
System.Console.WriteLine(result);

