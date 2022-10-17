// Task2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 5;
int b = 7;

Console.WriteLine("Number a = " + a);
Console.WriteLine("Number b = " + b);

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.WriteLine("Max = " + max);
Console.WriteLine("===================");

int c = 2;
int d = 10;

Console.WriteLine("Number a = " + c);
Console.WriteLine("Number b = " + d);

int max2 = c;

if (c > max2) max2 = c;
if (d > max2) max2 = d;

Console.WriteLine("Max = " + max2);
Console.WriteLine("===================");

int e = 2;
int f = 10;

Console.WriteLine("Number a = " + e);
Console.WriteLine("Number b = " + f);

int max3 = e;

if (e > max3) max3 = e;
if (f > max3) max3 = f;

Console.WriteLine("Max = " + max3);