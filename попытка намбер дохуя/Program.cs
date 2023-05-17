using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace попытка_намбер_дохуя
{
    public class Program
    {
        
         public static  int[] mas(int[] mas,int n,int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, m + 1);
                Console.Write(mas[i] + " ");
            }
            return mas;
        }

        public static string prov(string m)
        {
            string message="";
            try
            {
                int m1 = int.Parse(m);
                if (m1 < 0)
                {
                    return message = "вы велли отрицательное число";
                }
                if(m1==0)
                {
                    return message = "вы велли 0";
                }
                else return message;
            }
            catch
            {
                message = "вы ввели неправильное значение";
                return message;
            }
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            Console.WriteLine("введите до какого числа вы хотите вывести массив");
            string m = Console.ReadLine();
            Console.WriteLine("введите n");
            string n=Console.ReadLine();
            if(prov(m)=="" && prov(n)=="")
            {

                int m1 = int.Parse(m);
                int n1 = int.Parse(n);
                int[] nums = new int[n1];
                mas(nums, n1, m1);
                Console.WriteLine();
                int[] result = nums.GroupBy(x => x)
                    .OrderBy(g => g.Count()).ThenBy(g => g.Key)
                    .SelectMany(g => g)
                    .ToArray();
                List<int> lst = new List<int>();
                Array.ForEach(result, x => { if (lst.Count == 0 || lst[lst.Count - 1] != x) lst.Add(x); });
                lst.ForEach(Console.WriteLine);
            }
            else
            {
                if (prov(m) == "") Console.WriteLine(prov(n));
                else Console.WriteLine(prov(m));
            }
           
           // Console.WriteLine(string.Join(", ", result));
        }
    }
}
