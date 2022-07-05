//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53.

void distancein3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double m = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine($"получили следующие координаты ({x1},{y1},{z1}) ({x2},{y2},{z2})");
Console.WriteLine("расстояние между 2-мя точками в 3D равно:");
Console.WriteLine(m);
}

distancein3D(2, 7, 9, -1, 4, 19);