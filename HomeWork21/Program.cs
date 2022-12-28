// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double askPoint(string coordinate, string point)
{
    Console.Write($"Введите {point}.{coordinate}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double calculate(double x1, double x2, double y1, double y2, double z1, double z2) 
{
    return Math.Sqrt(
        Math.Pow((x2-x1), 2) + 
        Math.Pow((y2-y1), 2) + 
        Math.Pow((z2-z1), 2)
    );
}

double x1 = askPoint("x", "A");
double y1 = askPoint("y", "A");
double z1 = askPoint("z", "A");
double x2 = askPoint("x", "B");
double y2 = askPoint("y", "B");
double z2 = askPoint("z", "B");

double pointsDistance = Math.Round(calculate(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Расстояние между A и B равно {pointsDistance}");