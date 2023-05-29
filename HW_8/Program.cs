// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int [,] array = new int [4,6];
// Fill_Array(array);
// Print_Array(array);
// Sort(array);
// Console.WriteLine();
// Print_Array(array);

// void Fill_Array(int[,] array)
// {
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
        
//     }
// }

// void Print_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void Sort(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1)-1; k++)
//       {
//         if(array[i,k]<array[i,k+1])
//         {
//           int temp =array[i,k+1];
//           array[i,k+1]=array[i,k];
//           array[i,k]=temp;
//         }
//       }
//     }
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int [,] array = new int [4,4];
// Fill_Array(array);
// Print_Array(array);
// Console.WriteLine();
// SortRows(array);
// void Fill_Array(int[,] array)
// {
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
        
//     }
// }
// void Print_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SortRows(int [,] array)
// {
//   int min=0;
//   int AllMinRow = 0;
//   int result =0;
//   for (int i = 0; i < array.GetLength(1); i++)
//   {
//     min+=array[0,i];
//   }
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       result+=array[i,j];
//     }
//     if(result<min)
//     {
//       min = result;
//       AllMinRow = i;
//     }
//     result =0;
//   }

// Console.WriteLine($"{AllMinRow+1} {"equil row with min sum elements "}");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int [,] array1 = new int [2,2];
// int [,] array2 = new int [2,2];
// Fill_Array(array1);
// Fill_Array(array2);
// Print_Array(array1);
// Print_Array(array2);
// int [,] array3 = new int[2,2];
// arrayThree_func(array1,array2,array3);
// Print_Array(array3);
// void Fill_Array(int[,] array)
// {
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
        
//     }
// }
// void Print_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void arrayThree_func(int [,] array1, int [,] array2, int [,] array3)
// {
// for (int i = 0; i < array3.GetLength(0); i++)
// {
//   for (int j = 0; j < array3.GetLength(1); j++)
//   {
//     int sum =0;
//     for (int k = 0; k < array1.GetLength(1); k++)
//     {
//       sum+=array1[i,k]*array2[k,j];
//     }
//     array3[i,j]=sum;
//   }
// }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// //  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int [,,] array = new int [2,2,2];
// Fill_Array(array);
// Print_Array(array);

// void Fill_Array(int [,,] array)
// {
//   int count =1;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         array[i,j,k] +=count;
//         count+=1;
//       }
//     }
//   }
// }

// void Print_Array(int [,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.WriteLine();
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Console.WriteLine($"{array[i,j,k]} ({i}, {j}, {k})");
//       }
//     }
//   }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// int [,] array = new int [4,4];


// int i=0;
// int j=0;
// int temp=1;
// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(array);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }