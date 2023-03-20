string paragraph = "phpMyAdmin is a free software tool written in PHP, intended to handle the administration of MySQL over the Web. phpMyAdmin supports a wide range of operations on MySQL and MariaDB. Frequently used operations (managing databases, tables, columns, relations, indexes, users, permissions, etc) can be performed via the user interface, while you still have the ability to directly execute any SQL statement.";

string[] GetPrgAsArrWord(string str)
{
    // удаляем запятые и точки из текста
    str = str.Replace(",", string.Empty);
    str = str.Replace(".", string.Empty);
    return str.Split(' '); // возвращаем в массив слов
}

System.Console.WriteLine(GetPrgAsArrWord(paragraph));