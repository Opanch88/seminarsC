// Seminar 2.

// Theory

/*



*/

// Task 1.  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*

int CutNumber(int num)
{
    int hunders = num / 100;
    int units = num % 10;

    int res = hunders * 10 + units;
    return res;
}

// return может забрать месь метод  return "hunders * 10 + units" вместо "return res";

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");

// Console.WriteLine(CutNumber(randNumber)); это прошлая версия строки 28, но строке 28 мы видим результат входного и результата 


*/



// Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.


bool IsDividable(int num, int div1, int div2)
{
//   if (num % div1 == 0 && num % div2 == 0)       //&& логическое "и"      || логическое "или"
//       return true;
//   else
//      return false;
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







