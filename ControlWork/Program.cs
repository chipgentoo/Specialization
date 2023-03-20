string paragraph = "phpMyAdmin is a free software tool written in PHP, intended to handle the administration of MySQL over the Web. phpMyAdmin supports a wide range of operations on MySQL and MariaDB. Frequently used operations (managing databases, tables, columns, relations, indexes, users, permissions, etc) can be performed via the user interface, while you still have the ability to directly execute any SQL statement.";

/// <summary>
/// Преобразование текста в массив слов
/// </summary>
/// <param name="str">Текст не определенной длинны</param>
/// <returns>Массив слов</returns>
string[] GetPrgAsArrWord(string str)
{
    // удаляем точки, запятые и скобки из текста
    string[] replaceChar = { ".", ",", "(", ")" }; //добавить по необходимости
    for (int i = 0; i < replaceChar.Length; i++)
    {
        str = str.Replace(replaceChar[i], string.Empty);
    }
    return str.Split(' '); // возвращаем массив слов
}

/// <summary>
/// Поиск слов по их длинне
/// </summary>
/// <param name="str">Массив слов</param>
/// <param name="wordLength">минимальная длинна слова</param>
/// <returns>Массив найденых слов</returns>
string[] FindWordsByLength(string[] str, int wordLength)
{
    string newString = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= wordLength)
        {
            newString = newString + str[i] + " ";
        }
    }
    newString = newString.Trim();
    return newString.Split(" ");
}

// ПРОВЕРКИ
int wordLength = 3; // максимальная длинна искомого слова
Console.WriteLine("Исходный параграф:");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(paragraph);
Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Найденые слова:");
string[] arrayString = FindWordsByLength(GetPrgAsArrWord(paragraph), wordLength);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{string.Join(' ', arrayString)}");
Console.ResetColor();
Console.WriteLine();