using static System.Console;

namespace KursovayaRabota
{
    internal class Strings
    {
        public static void Concat(string s1, string s2)
        {
            string result = string.Concat(s1, s2);
            WriteLine("===| Вывод: " + result);
        }

        public static void Join(string separator, string[] values)
        {
            string result = string.Join(separator, values);
            WriteLine("===| Вывод: \r\n    " + result);
        }
           
        public static void Compare(string s1, string s2)
        {
            int result = string.Compare(s1, s2);
            if (result < 0)
            {
                WriteLine("===| Первая строка стоит перед второй строкой");
            }
            else if (result > 0)
            {
                WriteLine("===| Первая строка стоит после второй строки");
            }
            else
            {
                WriteLine("===| Строки идентичны");
            }
        }

        public static void IndexOf(string s1, string subs)
        {
            int result = s1.IndexOf(subs);
            WriteLine("===| Вывод: " + result);
        }

        public static void LastIndexOf(string s1, string subs)
        {
            int result = s1.LastIndexOf(subs);
            WriteLine("===| Вывод: " + result);
        }

        public static void StartsWith(string s1, string subs)
        {
            bool result = s1.StartsWith(subs);
            WriteLine("===| Вывод: " + result);
        }

        public static void EndsWith(string s1, string subs)
        {
            bool result = s1.EndsWith(subs);
            WriteLine("===| Вывод: " + result);
        }

        public static void Split(string s1, string separator)
        {
            string[] results = s1.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            WriteLine("===| Вывод: ");
            foreach (string result in results)
            {
                WriteLine(result);
            }
        }

        public static void Trim(string s1)
        {
            string result = s1.Trim();
            WriteLine("===| Вывод: " + result);
        }

        public static void Trim(string s1, char[]? trim)
        {
            string result = s1.Trim(trim);
            WriteLine("===| Вывод: " + result);
        }

        public static void Substring(string s1, int startIndex)
        {
            try
            {
                string result = s1.Substring(startIndex);
                WriteLine("===| Вывод: " + result);
            }
            catch 
            { 
                WriteLine("===| Ошибка! Стартовый индекс превышает длину строки. Программу необходимо перезапустить вручную!");
            }
        }

        public static void Substring(string s1, int startIndex, int lenght)
        {
            try
            {
                string result = s1.Substring(startIndex, lenght);
                WriteLine("===| Вывод: " + result);
            }
        
            catch 
            { 
                WriteLine("===| Ошибка! Стартовый индекс или длина превышают длину строки. Программу необходимо перезапустить вручную!");
            }
        }

        public static void Insert(string s1, int startIndex, string subs)
        {
            try
            {
                string result = s1.Insert(startIndex, subs);
                WriteLine("===| Вывод: " + result);
            }
            catch
            {
                WriteLine("===| Ошибка! Стартовый индекс превышает длину строки. Программу необходимо перезапустить вручную!");
            }
        }

        public static void Remove(string s1, int startIndex)
        {
            try
            {
                string result = s1.Remove(startIndex);
                WriteLine("===| Вывод: " + result);
            }
            catch
            {
                WriteLine("===| Ошибка! Стартовый индекс превышает длину строки. Программу необходимо перезапустить вручную!");
            }
        }

        public static void Remove(string s1, int startIndex, int lenght)
        {
            try
            {
                string result = s1.Remove(startIndex, lenght);
                WriteLine("===| Вывод: " + result);
            }

            catch
            {
                WriteLine("===| Ошибка! Стартовый индекс или длина превышают длину строки. Программу необходимо перезапустить вручную!");
            }
        }

        public static void Replace(string s1, string oldValue, string newValue)
        {
            string result = s1.Replace(oldValue, newValue);
            WriteLine("===| Вывод: " + result);
        }

        public static void ToUpper(string s1)
        {
            string result = s1.ToUpper();
            WriteLine("===| Вывод: " + result);
        }

        public static void ToLower(string s1)
        {
            string result = s1.ToLower();
            WriteLine("===| Вывод: " + result);
        }
    }
}
