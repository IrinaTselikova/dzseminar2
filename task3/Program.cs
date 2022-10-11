/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

void GetNum (int number)
{
    if (number>=1 && number <=5)
    {
        Console.WriteLine($"{number} -> no");
        return;
    }

    if (number>=6 && number <=7)
    {
        Console.WriteLine($"{number} -> yes");
        return;
    }

    else
    {
    Console.WriteLine("Введено неверное число");
    }
}

GetNum (7);








