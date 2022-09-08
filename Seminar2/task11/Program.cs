// 11. Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000); // 100, 999
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit3 = number % 10;
int digit1 = number / 100;
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
// int res = digit 1 * 10 + digit3;
Console.Write($"{digit1}{digit3}");