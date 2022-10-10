/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int GetNumber (int min, int max)
{
    Random rnd = new Random();
    int result = rnd.Next(min, max);
    return result;
}

int GetSecondNumber (int result)
{
   string numericAsString = result.ToString();
   int resultString = int.Parse(numericAsString[2].ToString());
   return resultString;
}

int number = GetNumber(100, 1000);
int number2 = GetSecondNumber (resultString);
Console.WriteLine($"{number} ->{number2}");
