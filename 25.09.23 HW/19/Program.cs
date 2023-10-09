/* Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом. */

int a,b,c,d,e;

System.Console.WriteLine("Введите пятизначное число: ");
N=Convert.ToInt32(Console.ReadLine());
if (N<0) 
     {
     N=N*(-1);
     }
if (N>99999 || N<10000) 
     {
     System.Console.WriteLine("Вы ввели не пятизначное число");
     }
else 
     {
     a=N/10000;
     b=N/1000%10;
     c=N/100%10;
     d=N/10%10;
     e=N%10;

     if (a==e && b==d) 
          {
          System.Console.WriteLine("Да");
          }
     else 
          {
          System.Console.WriteLine("Нет");
          }
     }

/*
для автопроверки
 if (N<99999 && N>10000) {
        int a=N/10000;
        int b=N/1000%10;
        int c=N/100%10;
        int d=N/10%10;
        int e=N%10;
        if (a==e && b==d) return true;
        
        }
      else return false;
*/