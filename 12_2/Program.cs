using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Пункт Д
            Console.WriteLine("Пункт Д: ");
            Console.WriteLine("-------");
            Random rnd = new Random();
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rnd.Next();
                arr2[i] = rnd.Next();
            }
            #region д) Без LINQ
            Console.WriteLine();
            Console.WriteLine("Без LINQ");
            int x1 = 0;
            int y1 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr1[i] % 5 == 0)
                    x1++;
                if (arr2[i] % 5 == 0)
                    y1++;
            }
            Console.WriteLine("Колличество пар: " + x1 * y1);
            #endregion

            #region д) с LINQ
            Console.WriteLine();
            Console.WriteLine("С LINQ");
            var temp1 = from array1 in arr1 where (array1 % 5).CompareTo(0) == 0 select array1;
            var temp2 = from array2 in arr2 where (array2 % 5).CompareTo(0) == 0 select array2;
            int x2 = temp1.Count();
            int y2 = temp2.Count();
            Console.WriteLine("Колличество пар: " + x2 * y2);
            #endregion

            Console.WriteLine("-------");
            #endregion

            #region Пункт Е
            string[] str = new string[]
            {
                "adAwqda",
                "DwDwdot",
                "ajfhsnjde",
                "mdOihahd",
                "DaIjjotjd",
                "DbJotnjpp"
            };

            #region Без LINQ
            Console.WriteLine("Пункт Е: ");
            Console.WriteLine("-------");
            Console.WriteLine("Без LINQ");
            Console.WriteLine();
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
            for (int i = 0; i < list1.Count; i++)
                Console.WriteLine(list1[i]);
            Console.WriteLine();
            #endregion

            #region С LINQ           
            Console.WriteLine("С LINQ");
            Console.WriteLine();
            var list2 = from f in str where f.ToLower().Contains("ot") orderby f select f;
            foreach (var item in list2)
                Console.WriteLine(item);
            #endregion
            Console.WriteLine("-------");
            #endregion

            #region Пункт Ж
            string s1 = "asd";
            string s2 = "dsa";
            #region Без LINQ
            Console.WriteLine("Пункт Ж: ");
            Console.WriteLine("-------");
            Console.WriteLine("Без LINQ");
            Console.WriteLine();
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
            if (answer)
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");
            Console.WriteLine();
            #endregion           

            #region С LINQ
            Console.WriteLine("С LINQ");
            Console.WriteLine();
            var ans = string.Compare(s1, new string(s2.ToCharArray().Reverse().ToArray()));
            if (ans == 0)
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");
            #endregion
            Console.WriteLine("-------");
            #endregion

            #region Пункт З
            int[] ints = { 2, 5, 6, 1, 7, 3, 4 };

            #region Без LINQ
            Console.WriteLine("Пункт З: ");
            Console.WriteLine("-------");
            Console.WriteLine("Без LINQ");
            Console.WriteLine();
            List<int> evenList = new List<int>();
            List<int> unevenList = new List<int>();
            
            for (int i = 0; i < ints.Length; i++)
                if (ints[i] % 2 == 0)
                    evenList.Add(ints[i]);
                else
                    unevenList.Add(ints[i]);

            List<int> bList = evenList;
            for (int i = 0; i < unevenList.Count; i++)
                bList.Add(unevenList[i]);

            int p;
            int k;
            for (int i = 1; i < bList.Count; i++)
            {
                p = bList[i];
                k = i;
                while (k > 0 && bList[k - 1] > p)
                {
                    int temp = bList[i];
                    bList[i] = bList[k];
                    bList[k] = temp;
                    k -= 1;
                }
                bList[k] = p;
            }
                for (int i = 0; i < evenList.Count; i++)
                Console.WriteLine(evenList[i]);
            Console.WriteLine();
            #endregion

            #region С LINQ
            Console.WriteLine("С LINQ");
            Console.WriteLine();
            var evenList2 = from nl in ints where nl % 2 == 0 select nl;
            var unevenList2 = from nl2 in ints where nl2 % 2 != 0 select nl2;
            List<int> eList = evenList2.ToList();
            List<int> uneList = unevenList2.ToList();
            var answ = eList.Concat(uneList).ToList();
            answ.Sort();
            foreach (var item in answ)
                Console.WriteLine(item);
            #endregion
            Console.WriteLine();
            #endregion
        }
    }
}
