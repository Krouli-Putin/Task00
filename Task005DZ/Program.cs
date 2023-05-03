// 1.Напишите программу которая на вход принмает два числа
// 2. И выдает на вход какое число больше, а какое мешьше
Console.WriteLine("Введите первое число!"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32(Console.ReadLine()); 
 if (a > b)
{
Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
}
else Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);





