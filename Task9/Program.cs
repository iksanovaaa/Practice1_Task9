using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            bool end = false;
            do
            {
                int n = rnd.Next(0, 20);
                Console.WriteLine("Количество элементов в списке: " + n);
                MyList l1 = new MyList();
                l1.Create(n, 1);
                l1.Show();
                l1.Count1();
                l1.Count2();
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
