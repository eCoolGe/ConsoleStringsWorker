using System.Diagnostics;
using System.Text;
using static System.Console;

namespace KursovayaRabota
{
    internal class StringsBuilder
    {
        public static void Hello(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            string subs, oldValue, newValue;
            int input, startIndex, lenght;

            while (true) {
                Clear();
                WriteLine("============================================================================");
                WriteLine($"===| Операции c классом StringBuilder:    |  Название операций:         |===");
                WriteLine($"===| 1. Добавить подстроку                |  Операция: Append           |===");
                WriteLine($"===| 2. Вставить подстроку                |  Операция: Insert           |===");
                WriteLine($"===| 3. Удалить опред. кол-во символов    |  Операция: Remove           |===");
                WriteLine($"===| 4. Заменить все вхождения            |  Операция: Replace          |===");
                WriteLine("============================================================================");
                WriteLine($"===| 0. Закрыть программу                                               |===");
                WriteLine("============================================================================");
                WriteLine($"===|                             StringBuilder:                         |===");
                WriteLine("    " + sb);
                WriteLine($"===|                        Длина StringBuilder: {sb.Length}                     |===");
                WriteLine($"===|                       Емкость StringBuilder: {sb.Capacity}                    |===");
                WriteLine("============================================================================");
                Write("===| Выберите номер необходимой операции из доступных: "); input = Program.TryParseToInt32(ReadLine());

                switch (input)
                {
                    case 1:
                        Write("===| Введите подстроку: "); subs = Program.IfStringNull(ReadLine());
                        sb.Append(subs);
                        break;
                    case 2:
                        Write("===| Введите стартовый индекс: "); startIndex = Program.TryParseToInt32(ReadLine());
                        Write("===| Введите подстроку: "); subs = Program.IfStringNull(ReadLine());
                        sb.Insert(startIndex, subs);
                        break;
                    case 3:
                        Write("===| Введите стартовый индекс: "); startIndex = Program.TryParseToInt32(ReadLine());
                        Write("===| Введите длину: "); lenght = Program.TryParseToInt32(ReadLine());
                        try
                        {
                            sb.Remove(startIndex, lenght);
                        }
                        catch
                        {
                            WriteLine("===| Ошибка! Стартовый индекс или длина превышают длину строки. Программу необходимо перезапустить вручную!");
                        }
                        break;
                    case 4:
                        Write("===| Введите старое значение: "); oldValue = Program.IfStringNull(ReadLine());
                        Write("===| Введите новое значение: "); newValue = Program.IfStringNull(ReadLine());
                        sb.Replace(oldValue, newValue);
                        break;
                    case 0:
                        Process.GetCurrentProcess().Kill();
                        break;
                }
            }
        }
    }
}
