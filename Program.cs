using System.Diagnostics;
using static System.Console;

namespace KursovayaRabota
{
    internal class Program
    {
        public static int TryParseToInt32(string? input)
        {
            try
            {
                return Convert.ToInt32(input);
            } 
            catch
            {
                WriteLine("===| Ошибка! Было введено не число. Программу необходимо перезапустить вручную!");
                return 0;
            }
        }

        public static char TryParseToChar(string? input)
        {
            try
            {
                return Convert.ToChar(input);
            }
            catch
            {
                WriteLine("===| Ошибка! Был введен не символ. Программу необходимо перезапустить вручную!");
                Process.GetCurrentProcess().Kill();
                return ' ';
                
            }
        }

        public static string IfStringNull(string? s)
        {
            if (s == "")
            {
                WriteLine("===| Ошибка! Входные параметры были пустыми. Программу необходимо перезапустить вручную!");
                Process.GetCurrentProcess().Kill();
            } 
            return s;
        }

        static void Main(string[] args)
        {
            int ops = 0;
            int input;
            int operation = 8;

            do {
                Clear();
                ops = 0;
                WriteLine("============================================================================");
                WriteLine("===| Добро пожаловать в программу реализации строк и операций над ними! |===");
                WriteLine("============================================================================");
                WriteLine($"===| {++ops}. Операции над строками             |  Класс Strings              |===");
                WriteLine($"===| {++ops}. Операции c классом StringBuilder  |  Класс StringsBuilder       |===");
                WriteLine($"===| {++ops}. Регулярные выражения              |  Класс StringsBuilder       |===");
                WriteLine("============================================================================");
                ops = 0;
                WriteLine($"===| Доступные операции над строками:     |  Название операций:         |===");
                WriteLine($"===| {++ops}. Объединение строк                 |  Операция: Concat           |===");
                WriteLine($"===| {++ops}. Объединение строк                 |  Операция: Join             |===");
                WriteLine($"===| {++ops}. Сравнение строк                   |  Операция: Compare          |===");
                WriteLine($"===| {++ops}. Поиск в строке                    |  Операция: IndexOf          |===");
                WriteLine($"===| {++ops}. Поиск в строке                    |  Операция: LastIndexOf      |===");
                WriteLine($"===| {++ops}. Поиск в строке                    |  Операция: StartsWith       |===");
                WriteLine($"===| {++ops}. Поиск в строке                    |  Операция: EndsWith         |===");
                WriteLine($"===| {++ops}. Разделение строк                  |  Операция: Split            |===");
                WriteLine($"===| {++ops}. Обрезка нач. или конц. символов   |  Операция: Trim             |===");
                WriteLine($"===| {++ops}. Обрезка строки                   |  Операция: Substring        |===");
                WriteLine($"===| {++ops}. Вставка                          |  Операция: Insert           |===");
                WriteLine($"===| {++ops}. Удаление строк                   |  Операция: Remove           |===");
                WriteLine($"===| {++ops}. Замена                           |  Операция: Replace          |==="); 
                WriteLine($"===| {++ops}. Смена регистра                   |  Операция: ToUpper()        |===");
                WriteLine($"===| {++ops}. Смена регистра                   |  Операция: ToLower()        |===");
                WriteLine("============================================================================");
                WriteLine($"===| Операции c классом StringBuilder:    |  Название операций:         |===");
                WriteLine($"===| {++ops}. Создание StringBuilder           |  Операция: new              |===");
                WriteLine("============================================================================");
                WriteLine($"===| Регулярные выражения:                |  Название операций:         |===");
                WriteLine($"===| {++ops}. Проверка на соотв. рег. выраж.   |  Операция: regex.Matches    |===");
                WriteLine($"===| {++ops}. Замена соотв. рег. выраж.        |  Операция: regex.Replace    |===");
                WriteLine("============================================================================");
                WriteLine($"===| 0. Закрыть программу                                               |===");
                WriteLine("============================================================================");
                Write("===| Выберите номер необходимой операции из доступных: "); input = TryParseToInt32(ReadLine());
                

                if (input == 0) Process.GetCurrentProcess().Kill();

                operation = input;

            } while (input < 0 || input > ops);


            string s1 = " hello my ",
                   s2 = " world ",
                   separator = "",
                   subs = "lo",
                   oldValue = " ",
                   newValue = "$";

            int startIndex = 2, lenght = 3;

            Clear();
            switch (operation)
            {
                case 1:
                    Write("===| Введите первую строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите вторую строку: "); s2 = IfStringNull(ReadLine());
                    Strings.Concat(s1, s2);
                    break;
                case 2:
                    Write("===| Введите разделитель: "); separator = IfStringNull(ReadLine());
                    Write("===| Введите количество строк: "); int n = TryParseToInt32(ReadLine());
                    string[] strs = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("===| Введите строку №{0}:\r\n    ", i + 1);
                        strs[i] = IfStringNull(ReadLine());
                    }
                    Strings.Join(separator, strs);
                    break;
                case 3:
                    Write("===| Введите первую строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите вторую строку: "); s2 = IfStringNull(ReadLine());
                    Strings.Compare(s1, s2);
                    break;
                case 4:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите подстроку: "); subs = IfStringNull(ReadLine());
                    Strings.IndexOf(s1, subs);
                    break;
                case 5:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите подстроку: "); subs = IfStringNull(ReadLine());
                    Strings.LastIndexOf(s1, subs);
                    break;
                case 6:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите подстроку: "); subs = IfStringNull(ReadLine());
                    Strings.StartsWith(s1, subs);
                    break;
                case 7:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите подстроку: "); subs = IfStringNull(ReadLine());
                    Strings.EndsWith(s1, subs);
                    break;
                case 8:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите разделитель: "); separator = IfStringNull(ReadLine());
                    Strings.Split(s1, separator);
                    break;
                case 9:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите количество символов: "); int x = TryParseToInt32(ReadLine());
                    if (x == 0)
                    {
                        Strings.Trim(s1);
                    } 
                    else
                    {
                        char[] chars = new char[x];
                        for (int i = 0; i < x; i++)
                        {
                            Console.Write("===| Введите символ №{0}:\r\n    ", i + 1);
                            chars[i] = TryParseToChar(ReadLine());
                        }
                        Strings.Trim(s1, chars);
                    }
                    break;
                case 10:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите стартовый индекс: "); startIndex = TryParseToInt32(ReadLine());
                    Write("===| Введите длину (если её нет, введите 0): "); lenght = TryParseToInt32(ReadLine());
                    if (lenght == 0)
                    {
                        Strings.Substring(s1, startIndex);
                    }
                    else
                    {
                        Strings.Substring(s1, startIndex, lenght);
                    }
                    break;
                case 11:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите стартовый индекс: "); startIndex = TryParseToInt32(ReadLine());
                    Write("===| Введите подстроку: "); subs = IfStringNull(ReadLine());
                    Strings.Insert(s1, startIndex, subs);
                    break;
                case 12:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите стартовый индекс: "); startIndex = TryParseToInt32(ReadLine());
                    Write("===| Введите длину (если её нет, введите 0): "); lenght = TryParseToInt32(ReadLine());
                    if (lenght == 0)
                    {
                        Strings.Remove(s1, startIndex);
                    }
                    else
                    {
                        Strings.Remove(s1, startIndex, lenght);
                    }
                    break;
                case 13:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Write("===| Введите старое значение: "); oldValue = IfStringNull(ReadLine());
                    Write("===| Введите новое значение: "); newValue = IfStringNull(ReadLine());
                    Strings.Replace(s1, oldValue, newValue);
                    break;
                case 14:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Strings.ToUpper(s1);
                    break;
                case 15:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    Strings.ToLower(s1);
                    break;
                case 16:
                    Write("===| Введите строку: "); s1 = IfStringNull(ReadLine());
                    StringsBuilder.Hello(s1);
                    break;
                case 17:
                    RegexClass.FindRegex();
                    break;
                case 18:
                    RegexClass.ReplaceRegex();
                    break;
            }
        }
    }
}