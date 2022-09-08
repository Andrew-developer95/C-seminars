// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit7 = number % 7;
int digit23 = number % 23;
if (digit7 == 0 && digit23 == 0)
{
  Console.WriteLine("Число кратно 7 и 23");
}
else
{
  Console.WriteLine("Число не кратно 7 и 23");
}