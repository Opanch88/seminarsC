// Задайте массив из m элементов, заполненный случайными числами из промежутка [a, b]. Найдите сумму отрицательных элементов массива.

/*

int [] CreateRandomArray(int size, int minValue, int maxValue)
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


int SumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;    
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a min value: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a max value: ");
int b = Convert.ToInt32 (Console.ReadLine());

int [] myArray = CreateRandomArray(m, a, b);
WriteArray (myArray);
Console.WriteLine(SumOfNegatives(myArray));

*/


//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализируется размер массива, не конкретный индекс.
    for(int i =0; i < size; i++)  //можно использовать и while
        array[i] = new Random().Next(minValue, maxValue + 1);
   
    return array;
}
void WriteArray(int[] array)    //вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   //возвращаем массив
    Console.WriteLine();
}
int[] Replace (int[] array)
{
    for( int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    return array;
}
Console.Write("input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);

WriteArray(myArray);
WriteArray(Replace(myArray));

*/

//  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.





//  Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*

int [] CreateRandomArray(int size, int minValue, int maxValue)
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


int ElementQuantity (int[] array, int minEl, int maxEl)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > minEl && array[i] < maxEl) count++;
}
return count;
}


Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);

Console.Write("Enter the Left border: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Right border: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ElementQuantity(myArray, a, b));

*/