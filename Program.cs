// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// Pow (numberA, numberB);

// void Pow (int a, int b) 
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }


// int ReadInt(string message)  
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);

// int ReadInt(string message) // Ф-ия ввода
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int NumberLen(int a) // Ф-ия подсчета цифр
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void SumNumbers(int n, int len) // Ф-ия вывода суммы цифр
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры 
// и выводит массив на экран.

// int[] arr = new int[8];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(1,9);
//     Console.Write(arr[i] + " ");
// }

