// Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
if (n > 0)
{
  for (int i = 1; i <= n; i++)
  {
    Console.Write(i * i + " ");
  }
}
else
{
  Console.WriteLine("N должно быть больше 0!");
}

// if (n>0)
// {
//   while ( i <= n)
//   {
//     Console.Write(i * i  + " ");
//     i = i + 1;
//   }
// }