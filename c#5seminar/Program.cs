// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         result++;
//     }
// }
// if (result % 10 == 1)
// {
//     Console.WriteLine($"В массиве {result} четное число");
// }
// if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
// {
//     Console.WriteLine($"В массиве {result} четных числа");
// }
// else

//     Console.WriteLine($"В массиве {result} четных чисел");

// void FillArrayRandomNumbers(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 999);
//     }
// }
// void PrintArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int array = 0; array < numbers.Length; array+=2)
//     sum = sum + numbers[array];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях  {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,20);
//         }
// }
// void PrintArray(int[] numbers)
// {
  
//     for(int i = 0; i < numbers.Length; i++)
        
//         Console.Write(numbers[i] + " ");
        
//     Console.WriteLine();
// }

// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int array = 0; array < numbers.Length; array++)
{
    if (numbers[array] > max)
        {
            max = numbers[array];
        }
    if (numbers[array] < min)
        {
            min = numbers[array];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        
        Console.Write(numbers[i] + " ");
      
    Console.WriteLine();
}