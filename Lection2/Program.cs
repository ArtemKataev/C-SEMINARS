﻿// int Max( int arg1, int arg2, int arg3)
// {
//   int result =arg1;
//   if(arg2>result) result = arg2;
//   if(arg3>result) result = arg3;
//   return result;
// }
// int[]array ={1,2,3,14,5,6,7,8,9};

// int MaxResult=Max(
// Max(array[0],array[1],array[2]),
// Max(array[3],array[4],array[5]),
// Max(array[6],array[7],array[8])

// );

// Console.WriteLine(MaxResult);



// int []array ={31,42,125,111,31};
// int n=array.Length;
// int find =31;
// int index =0;

// while(index<n)
// {
//   if(array[index]==find)
//   {
//     Console.WriteLine(index);
//     break;
//   }
// index++;
// }


void Fillarray(int[] collection)
{
  int length =collection.Length;
  int index =0;
  while(index<length)
  {
    collection[index]=new Random().Next(1,10);
    index++;
  }
}
void Printarray(int[] col)
{
int count =col.Length;
int position =0;
while(position<count)
{
Console.WriteLine(col[position]);
position++;
}
}

int IndexOf (int[] collection, int find)
{
  int count =collection.Length;
  int index =0;
  int position =-1;
  while(index<count)
  {
    if(collection[index]==find)
    {
position =index;
break;
    }
    index++;
  }
  return position;
}
int [] array=new int [10];

Fillarray(array);
array[4]=4;
array[6]=4;
Printarray(array);
Console.WriteLine();
int pos =IndexOf(array,1);
Console.WriteLine(pos);