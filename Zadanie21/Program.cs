﻿Console.WriteLine("vvedite 1 coordinaty x ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite 2 coordinaty x ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite 3 coordinaty x ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite 1 coordinaty y ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite 2 coordinaty y ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite 3 coordinaty y ");
int y3 = Convert.ToInt32(Console.ReadLine());
int a = y1-x1;
int b = y2-x2;
int c = y3-x3;
int a1 = a*a;
int a2 = b*b;
int a3 = c*c;
int SummaKvadratov = a1+a2+a3;
Double Result = Math.Sqrt(SummaKvadratov);
Console.WriteLine(Result);