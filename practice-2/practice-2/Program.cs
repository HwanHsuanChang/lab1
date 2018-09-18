using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入矩陣一(輸入空行完成):");
            int[,] x;
            x = new int[10,10];
            string a;
            for(int i = 0;i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j) {
                    a = Console.ReadLine();
                    if (a == null)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("請輸入矩陣二(輸入空行完成):");

            int[,] y;
            y = new int[10,10];

        }//main
    }
}
