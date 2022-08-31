using System;

class Program
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1] + "."); // Чтобы вывести последний элемен с точкой    }
        // Console.WriteLine(""); исскуственно с новой строки
    }
    static void SelectDayWeek()
    {
        string[] namesDayWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        WriteSelect(namesDayWeek);
        Console.WriteLine("Укажите день недели ");
        int indexDayWeek = Convert.ToInt32(Console.ReadLine());
        if (indexDayWeek < 6)
            Console.WriteLine("Является выходным? Ответ: нет  ");
        if (indexDayWeek > 5)
            Console.WriteLine("Является выходным? Ответ: да  ");
    }
    static void Main(string[] args)
    {
        SelectDayWeek();
    }
}