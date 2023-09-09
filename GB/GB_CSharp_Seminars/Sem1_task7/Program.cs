// Напишите программу, которая на вход принимает трехзначное число
// и на выходе показыват последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2

Console.Write("Введи число; ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 1000)
{
    int newNum = num % 10;
    Console.WriteLine(newNum);
}
else
{
    Console.WriteLine("Неверное число!");
}