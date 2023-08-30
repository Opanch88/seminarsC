// Seminar 2.

// Theory

/*                


13254 / 10 = 1325
13254 / 100 = 132        // деление на целочисленное цисло 
13254 / 1000 = 13       // отсекает остатки 
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54         // остаток от деление 
13254 % 1000 = 254        // берем остаток
13254 % 10000 = 3254

пример :
24365 -> 43
24365 / 100 = 243
243 % 100 = 43


*/

// Task 1.  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*

int CutNumber(int num)   // 254
{
    int hunders = num / 100;   //  254 / 100 = 2
    int units = num % 10;      // 254 % 10 = 4 

    int res = hunders * 10 + units;      //  2 * 10 + 4 = 24 
    return res;    // return может забрать месь метод  return "hunders * 10 + units" вместо "return res";
                  // returt выдает результат метода и завершает его 
} 

int randNumber = new Random().Next(100, 1000);  // 100 включается в границу трехзначных чисел (мин -100 )
                                                 // 1000 не включается в границу чисел (мах - 999)
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");

// Console.WriteLine(CutNumber(randNumber)); это прошлая версия строки 43, но строке 43 мы видим результат входного и результата 


*/



// Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/*

bool IsDividable(int num, int div1, int div2)
{
//  if (num % div1 == 0 && num % div2 == 0)       //&& логическое "и"      || логическое "или"
  //  return true;
//  else
  //  return false;                 или так или как в 63 мтроче , возвращаем срузу в ретерне тру    
//
  return num % div1 == 0 && num % div2 == 0;
}

Console.Write ("Imput a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a frist divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDividable(number, divider1, divider2);

if(res) Console.Write("Yes");
else Console.Write ("No");

*/



//Task 3.    Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*

int MaxNum(int num)
{
  int num1 = num % 10;
  int num2 = num / 10;
  if (num1 > num2) return num1;
  else return num2;
}

int number = new Random().Next(10, 100);     // [a;b)]
Console.WriteLine(number);
int res = MaxNum(number);
Console.WriteLine(res);

*/


//Task 4.  Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*

bool square (int second, int frist)                                      // square - название функции 
{
  return (second == frist * frist || frist == second * second);
}

Console.WriteLine("Input the frist number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool res = square (number1, number2);                                   //вызываем функцию  ( res - название функции( переменная)   )
if (res) Console.WriteLine("Yes");                                       // bool потому что нам нужен ответ да или нет ( тру или фолс )
else Console.WriteLine("No");

*/