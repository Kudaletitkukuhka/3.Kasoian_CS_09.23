using System;
/* Напишите программу, которая
принимает на вход координаты двух
точек и находит расстояние между ними в
2D пространстве. */
double x1,x2,y1,y2;
double x;

System.Console.Write("Введите координаты первой точки.\nX: ");
x1=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Y: ");
y1=Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите координаты второй точки.\nX: ");
x2=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y: ");
y2=Convert.ToInt32(Console.ReadLine());

x=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
System.Console.WriteLine(x);
