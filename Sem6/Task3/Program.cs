// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int VowelsCount(string str)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

    int vowelCount = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)// skip
        {
            if (str[i] == vowels[j])
            {
                vowelCount++;
                break;
            }
        }
    }
    return vowelCount;
}
Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
string str = Console.ReadLine();
Console.WriteLine($"Количество гласных букв: {VowelsCount(str)}");