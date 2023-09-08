/* Напишите программу, которая будет выдавать название дня недели
по заданному номеру
3 -> среда
5 -> пятница.*/

Console.WriteLine("Введи день недели цифрой: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 1)
{
    Console.WriteLine("Сегодня Понедельник");
}
else if (dayWeek == 2)
{
    Console.WriteLine("Сегодня Вторник");
}
else if (dayWeek == 3)
{
    Console.WriteLine("Сегодня Среда");
}
else if (dayWeek == 4)
{
    Console.WriteLine("Сегодня Четверг");
}
else if (dayWeek == 5)
{
    Console.WriteLine("Сегодня Пятница");
}
else if (dayWeek == 6)
{
    Console.WriteLine("Сегодня Суббота");
}
else if (dayWeek == 7)
{
    Console.WriteLine("Сегодня Воскресенье");
}
else
{
    Console.WriteLine("Введи от 1 до 7");
}
