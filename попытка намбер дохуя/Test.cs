using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace попытка_намбер_дохуя
{
    public class Test
    {
        public static int[] mas(int[] mas, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, m + 1);
                Console.Write(mas[i] + " ");
            }
            return mas;
        }
    }
}
