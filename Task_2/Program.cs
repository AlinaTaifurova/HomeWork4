/*Задача 2: 
Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


Console.Write("Введите число и я покажу сумму цифр этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{

    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = number % 10;
        result = result + advance;
        number = number / 10;
    }
    return result;
}
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр: " + sumNumber);