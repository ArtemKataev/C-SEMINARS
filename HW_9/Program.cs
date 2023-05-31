// Задача 64.адайте значение Н. НАпишите программу, которая выведет все натуральные числа
// в промужетку от Н до 1. Выполнить с помощью рекурсии.
// Console.WriteLine("enter number");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 1)
// {
//   Console.WriteLine("incorrect number");
//   return;
// }
// Console.WriteLine();
// ReadInt(n);

// void ReadInt(int n)
// {
//   if (n < 1)
//   {
//     return;
//   }
//   Console.Write(n + " ");
//   ReadInt(n - 1);
// }

//Задача 66. Задайте значения М и Н.
//Напишите программу, которая найдет сумму натуральных элементов в промежутке от М до Н.
// int M = ReadInt("enter number N");
// int N = ReadInt("enter number M");
// Console.WriteLine();
// Recursion(M,N,0);

// void Recursion(int M,int N,int count)
// {
// if (M>N)
// {
//   Console.WriteLine(count);
//   return;
// }
// count+=(M++);
// Recursion(M,N,count);
// }

// int ReadInt(string text)
// {
//   System.Console.WriteLine(text);
//   int number = Convert.ToInt32(Console.ReadLine());
//   return number;
// }


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа M и N.

// int M = ReadInt("enter number m");
// int N = ReadInt("enter number n");

// Func(M,N);
// int ReadInt(string text)
// {
//   System.Console.WriteLine(text);
//   int number = Convert.ToInt32(Console.ReadLine());
//   return number;
// }

// int Func (int M, int N)
// {
//     if (M == 0) return N + 1;
//     if (M != 0 && N == 0) return Func(M - 1, 1);
//     if (M > 0 && N > 0) return Func(M - 1,Func(M,N - 1));
// return Func(M, N);
// }

// Console.WriteLine($"Функция Аккермана для чисел {M}{" и "}{N} = {Func(M, N)}");

