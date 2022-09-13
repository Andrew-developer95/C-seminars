// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int AtoB(int numberA, int numberB)
{
  int result = 1;
  for (int i = 1; i <= numberB; i++)
  {
    result = result * numberA;
  }
  return result;
}

int numberA = ReadNumber("Введите число A: ");
int numberB = ReadNumber("Введите число B: ");
int AtoBDone = AtoB(numberA, numberB);
Console.WriteLine($"Число А в степени В равнаяется = {AtoBDone}");
//int result = Math.Pow(numberA, numberB);