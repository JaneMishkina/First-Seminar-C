// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int GetNumber()
{ 
Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = GetNumber();
int i = 0;

while ( i < N)

{
i+=1;
if (i%2==0)
{
Console.Write(i+ ",");
}
}
