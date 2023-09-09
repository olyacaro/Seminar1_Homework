// Напишите программу, которая принимает число на вход и выдает его квадрат
// (число, умноженное само на себя).

Console.Write("Введите число = ");
string strNum = Console.ReadLine(); //"789"
int num = int.Parse(strNum); //789
int sqr = num * num;
Console.WriteLine(sqr);