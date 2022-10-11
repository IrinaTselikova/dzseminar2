/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

void GetSecondNumber ()
{
    int newNumber = (new Random()).Next(100, 1000);
    string numberStr = newNumber.ToString();
    int result = int.Parse(numberStr[1].ToString());
    Console.WriteLine($"{newNumber} -> {result}");
}

GetSecondNumber();