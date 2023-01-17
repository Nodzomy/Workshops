// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Введите длину массива:\t");
// int lght = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRealArray();
ShowArray(array);

Console.WriteLine($" [ {String.Join(", ", array)} ] ");
Console.WriteLine($"\n Разница между максимальным и минимальным элементами массива составляет {Diff(array)}");


// double[] CreateRealArray(int N)
// {
//     double[] RandomArray = new double[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().NextDouble();
//     }
//     return RandomArray;
// }


// Задаем массив вручную
double[] CreateRealArray()
{
Console.WriteLine("Введите количество элементов вещественного массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива");
array[i] = Convert.ToDouble(Console.ReadLine());
}
return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Diff(double[] array)
{
    double maxNumber = array[0];
    double minNamber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        if (array[i] < minNamber) minNamber = array[i];
    }
    
    return maxNumber - minNamber;
}



