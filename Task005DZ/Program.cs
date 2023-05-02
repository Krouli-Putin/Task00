// 1.Напишите программу которая на вход принмает два числа
// 2. И выдает на вход какое число больше, а какое мешьше
Console.WriteLine("Введите первое число!");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int square = Convert.ToInt32(Console.ReadLine());
if (number > square && number < square && number == square)
{
    Console.WriteLine("большее число {number}, меньшее число: {square}");
}
 else
 {
    Console.WriteLine($"Большее число {number}, меньшее число {square}");
 }





