            //TASK47

// Console.WriteLine("enter first number ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter second number");
// int columns =Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     array[i,j] = new Random().Next(-999,1000);
//     Console.Write(array[i, j]+ " ");
//   }
  
//   Console.WriteLine( );
// }

                  //TASK 50
// int rows = ReadInt("enter some rows: ");
// int columns = ReadInt("enter some columns: ");
// int[,] numbers = new int[4, 3];
// Fill_Array(numbers);
// Print_Array(numbers);

// if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[rows, columns]);
// else Console.WriteLine($"{rows}{columns} -> that's number not found, try again");


// void Fill_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 11);
//         }
//     }
// }

// void Print_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


//             //TASK52
// int rows = 3;
// int colums = 4;
// int[,] numbers = new int[rows, colums];
// Fill_Array(numbers);
// Print_Array(numbers);

// double[] avgNumbers = new double[numbers.GetLength(1)];

// for (int i = 0; i < numbers.GetLength(1); i++)
// {
//     double result = 0.0;
//     for (int j = 0; j < numbers.GetLength(0); j++)
//     {
//         result += numbers[j, i];
//     }
//     avgNumbers[i] = result / numbers.GetLength(0);
// }
// PrintArray2(avgNumbers);



// void Fill_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// void Print_Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void PrintArray2(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
