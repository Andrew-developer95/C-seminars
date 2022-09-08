// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//done

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = number / 10;

Console.WriteLine($"{digit2 % 10}");
