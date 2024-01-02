using System;
// Написать программу, которая принимает на вход трёзначное число и удаляет вторую цифру этого числа
// 256 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Задача 13 ");

// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//     Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else
// {
//     Console.WriteLine("-> третьей цифры нет");
// }

//1 input number
// int n = 348;

// int firstDigit = 3;
// int thirdDigit = 8;

// Console.WriteLine($"{firstDigit}{thirdDigit}");
//38

// int n = 456

// int answer = firstDigit * 10 + thirdDigit;
// 46 = 4 * 10 + 6
//46

// int n = 100;

// int firstDigit = n / 100;
// int lastDigit = n % 10;

//int answer = firstDigit * 10 + lastDigit;
// Console.WriteLine(answer);

// результат будет ($) в виде строки 
//Console.WriteLine($"{firstDigit}{lastDigit}");

// int number = 123;
// int n1 = number % 100;
// int n2 = n1 / 10;
// int n3 = number % 10;

// Console.WriteLine(n2);
// Console.WriteLine(n3);

// int sum = n2;
// int i = 1;

// while(i < n3)
// {
//     sum *= n2;
//     i += 1;
// }
// Console.WriteLine(sum);


//1 input data
// int a = 5;
// int b = 30;

//2 get remainder
// int r = b == a;
// 0, 1, 3, 4

//3
// if (r == 0)
// {
//     Console.Write("YES");
// }
// else
// {
//     Console.Write("NO. R =" + r);
// }

int n = 456;
int result1 = n / 10;
int result2 = result1 / 10;
int digit = result2 % 10;
Console.Write(result1);
