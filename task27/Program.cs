// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе
//452 -> 11
//82 -> 10
//9012 -> 12
using static System.Console;
Clear();
Write("Введите число:A =");
int numberA = int.Parse(ReadLine());
int sum = GetSum(numberA);
WriteLine($"Сумма цифр в числе {numberA} равна {sum}");



int GetSum(int numberA)
{
    int counter = Convert.ToString(numberA).Length;
    int advance = 0;
    int result = 0;
    for(int i = 0; i<counter; i++)
    {
        advance = numberA - numberA %10;
        result = result + (numberA - advance);
        numberA = numberA/10;
    }
    return result;

}