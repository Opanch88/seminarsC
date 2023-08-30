//  Task 1. Задайте двумерный массив. Напишите программу, которая поменяет местами две любые  строки массива.

/*

int [,] CreadRandom2dArray (int rows, int columns, int minValue, int maxValue )
{
    int [,] array = new int [ rows,columns ];

    for ( int i = 0; i < rows; i++) 
        for ( int j = 0; j < columns; j ++)   
            array [i,j] = new Random().Next (minValue, maxValue + 1);

    return array;    
}                        


void Show2dArray (int [,] array )
{
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for( int j = 0; j < array.GetLength(1); j++ )  
            Console.Write(array [i,j] + " ");

        Console.WriteLine();
    }
}


void ChangeRows (int[,] array, int r1, int r2)
{


    if (r1 >= 0 && r1 < array.GetLength(0) &&
        r2 >= 0 && r2 < array.GetLength(0) &&
        r1 != r2)
        {
            for (int j = 0; j < array.GetLength(1);j++)
            {
                int temp = array [j, r1];
                array [j, r1] = array [j, r2];
                array [j, r2] = temp;

            }
        }
}




Console.Write("Enter the string: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter a column: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter the maximum number: ");
int max = Convert.ToInt32 (Console.ReadLine());

int [,] myArray = CreadRandom2dArray (rows, columns, min, max);

Show2dArray(myArray);

Console.Write("Input a number of the first to change: ");
int row1 = Convert.ToInt32 (Console.ReadLine ()) - 1 ;

Console.Write("Input a number of the second to change: ");
int row2 = Convert.ToInt32 (Console.ReadLine ()) - 1 ;


ChangeRows (myArray, row1, row2);
Show2dArray(myArray);

*/

//   Task 2.   Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

/*

int [,] CreadRandom2dArray (int rows, int columns, int minValue, int maxValue )
{
    int [,] array = new int [ rows,columns ];

    for ( int i = 0; i < rows; i++) 
        for ( int j = 0; j < columns; j ++)   
            array [i,j] = new Random().Next (minValue, maxValue + 1);

    return array;    
}                        


void Show2dArray (int [,] array )
{
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for( int j = 0; j < array.GetLength(1); j++ )  
            Console.Write(array [i,j] + " ");

        Console.WriteLine();
    }
}


int[,] ChangeRowsToColoumns (int[,] array) 
{

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = i + 1; j < array.GetLength(1); j++)
{
int temp = array[i, j];
array[i, j] = array[j, i];
array[j, i] = temp;


}

}
return array;
}


Console.Write("Enter the string: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter a column: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter the maximum number: ");
int max = Convert.ToInt32 (Console.ReadLine());

int [,] myArray = CreadRandom2dArray (rows, columns, min, max);
Show2dArray(myArray);

Console.WriteLine ();

ChangeRowsToColoumns (myArray);
Show2dArray(myArray);

*/

//   Task 3.    Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

/*

int [,] CreadRandom2dArray (int rows, int columns, int minValue, int maxValue )
{
    int [,] array = new int [ rows,columns ];

    for ( int i = 0; i < rows; i++) 
        for ( int j = 0; j < columns; j ++)   
            array [i,j] = new Random().Next (minValue, maxValue + 1);

    return array;    
}                        


void Show2dArray (int [,] array )
{
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for( int j = 0; j < array.GetLength(1); j++ )  
            Console.Write(array [i,j] + " ");

        Console.WriteLine();
    }
}


int[,] DelteRowAndColoumnWithMinValue (int[,] array)
{
    int minI = 0;
    int minJ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }

    int[,] result =new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (i < minI && j < minJ) result[i,j] = array[i, j];
                if (i < minI && j >= minJ) result[i, j] = array[i, j + 1];
                if (i >= minI && j < minJ) result[i, j] = array[i + 1, j];
                if (i >= minI && j >= minJ) result[i, j] = array[i + 1, j + 1];
            }
        }
    return result;
}



Console.Write("Enter the string: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter a column: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter the maximum number: ");
int max = Convert.ToInt32 (Console.ReadLine());

int [,] myArray = CreadRandom2dArray (rows, columns, min, max);
Show2dArray(myArray);

Console.WriteLine ();

int [,] newArray = DelteRowAndColoumnWithMinValue (myArray);
Show2dArray(newArray);

*/