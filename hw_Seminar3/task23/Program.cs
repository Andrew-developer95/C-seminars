// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
//done

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
  for (int i = 1; i <= n; i++)
  {
    Console.Write(i * i * i + " ");
  }
}
else
{
  Console.WriteLine("N должно быть больше 0!");
}
