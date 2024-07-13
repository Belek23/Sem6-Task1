// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string CharsToString(char[] chars)
{
    string result = string.Empty;
    for (int i = 0; i < chars.Length; i++)
    {
        result += chars[i];
    }
    return result;
}

char[] chars = { 'a', 'b', 'c', 'd', '@' };

System.Console.WriteLine(CharsToString(chars));
