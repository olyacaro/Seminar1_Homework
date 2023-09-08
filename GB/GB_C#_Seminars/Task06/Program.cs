// Наишите программу, которая на вход принимает число и выдает,
// является ли число четным (делиться ли оно на два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число ");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum%2 == 0)
    Console.WriteLine("Число четное ");
else
    Console.WriteLine("Число нечетное ");
