// большее из 2 чисел школа 

using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
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
    }

    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
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



// проверка на чётность / я

if (number % 2 == 0)
{
    Console.WriteLine($"Число `{number}` чётное");
}
else
{
    Console.WriteLine($"Число `{number}` нечётное");
}

// проверка на чётность / школа

using System;

class Answer
{
    static void CheckIfEven(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine($"Число `{number}` чётное");
        }
        else
        {
            Console.WriteLine($"Число `{number}` нечётное");
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

        CheckIfEven(number);
    }
}


// вывести четные числа / я

int i = 2;
while (i <= number)
{
    Console.Write($"{i}\t");
    i += 2;
}



// вывести четные числа / школа
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

// максимальное из трёх чисел / я

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