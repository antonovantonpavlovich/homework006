/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine ("Введите числа через пробел");
string [] strArray = Console.ReadLine().Split(' ');

int [] result = new int[strArray.Length];
for (int i = 0; i < result.Length; i++)
{
    result[i] = int.Parse(strArray[i]);
} 
Console.WriteLine(string.Join(' ', result));

int GetMax (int[] array)
{
int max = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] > 0)
max++;
}

return max;
}

int max = GetMax (result);
Console.WriteLine(max);