// Написать программу которая на вход принимает 2 целых числа и проверяет, является ли первое число квадратом второго

// Шаги что нужно делать!
//1 input data - (ввод данных) , (integer variables) - (целочисленной переменной) 
//2 create var (с) with square of 2nd number - (создать переменную с квадрата второго числа)
//3 compare - (сравнить)  a and c
//4 print answer 


int a = 5;
int b = 40;

int c = b * b;
// int c = (int)Math.Pow(b, 2);

if (a == c)
{
    Console.WriteLine("Да, является");
}
else
{
    // если (a == c) - не верно (не прошло проверку)
    Console.WriteLine("Нет, не является");
}