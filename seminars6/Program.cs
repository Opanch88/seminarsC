/*int [] CreateRandomArray(int size, int minValue, int maxValue)

{
    int [] array = new int [size];  

    for (int i = 0; i < size; i++) 
        array [i] = new Random().Next (minValue, maxValue + 1 );
    return array;
}

void WriteArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReverseArray (int[]array)
{
    for ( int i = 0; i < array.Length / 2; i++)
    {
        int temp = array [i];
        array [i] = array [array.Length -1 - i ];
        array [array.Length -1 - i ] = temp;
    }
    
}

void ReverseArray2 (int[]array)
{
    for ( int i = 0; j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array [i];
        array[i] = array [j];
        array[j] = temp;
    }
}

*/

// Task 1   Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
Console.WriteLine("Введите длины трех сторон треугольника:");

Console.Write("Сторона A: ");
double sideA = double.Parse(Console.ReadLine());

Console.Write("Сторона B: ");
double sideB = double.Parse(Console.ReadLine());

Console.Write("Сторона C: ");
double sideC = double.Parse(Console.ReadLine());

if (IsValidTriangle(sideA, sideB, sideC))
{
    Console.WriteLine("Треугольник с такими сторонами существует.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не существует.");
}
    

bool IsValidTriangle(double a, double b, double c)
{
    return a + b > c && a + c > b && b + c > a;
}

*/

// Task 2   Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int N = 10; // Замените на нужное количество чисел Фибоначчи

int a = 0, b = 1;

Console.WriteLine("Первые " + N + " чисел Фибоначчи:");

if (N >= 1)
{
    Console.Write(a);
}

        for (int i = 2; i <= N; i++)
{
    Console.Write(", " + b);
    int temp = a;
    a = b;
    b = temp + b;
}

Console.WriteLine();
    