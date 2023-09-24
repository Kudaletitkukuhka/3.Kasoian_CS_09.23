//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

/*Мой вариант
int N=new Random().Next(10,99);
System.Console.WriteLine(N);
int a=N/10;
int b=N%10;
if(a>b)
     {
     System.Console.WriteLine($"{a} наибольшая цифра числа");
     }
else if(b>a)
          {
          System.Console.WriteLine($"{a} наибольшая цифра числа");
          }
else System.Console.WriteLine($"цифры числа равны");
*/

int N=new Random().Next(10,99);
System.Console.WriteLine(N);
int a=N/10;
int b=N%10;

int max=a;

if(max<b)
     {
          max=b;
     }    
     System.Console.WriteLine($"Наибольшая цифра числа {max}");