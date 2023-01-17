// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива:\t");
int lght = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(lght, -100, 100);
ShowArray(array);
Console.WriteLine($"Сумма четных позиций в дандомном массиве равна{GetNumberInRange(array)}");


int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}




int GetNumberInRange(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result+=array[i];
    }
    return result;
}
