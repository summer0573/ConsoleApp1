using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private const int CHAR_STATE_TOTAL = 3;
        private const int CHAR_STATE1 = 0;
        private const int CHAR_STATE2 = 1;
        private const int CHAR_STATE3 = 2;
        private const int ROW = 3;
        private const int COL_START = 1;
        private const int COL_END = 50;
        static void Main(string[] args)
        {
            int x = COL_START;
            
             while (x > COL_END) {
                Console.Clear();
                Console.SetCursorPosition(x, ROW);
                if(x % 3 == 0)
                {
                    Console.WriteLine("__@");
                } else if (x % 3 == 1)
                {
                    Console.WriteLine("^__^@");
                } else
                {
                    Console.WriteLine("^__@");
                }
                Thread.Sleep(1000);
                x++;
            }

            switch (x % CHAR_STATE_TOTAL) {
                case CHAR_STATE1: Console.WriteLine("__@");
                    break;
                case CHAR_STATE2: Console.WriteLine("^__^@");
                    break;
                case CHAR_STATE3: Console.WriteLine("^__@");
                    break;
            }
            Thread.Sleep(1000);
            x++;

        }
    }
}
