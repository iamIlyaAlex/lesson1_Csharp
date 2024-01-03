
//3адача 1: Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// - 2-мя if
// using System;
// class Programm
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 7 == 0)
//         {
//             if (number % 23 == 0)
//             {
//                 Console.WriteLine("Число кратно 7 и 23");
//             }
//             else
//             {
//             Console.WriteLine("Число не кратно 7 и 23");
//             }
//         }
//         else
//         {
//         Console.WriteLine("Число не кратно 7 и 23");
//         }
//     }
// }


//Задача 2: Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите координату X:");
//         int x = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Введите координату Y:");
//         int y = Convert.ToInt32(Console.ReadLine());

//         if (x > 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится в первой четверти");
//         }
//         else if (x < 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится во второй четверти");
//         }
//         else if (x < 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в третьей четверти");
//         }
//         else if (x > 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в четвёртой четверти");
//         }
//         else
//         {
//             Console.WriteLine("Точка находится на оси координат");
//         }
//     }
// }

//Задача 3: Написать программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите целое число из отрезка [10, 99]: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         int tensDigit = number / 10;
//         int onesDigit = number % 10;

//         int maxDigit = tensDigit > onesDigit ? tensDigit : onesDigit;
//         {
//             Console.WriteLine(maxDigit);
//         }
//     }
// }


//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую. Допускается вывод цифр в обратном порядке, например: 3462 => 2,6,4,3

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите натуральное число N: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Цифры числа {0} через запятую:", number);

//         while (number > 0)
//         {
//             int currentDigit = number % 10;
//             Console.Write(currentDigit);

//             if (number >= 10)
//             {
//                 Console.Write(",");
//             }

//             number = number / 10;
//         }
//     }
// }