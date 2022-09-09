// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// done



Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number / 10000;
int digit2 = number / 1000;
int digit4 = number / 10;
int digit5 = number % 10;

if (number < 10000)
{
  Console.WriteLine("Введите пятизначное число!");
}

if (number > 10000 && digit1 == digit5 && digit2 % 10 == digit4 % 10) 
{
  Console.WriteLine("Число является палиндромом, поздравляю! :D");
}

if (digit1 != digit5)
{
  Console.WriteLine("Число не является палиндромом, печаль!((");

}



// Боль и страдания :D
// Console.WriteLine("Введите число:")
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// int number4 = Convert.ToInt32(Console.ReadLine());
// int number5 = Convert.ToInt32(Console.ReadLine());

// if (number > 10000)
// {
//   number1 == 0 && number5 == 0;
//   number2 == 0 && number4 == 0;
//   number3 == 0;

// }
// else
// {
//   Console.WriteLine("Введите пятизначное число!")
// }



// if (number > 10000)
// {
//   number1 == 0 && number5 == 0;
//   number2 == 0 && number4 == 0;
//   number3 == 0;

// }
// else
// {
//   Console.WriteLine("Введите пятизначное число!")
// }

// while (number1 == 0 && number5 == 0);



// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int digit1 = number / 10000;
// // int digit2 = number / 1000;
// // int digit3 = number / 100;
// // int digit4 = number / 10;
// int digit5 = number % 10;

// if (number < 10000)
// {
//   Console.WriteLine("Введите пятизначное число!");
// }

// if (number > 10000)
// {
//   while (digit1 == digit5)
//     Console.WriteLine("Число является палиндромом, поздравляю! :D");
// }



// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int digit1 = number / 10000;
// // int digit2 = number / 1000;
// // int digit3 = number / 100;
// // int digit4 = number / 10;
// int digit5 = number % 10;

// if (number < 10000)
// {
//   Console.WriteLine("Введите пятизначное число!");
// }

// while (number > 10000)
// {
//   number = number / 10000;

// }
// if (number > 10000)
// {
//   Console.WriteLine("Число является палиндромом, поздравляю! :D");

// }
