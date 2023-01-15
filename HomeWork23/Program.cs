//Задача 23: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Сколько кубов должно быть в таблице: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"{number} ->");

int counter = 1;
bool isFirst = true;

while (counter <= number)
{
    if (!isFirst)
    {
        Console.Write(",");
    }

    int result = Convert.ToInt32(Math.Pow(counter, 3));

    Console.Write($" {result}");

    counter++;
    isFirst = false;
}
