﻿// Написать программу которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

int N = 3;

// Console.WriteLine(-3);
// Console.WriteLine(-2);
// Console.WriteLine(-1);
// Console.WriteLine(0);
// Console.WriteLine(1);
// Console.WriteLine(2);
// Console.WriteLine(3);


//1 определиться с действием (выписать 3 штуки)
// вывод числа
//2 определить закономерности изменений в действиях
//3 ввести доп переменную (счётчик)
// заменить то что изменяется в действиях на счёт
//4 дать счётчику правильное начальное значение и его изменение


int i = -N;
while (i <= N)
{
    Console.WriteLine(i); // вывод числа
    i = i + 1;
}

// Console.WriteLine(N);
// i == N // условие остановки
// ==>
// i !=N
// i <= N