//Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет.

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(number);
if (text.Length > 2){
  Console.WriteLine("третья цифра -> " + text[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}