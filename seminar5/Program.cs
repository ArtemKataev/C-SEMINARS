// int [] array = new int [12];
// int sumPlus=0;
// int sumNeg= 0;

// for(int i=0;i<array.Length;i++)
// {
//   array[i] = new Random().Next(-9,10);
//   if(array[i]>0)
//   {
//     sumPlus+=array[i];
//   }
//   else
//   {
//     sumNeg+=array[i];
//   }
// }

// Console.WriteLine(String.Join(", ",array)+"\nsum all plus numbers "+ sumPlus+" sum neg number "+sumNeg);



//                     // task2
// int [] array1= new int [] {123,-213,1551,-626};
// Console.WriteLine(String.Join(", ",array1));

// for(int i=0;i<array1.Length;i++)
// {
//   array1[i]= -array1[i];
// }
// Console.WriteLine(String.Join(", ",array1));



          // Task3
// int [] array1= new int [] {33,2,1,43};
// // Console.WriteLine(String.Join(", ",array1));
// Console.WriteLine("enter number");
// int a = Convert.ToInt32(Console.ReadLine());
// bool flag=false;
// for(int i=0;i<array1.Length;i++)
// {
//  if(a==array1[i])
//  {
//   flag=true;
  
//   break;
//  }
// }

// if(flag==true)
// {
//   Console.WriteLine("CONGRATSSS");
// }
// else
// {
//   Console.WriteLine("try again");
// }

      // TASK4
// int [] arr = new int [123];
// int num =0;

// for (int i=0;i<arr.Length;i++)
// {
//   arr[i]=new Random().Next(0,501);
//     if((arr[i]>9)&&(arr[i]<100))
//     {
//       num+=1;
//     }
// }
// Console.WriteLine(String.Join(", ",arr));
// Console.WriteLine("количество двухзначных чисел равно "+num);

// int [] array1 =new int [] {4,3,2,6,7};
// int [] array2 = new int [(array1.Length/2)+(array1.Length%2)];

// for(int i=0;i<array2.Length;i++)
// {
//   array2[i]=array1[i]*array1[array1.Length-1-i];

//   if(i==array1.Length-1-i)
//   {
//     array2[i]=array1[array1.Length-1-i];

//   }
// }
// Console.WriteLine(String.Join(", ",array2));

