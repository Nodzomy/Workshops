// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Clear();
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

void WriteArray (double[,] array){
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
