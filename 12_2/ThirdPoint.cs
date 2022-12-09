using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    internal class ThirdPoint
    {
        string s1 = "asd";
        string s2 = "dsa";
        private bool WithoutLinq()
        {
            int x;
            bool answer = true;
            if (s1.Count() >= s2.Count())
                x = s1.Count();
            else
                x = s2.Count();


            char[] s = s2.ToCharArray();
            Array.Reverse(s);
            string s2D = new string(s);

            for (int i = 0; i < x; i++)
            {
                if (s1[i] != s2D[i])
                {
                    answer = false;
                    break;
                }
            }
            return answer;
        }
        private int WithLinq()
        {
            var ans = string.Compare(s1, new string(s2.ToCharArray().Reverse().ToArray()));
            return ans;
        }
        public void ConclusionThirdPoint()
        {
            Console.WriteLine("Пункт Ж: ");
            Console.WriteLine("-------");

            Console.WriteLine("Без LINQ");
            Console.WriteLine();
            if (WithoutLinq())
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");
            Console.WriteLine();

            Console.WriteLine("С LINQ");
            Console.WriteLine();
            if (WithLinq() == 0)
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");

            Console.WriteLine("-------");
        }
    }
}
