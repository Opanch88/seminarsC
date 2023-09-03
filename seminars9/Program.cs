//  Task 63: Задайте значение N. Напишите программу, 
//             которая выведет все натуральные числа в промежутке от 1 до N.
//    N = 5 -> "1, 2, 3, 4, 5"
//    N = 6 -> "1, 2, 3, 4, 5, 6"

//  1 метод  от 1 до N. 
/*
string PrintNumer(int num, string res)
{
    if (num == 1)
    {
        res = "1" + " " + res;
        return res;
    }
    else
    {
        res = num + " " + res;
        return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);
*/
//  2 метод  от N до 1. 
/*
string PrintNumer(int num, string res)
{
    if (num == 1)
    {
        res = res + "" + "1";
        return res;
    }
    else
    {
        res = res + num + " ";
        return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);
*/



//  Task 65: Задайте значения M и N. Напишите программу, 
//             которая выведет все натуральные числа в промежутке от M до N.
//    M = 1; N = 5 -> "1, 2, 3, 4, 5"
//    M = 4; N = 8 -> "4, 6, 7, 8"

// метод 1 от M до N
/*
void ShowNaturalNumbers(int min, int max, int count = 0)
{
    if (min > count)
        count = min;

    else
        count++;

    Console.Write(count + " ");

    if (count < max)
    {
        ShowNaturalNumbers(min, max, count);
    }

}

Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(min, max);
*/
//  2 метод  от большего к меньшему 
/*
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (PrintNumbers(start + 1, end) + " " + start);
}

Console.WriteLine(PrintNumbers(1, 8));
*/
//  3 метод  от меньшего  к большему 
/*
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end) );
}

Console.WriteLine(PrintNumbers(1, 8));
*/



//  Task 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//  453 -> 12
//  45 -> 9
/*
int SumDigits(int number)
{
    if (number == 0)
        return 0;
    else
        return number % 10 + SumDigits(number / 10);

}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));
*/



//  Task 69: Напишите программу, которая на вход принимает два числа A и B, 
//           и возводит число А в целую степень B с помощью рекурсии.
//  A = 3; B = 5 -> 243 (3⁵)
//  A = 2; B = 3 -> 8

// 1 вариант (БЕЗ РЕКУРСИИ)
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

double IntegerDegree(int a, int b)
{
    return Math.Pow(a, b);
}

double result = IntegerDegree(a, b);
Console.WriteLine($"{a}^{b} = {result}");
*/

// 2 метод 
/*
int PowerAB(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {

        return a * PowerAB(a, b - 1);
    }
}

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"{a}^{b} = {PowerAB(a, b)}");
*/



//  Рекурсии на примере функции нахождения факториала.
/*
int Factorial(int num)
{
    if (num == 0)
        return 1;
    else
        return num * Factorial(num - 1);
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial of a number {num} = {Factorial(num)}");
*/

//  Рекурсии на примере функции нахождения чисел Фибоначчи.

/*

int Fibonachi(int num)
{
    if (num == 0)
        return 1;
    if (num == 1)
        return 1;
    else
        return Fibonachi(num - 1) + Fibonachi(num - 2);
}


Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Fibonachi {num} of a number = {Fibonachi(num)}");
*/