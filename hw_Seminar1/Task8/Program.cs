//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
// done

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentValue = 2;

while (currentValue <= number)
{
  Console.Write(currentValue + " ");
  currentValue += 2; //currentValue = currentValue + 2 
}