// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int a)
{
  
  if (a <= 0)
  {
    Console.WriteLine("Введите число больше 0");
    return -1;
    //break; - как грамотно его добавить?  если ввести 0 и меньше пишет "Сумма цифр в числе = -1"; убрать return не поможет)                    
  }
  
  int s = 0;
  while (a > 0)
  {
    s = s + a % 10;
    a = a / 10;
  }
  return s;
}

int number = ReadNumber("Введите число:");
int summa = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе = {summa}");

