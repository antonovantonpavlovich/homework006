/*
Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.WriteLine("Ввели не корректное число. Повторите ввод");
}
}

return result;
}

double b1 = GetNumber ("Введите координат b1: ");
double k1 = GetNumber ("Введите координат k1: ");
double b2 = GetNumber ("Введите координат b2: ");
double k2 = GetNumber ("Введите координат k2: ");

var x = (b1-b2)/(k2-k1);
var y = k2 * x + b2;
   

Console.WriteLine($"({x}; {y})");

