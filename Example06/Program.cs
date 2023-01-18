// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
//-3 -> нет
//7 -> нет

int GetNumber()
{ 
Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = GetNumber();

if (number % 2==0)

{
Console.Write("да ");

}

else
{
   Console.Write("нет "); 
}
