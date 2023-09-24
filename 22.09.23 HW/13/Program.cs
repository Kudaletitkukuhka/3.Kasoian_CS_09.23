/* Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что 
третьей цифры нет. */

Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=0;//счетчик разрядов
int x=1;//искомое
int ostatok;

if (N<0) {
      N=N*(-1);
      }
ostatok=N;
      System.Console.WriteLine(N);


if (N/100>=1) {
              while(ostatok>=1){
               ostatok=ostatok/10;
               i++;
              // System.Console.WriteLine(i);
              }
          if (i==3) {
                    x=N%10;
                    }
          else  {
                for( int j=0; j<i-3; j++) {
                                         x=x*10;
                                         }
                x=N/x%10;
                System.Console.WriteLine(x);
                }
          System.Console.WriteLine(x);
}

else {
     System.Console.WriteLine("третьей цифры нет"); 
     } 

