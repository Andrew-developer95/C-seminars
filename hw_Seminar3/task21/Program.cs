// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
//done

Console.WriteLine("Введите координату точки А по оси Х: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по оси Z: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"{res:f2}");