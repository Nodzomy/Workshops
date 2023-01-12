// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum(int s)
{

    int summ = 0;
    for (int i = 0; i <= s; i++)
    {
        summ += i;
    }
    return summ;
}

Console.WriteLine("Ведите чисто А ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма = {Sum(a)}");
