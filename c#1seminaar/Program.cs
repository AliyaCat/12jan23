// 2  Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32( Console.ReadLine());
// if(x>y)
// {
//     Console.WriteLine($"max {x}");
// }
// else Console.WriteLine($"max {y}");


// 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int a = Convert.ToInt32( Console.ReadLine());

// int max = x;

// if ( x > max ) max = x;
// if ( y > max ) max = y;
// if ( a > max ) max = a;
 
// Console.Write("max = ");
// Console.WriteLine(max);


// 6 Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32( Console.ReadLine());
// if (x % 2==0)
// {
//     Console.Write("да");
// }
// else 
// {
//     Console.Write("нет");
// }


//    8  Напишите программу, которая на вход принимает число (N),
//   а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32( Console.ReadLine());
// int i = 2;
// while (i<=x) 
// {
//     Console.Write(i + " ");
//     i=i+2;
// }