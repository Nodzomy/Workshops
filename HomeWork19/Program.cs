// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
        return;
    }

    Console.WriteLine($"ОШИБКА: {number} - не палиндром");
}

if (number.Length == 5)
{   
    CheckingNumber(number);
    return;
}

Console.WriteLine($"Введите правильное число");
