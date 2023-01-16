// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Ведите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Stepen(int chislo, int step)
{
    if step == 0 return 1;
    int result = chislo;
    for (int i = 1; i < step; i++)
    {
        result *= chislo;
    }
    return result;
}

Console.Write($"Число {numberA} в степени {numberB}  будет равно {Stepen(numberA, numberB)}");