// // Создание и вывод массива

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

// int[] CreateArray()
// {
// Console.WriteLine("Введите количество элементов массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// Console.WriteLine($"Введите {i+1} элемент массива");
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }

// Выводим массив на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.




// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sumPos = 0;
// int sumNeg = 0;


// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0) sumPos += myArray[i];
//     else sumNeg += myArray[i];
// }

// Console.WriteLine($" Сумма положительных чисел {sumPos} ");
// Console.WriteLine($" Сумма отрицательных чисел {sumNeg} ");



// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] Input()
// {
//     Console.WriteLine("введите размерность массива");
//     int n = int.Parse(Console.ReadLine());
//     int[] array = new int[n];
//     for (int i = 0; i < n; ++i)
//     {
//         Console.Write($"Элемент массива[{i + 1}]= ", i);
//         array[i] = int.Parse(Console.ReadLine());
//     }
//     return array;
// }

// void Print(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) Console.Write("{0} ", array[i]);
//     Console.WriteLine();
// }

// static void Change(int[] array)
// {
//     for (int i = 0; i < array.Length; ++i)
//         array[i] = array[i] * -1;
// }

// int[] myArray = Input();
// Console.WriteLine($"Исходный массив:");
// Print(myArray);

// Change(myArray);
// Console.WriteLine("Измененный массив:");
// Print(myArray);



// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int findNumber = 6;
// int[] array = CreateRandomArray(10, 0, 20);
// ShowArray(array);
// Console.WriteLine($"[{String.Join(", ", array)}]->{IsNumberExsist(array, findNumber)}");

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool IsNumberExsist(int[] array, int number)
// {
//     foreach (var item in array)
//     {
//            if(item == number)return true;
//     } 
//     return false;
//     }




// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] array = CreateRandomArray(7, 0 ,9);
ShowArray(array);
Console.WriteLine($"[{String.Join(" ,",array)}] -> {String.Join(" ,",GetDivineArray(array))}");

int[] GetDivineArray(int[] array)
    {
        int size = (array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1);
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            if (i != array.Length - i - 1)
                newArray[i] = array[i] * array[array.Length - i - 1];
            else newArray[i] = array[i];
        }
        return newArray;
    }




// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] array = CreateRandomArray(123, 0, 200);
// ShowArray(array);
// Console.WriteLine($"В рандомном массиве из 123 элементов найдено {GetNumberInRange(array, 10, 99)} элементов в промежутке от 10 до 99");

// int GetNumberInRange(int[] array, int min, int max)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i] <= max) result++;
//     }
//     return result;
// }



