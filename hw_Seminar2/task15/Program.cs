// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//done

// ПОСМОТРИТЕ ПОЖАЛУЙСТА СТРОКУ 23

Console.WriteLine("Введите цифру:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}


// Почему не работает код? :D (Догадка такая, что int работает с числами, а я его пытаюсь обозначить как string и пишу условие что if  6 == 6, которое
//программа не понимает, ведь 6 не может быть не равно 6 аахах ))

// Console.WriteLine("Введите цифру:");
// int number = Convert.ToInt32(Console.ReadLine());
// int sat = 6;
// int sun = 7;

// if (sat == 6 || sun == 7)
// {
//   Console.WriteLine("Да");
// }
// else
// {
//   Console.WriteLine("Нет");
// }