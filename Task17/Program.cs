Console.WriteLine("Введите координату Х: ");
int coor_x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
int coor_y = Convert.ToInt32(Console.ReadLine());

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
