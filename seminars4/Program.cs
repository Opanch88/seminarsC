                // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*

int sum (int a)
{
int result = 0;
for (int i = 1; i <= a; i++)
    result += i;
return result;
}

Console.WriteLine("Введите число А: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum (num)) ;

*/


                // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
 
 int Num (int N)

 {  
    int i = 1;
    for (; 10 <= N; i++)
        N = N / 10;
    return i;
 }
Console.WriteLine("Ввидите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Num (num)) ;

*/

                //  Напишите программу, которая принимает на вход число N и выдаёт произведение нечетных чисел от 1 до N.     

/*

int prov (int a)
{
int result = 1;
for(int i = 1; i <= a; i= i+2)
result *= i;
return result;
}
Console.WriteLine("input the number");

int nunumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(prov(nunumber));

*/


/*


int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minValue, maxValue + 1);
    } 

    return array;

}

void WriteArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");

    Console.WriteLine ();
}   

Console.WriteLine ("Input a length of an array: ");
int length = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Input a min possible value: ");
int min = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Input a max possible value: ");
int max = Convert.ToInt32 (Console.ReadLine ());

int [] myArray = CreateRandomArray (length, min, max);
WriteArray (myArray);

*/




Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
     array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Введенный массив: [ ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);

    if (i < array.Length )
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");
