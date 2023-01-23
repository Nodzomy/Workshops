// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Write("Введите количество строк массива: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {numberM}, n = {numberN}.");
int[,] matr = new int[numberM, numberN];
FillMatrixRundom(matr);

// Заполняем матрицу
void FillMatrixRundom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); //[1;10)
        }
    }

}


WriteArrayInt(matr);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < numberN; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < numberM; j++)
    {
        arithmeticMean += matr[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / numberM, 1);
    Console.WriteLine($"столбца № = {i + 1} {arithmeticMean}");
}



void WriteArrayInt(int[,] array)
{
    for (int i = 0; i < numberM; i++)
    {
        for (int j = 0; j < numberN; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
