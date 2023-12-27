// большее из 2 чисел школа 

if (firstNumber == secondNumber)
{
    Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}
if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
if (firstNumber < secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}

if (number % 2 == 0)
{
    Console.WriteLine($"Число `number` чётное");
}
else
{
    Console.WriteLine($"Число `number` нечётное");
}

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine($"Введённые числа равны `{firstNumber}`");
}
else
{
    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}

// большее из 2 чисел я

if (firstNumber < secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}
else
{
    Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}



int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
return max;

int i = 2;
while (i <= number)
{
    Console.Write($"{i}\t");
    i += 2;
}



//решение школы вывести четные числа
using System;

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}\t");
        }
    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 6;
        }

        PrintEvenNumbers(number);
    }
}


//решение школы максимальное из трёх чисел

using System;

public class Answer
{
    static int FindMax(int a, int b, int c)
    {
        int max = a;
        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        return max;
    }

    static public void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            a = 5;
            b = 6;
            c = 7;
        }

        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}
