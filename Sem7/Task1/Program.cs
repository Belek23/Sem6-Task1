// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// Указание: использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumOfDigits(int num)
{
    if (num > 0)
    {
        return num % 10 + SumOfDigits(num / 10);
    }
    return 0;
}
System.Console.WriteLine(SumOfDigits(123));
