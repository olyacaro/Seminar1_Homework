// Напишите программу, которая на вход принимает 2 числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> да

Console.WriteLine("Введите число №1: ");
string strNum1 = Console.ReadLine();
int Num1 = Convert.ToInt32(strNum1);
Console.WriteLine("Введите число №2: ");
string strNum2 = Console.ReadLine();
int Num2 = Convert.ToInt32(strNum2);
int sqr2 = Num2 * Num2;
if(Num1 == sqr2)
{
    Console.WriteLine("Правда");
}
else
{
    Console.WriteLine("Ложь");
}