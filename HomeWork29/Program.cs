// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// РЕШЕНИЕ ЧЕРЕЗ РАНДОМ
// int[] array = GetBinaryArray(8);
// Console.WriteLine($" [ {String.Join(" ,", array)} ] ");

// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(100);
//     }

//     return result;
// }




// РЕШЕНИЕ ЧЕРЕЗ ВВОД МАССИВА С КЛАВИАТУРЫ

Console.Write("Введите 8 чисел, разделенных запятой:\t");
string numbers = Console.ReadLine();

numbers = numbers + ",";    // дополнительня запятая для обозначения конца строки


string DelSpaces(string series)  // функция удаления пробелов из строки 
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}


void СheckNumbers(int series)   //  функция  проверки на правильность ввода 
{
    if (series == '0' || series == '1' || series == '2'
        || series == '3' || series == '4' || series == '5' || series == '6'
        || series == '7' || series == '8' || series == '9' || series == ',')
    { }
    else
    {
        Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");
    }
}


int[] ArrayOfNumbers(string seriesNew)    // функция  создания и заполнения массива из строки
{
    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumbers(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray(); // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
}

// функция  вывода массива на печать 
// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 0;
//     Console.Write("[");
//     while (index < count)
//     {
//         Console.Write(coll[index]);
//         index++;
//         if (index < count)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }


string seriesNew = DelSpaces(numbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

// PrintArry(arrayOfNumbers);

Console.WriteLine($" [ {String.Join(" ,", arrayOfNumbers)} ] ");