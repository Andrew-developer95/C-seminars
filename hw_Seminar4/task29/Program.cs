// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Данные вводятся с консоли пользователем

int[] array = new int[8];

int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

//В моем случае как-то можно было код оптимизировать, чтобы он не был таким громоздким? 

int arr1 = ReadNumber("Введите 1-ый элемент массива: ");
array[0] = arr1;
int arr2 = ReadNumber("Введите 2-ой элемент массива: ");
array[1] = arr2;
int arr3 = ReadNumber("Введите 3-ий элемент массива: ");
array[2] = arr3;
int arr4 = ReadNumber("Введите 4-ый элемент массива: ");
array[3] = arr4;
int arr5 = ReadNumber("Введите 5-ый элемент массива: ");
array[4] = arr5;
int arr6 = ReadNumber("Введите 6-ой элемент массива: ");
array[5] = arr6;
int arr7 = ReadNumber("Введите 7-ой элемент массива: ");
array[6] = arr7;
int arr8 = ReadNumber("Введите 8-ой элемент массива: ");
array[7] = arr8;

Console.Write(string.Join(", ", arr1, arr2, arr3, arr4, arr5, arr6, arr7, arr8));

