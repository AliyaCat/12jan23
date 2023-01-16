// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// string  x = Console.ReadLine();

// void CheckingNumber(string x)
// {
//   if (x[0]==x[4] || x[1]==x[3])
//   {
//     Console.WriteLine($"{x} - палиндром.");
//   }
//   else Console.WriteLine($" {x} - НЕ палиндром.");
// }

// if (x!.Length == 5)
// {
//   CheckingNumber(x);
// }
// else Console.WriteLine($"Введи правильное число");


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату x первой точки");
// int x1 = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите координату y первой точки");
// int y1 = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите координату z первой точки");
// int z1 = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите координату x второй точки");
// int x2 = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите координату y второй точки");
// int y2 = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите координату z второй точки");
// int z2 = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine(Dist(x1,y1,x2,y2,z1,z2));

// int X = x2 - x1;
// int Y = y2 - y1;
// int Z = z2 - z1;

// // double length = Math.Sqrt(X*X + Y*Y + Z*Z); 
// // Console.WriteLine($"Расстояние {length}");
 
// double Dist(int x1, int y1, int x2, int y2, int z1, int z2) 
// { 
//     double D = Math.Sqrt(Math.Pow((x2 - x1), 2) +  Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1),2)); 
//     return D; 
// }


// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32( Console.ReadLine());

// for (int i = 1; i <= x; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }
