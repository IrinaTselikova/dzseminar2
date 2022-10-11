/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void GetNumber (int number)
{
    if (number>100)
    {
    string numeric=number.ToString();
    int result=int.Parse(numeric[2].ToString());
    Console.WriteLine($"Третья цифра {result}");
    }
    else
    Console.WriteLine("Третьей цифры нет");
}

GetNumber(351123);