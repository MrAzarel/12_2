using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    internal class SecondPoint
    {
        string[] str = new string[]
            {
                "adAwqda",
                "DwDwdot",
                "ajfhsnjde",
                "mdOihahd",
                "DaIjjotjd",
                "DbJotnjpp"
            };
        private List<string> WithoutLinq()
        {
            char a, b;
            List<string> list1 = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                a = str[i].ToLower()[0];
                b = ' ';
                for (int j = 1; j < str[i].Length; j++)
                {
                    b = str[i].ToLower()[j];
                    if (a == 'o' && b == 't')
                    {
                        list1.Add(str[i]);
                        break;
                    }
                    a = str[i].ToLower()[j];
                }
            }

            list1.Sort();
            return list1;
        }

        private List<string> WithLinq()
        {
            var list2 = from f in str where f.ToLower().Contains("ot") orderby f select f;
            return list2.ToList();
        }

        public void ConclusionSecondPoint()
        {
            Console.WriteLine("Пункт Е: ");
            Console.WriteLine("-------");

            Console.WriteLine("Без LINQ");
            Console.WriteLine();
            List<string> list1 = WithoutLinq();
            for (int i = 0; i < list1.Count; i++)
                Console.WriteLine(list1[i]);
            Console.WriteLine();

            Console.WriteLine("С LINQ");
            Console.WriteLine();
            foreach (var item in WithLinq())
                Console.WriteLine(item);

            Console.WriteLine("-------");
        }
    }
}
