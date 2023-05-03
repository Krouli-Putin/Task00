// Код, который принимает на вход 3 числа 
// На выходе выдает наибольшее (Вроде ничем не отличается от 1 задания)
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine($"Максимальное из этих чисел = {max}");