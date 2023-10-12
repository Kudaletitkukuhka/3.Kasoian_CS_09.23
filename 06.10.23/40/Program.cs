/* Напишите программу, которая принимает 
на вход три числа и проверяет, может 
ли существовать треугольник с сторонами такой длины.*/

bool CheckTriangle (int a, int b, int c)
{
     bool result = false;
     if (a<b+c && b<a+c && c<a+b) result=true;
     return result;
}

System.Console.WriteLine("Введите первую длину:\t");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую длину:\t");
int B=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третью длину:\t");
int C=Convert.ToInt32(Console.ReadLine());
bool answer = CheckTriangle(A,B,C);

System.Console.WriteLine(answer);