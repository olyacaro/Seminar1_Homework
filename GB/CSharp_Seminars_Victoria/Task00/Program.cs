/*
Составить программу вывода на экран числа, вводимого с клавиатуры. 
Выводимому числу должно предшествовать сообщение «Вы ввели число».
*/

/*System.Console.WriteLine("Вы ввели число: ");
int num = Convert.ToInt32(Console.ReadLine());*/

Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Вы ввели число: "+num);
Console.WriteLine($"Вы ввели число: {num}");