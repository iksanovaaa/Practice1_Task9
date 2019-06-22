using System;
using System.Diagnostics;

namespace Task9
{
    public class Program
    {
        public static Random rnd = new Random();
        public static void Main(string[] args)
        {
            bool end = false;
            do
            {
                int n = rnd.Next(0, 100);
                Console.WriteLine("Количество элементов в списке: " + n);
                MyList l1 = new MyList();
                l1.Create(n, 1);
                l1.Show();
                TimeSpan time;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                l1.Count1();
                sw.Stop();
                time = sw.Elapsed;
                Console.WriteLine("Время подсчета рекурсивным методом: " + time.ToString());
                sw = new Stopwatch();
                sw.Start();
                l1.Count2();
                sw.Stop();
                time = sw.Elapsed;
                Console.WriteLine("Время подсчета нерекурсивным методом: " + time.ToString());
                end = CheckKey();
            } while (!end);
        }

        //выход из программы или формирование новой последоватльности
        public static bool CheckKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            bool next, end = false;
            int keyNum;
            Console.WriteLine("Для выхода из программы нажмите Esc, для генерации другого списка нажмите Enter.");
            do
            {
                keyNum = Console.ReadKey().KeyChar;
                next = (keyNum == 27) || (keyNum == 13);
            } while (!next);
            if (keyNum == 27) end = true;
            Console.Clear();
            Console.ResetColor();
            return end;
        }
    }
}
