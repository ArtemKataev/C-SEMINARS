// TASK1
int num = new Random().Next(11,11);
Console.WriteLine(num);
int a = num/10;
int b= num%10;
if(a>b)
{
Console.WriteLine(a);
}
else if (b>a)
{
Console.WriteLine(b);
}
else 
{
  Console.WriteLine("числа равны");
}

// //TASK2
// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int a =num/100;
// int b=num%10;
// int c =(num/10%10);
// Console.WriteLine("your number is " +a+b);
// Console.WriteLine("number was deleted " + c);

// // TASK3
// Console.WriteLine("enter number");
// int num = Convert.ToInt32(Console.ReadLine());
// int a=7;
// int b=23;
// if(num%a==0&&num%b==0)
// {
//   Console.WriteLine("да делится");
// }
// else
// {
//   Console.WriteLine("нет не делится");
// }

// // TASK4
// Console.WriteLine("enter number 1" );
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter number 2" );
// int num2= Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
//   Console.WriteLine(num1 +" является квадратом числа "+num2);
// }
// else if(num2==num1*num1)
// {
//   Console.WriteLine(num2+" является квадратом числа "+num1 );
// }
// else 
// {
//   Console.WriteLine("числа не являются квадратами друг друга");
// }

                                    // HOMEWORK
// // TASK1
// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int a =num/100;
// int b=num%10;
// int c =(num/10%10);
// Console.WriteLine("сотни "+a);
// Console.WriteLine("десятки" + c);
// Console.WriteLine("единицы"+b);

                                        // TASK2
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numLeng = num.ToString().Length;
//     if (numLeng >= 3)
//         {
//             while (num > 999)
//             {
//                 num = num / 10;
//             }
//             int num3 = num % 10;
//             Console.WriteLine($"Третья цифра введенного числа {num3} ");
//         } 
//     else
//     {
//         Console.WriteLine("Упс. Введеное число содержит менее трех цифр. Попробуйте еще раз.");
//     }

// // TASK3
// int day = new Random().Next(1,8);
// Console.WriteLine(day+" its a weekend??");
// if(day==1||day==2||day==3||day==4||day==5)
// {
//   Console.WriteLine("NO");
// }
// else
// {
//   Console.WriteLine("YES");
// }
