// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число");
int x = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите степень");
int y = Convert.ToInt32( Console.ReadLine());

Diss(x, y);


void Diss(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32( Console.ReadLine());

// int y = Number(x);
// Sum(x, y);

// int Number(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void Sum(int n, int y)
// {
//     int sum = 0;
//     for (int i = 1; i <= y; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine($"сумма цифр {sum}");
// }

//  Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и 
//  далее выводит массив на экран в одну строку.

//  int enterNumber = 8;
// int[] array = new int[enterNumber];

// for (int i = 0; i < enterNumber; i++)
// {
//   Console.Write("Введите любое число: ");
//   array[i] = Convert.ToInt32(Console.ReadLine());
// }

// var str = string.Join(" ", array);
// Console.WriteLine(str);
