//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int GetNumber()
{ 
Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();
int thirdNumber = GetNumber();

int max = firstNumber;
if (secondNumber > max) max =secondNumber;
if (thirdNumber > max) max =thirdNumber;
{
Console.Write("max = ");
Console.WriteLine(max);

}
