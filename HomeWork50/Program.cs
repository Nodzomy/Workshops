// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {numberM}, n = {numberN}.");

double[,] array = new double[numberM, numberN];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < numberM; i++)
    {
        for (int j = 0; j < numberN; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < numberM; i++)
    {
        for (int j = 0; j < numberN; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("\nВведите координаты позиции элемента, разделенные запятой:\n");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if (position[0] <= numberM
 && position[1] <= numberN
 && position[0] >= 0
 && position[1] >= 0)
{
    double result = array[position[0] - 1, position[1] - 1];
    Console.Write($"Значение элемента: {Math.Round(result, 1)}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}

string RemovingSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output += input[i];
        }
    }
    return output;
}
