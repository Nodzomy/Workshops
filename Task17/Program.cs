void Show(int coor_x, int coor_y)
{
   if (coor_x == 0 || coor_y == 0)
{
    Console.WriteLine("Не возможно определить четверть!");
}

else if (coor_x > 0 && coor_y > 0)
{
    Console.WriteLine("1я четверть.");
}
else if (coor_x < 0 && coor_y > 0)
{
    Console.WriteLine("2я четверть.");
}
else if (coor_x < 0 && coor_y < 0)
{
    Console.WriteLine("3я четверть.");
}
else if (coor_x > 0 && coor_y < 0)
{
    Console.WriteLine("4я четверть.");
}
}

Console.WriteLine("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Show(x, y);

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void printQuarter(int a, int b)
// {
// if (a>0 && b>0)
// {
// Console.WriteLine ("Первая четверть");
// }
// else if (a<0 && b>0)
// {
// Console.WriteLine ("Вторая четверть");
// }
// else if (a<0 && b<0)
// {
// Console.WriteLine ("Третья четверть");
// }
// else if (a>0 && b<0)
// {
// Console.WriteLine ("Четвертая четверть");
// }
// else
// {
// Console.WriteLine ("Определить четверть не возможно");
// }
// }
// int returnQuarter (int a, int b)
// {
// if (a>0 && b>0)
// {
// return 1;
// }
// else if (a<0 && b>0)
// {
// return 2;
// }
// else if (a<0 && b<0)
// {
// return 3;
// }
// else if (a>0 && b<0)
// {
// return 4;
// }
// else
// {
// return 0;
// }
// }


// Console.WriteLine ("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// // printQuarter(x, y);

// Console.WriteLine(returnQuarter(x,y));
// int quarter = returnQuarter(x,y);
// Console.WriteLine($"Четверть: {quarter}");





 // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void printQuarter(int a, int b)
// {
// if (a>0 && b>0)
// {
// Console.WriteLine ("Первая четверть");
// }
// else if (a<0 && b>0)
// {
// Console.WriteLine ("Вторая четверть");
// }
// else if (a<0 && b<0)
// {
// Console.WriteLine ("Третья четверть");
// }
// else if (a>0 && b<0)
// {
// Console.WriteLine ("Четвертая четверть");
// }
// else
// {
// Console.WriteLine ("Определить четверть не возможно");
// }
// }


// int returnQuarter (int a, int b)
// {
// if (a>0 && b>0)
// {
// return 1;
// }
// else if (a<0 && b>0)
// {
// return 2;
// }
// else if (a<0 && b<0)
// {
// return 3;
// }
// else if (a>0 && b<0)
// {
// return 4;
// }
// else
// {
// return 0;
// }
// }


// Console.WriteLine ("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// // printQuarter(x, y);

// Console.WriteLine(returnQuarter(x,y));
// int quarter = returnQuarter(x,y);
// Console.WriteLine($"Четверть: {quarter}");

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.Write("Введите номер четверти: ");
// int quarter=int.Parse(Console.ReadLine());

// switch (quarter)
// {
// case 1:
// {
// Console.WriteLine("x>0 y>0");
// break;
// }
// case 2:
// {
// Console.WriteLine("x<0 y>0");
// break;
// }
// case 3:
// {
// Console.WriteLine("x<0 y<0");
// break;
// }
// case 4:
// {
// Console.WriteLine("x>0 y<0");
// break;
// }

// default:
// {
// Console.WriteLine("Введена неправильная четверть");
// break;
// }
// }

//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

// Console.WriteLine($"d={d:f5}");





//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу квадратов чисел от 1 до N.
// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
// Console.Write($"{i*i} ");
// }