Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <=999)
{
    int lastNumber = number % 10;
    Console.Write($"Последняя цифра числа- {lastNumber}");
} 
else Console.WriteLine ("Ошибка ввода! Введите трехзначное число.");