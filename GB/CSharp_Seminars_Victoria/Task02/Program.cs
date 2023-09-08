//Вывести на одной строке три числа от пользователя с одним пробелом между ними.

System.Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели числа: {num1} {num2} {num3}");