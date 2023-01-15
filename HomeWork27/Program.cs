// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Ведите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр в числе {numberA} будет равна {Sum(numberA)}");

int Sum(int chislo)
{
    int result = chislo % 10;
    while (chislo / 10 != 0)
    {
        chislo = chislo / 10;
        result += chislo % 10;
    }
    return result;

}