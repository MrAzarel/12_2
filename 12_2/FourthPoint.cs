using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    internal class FourthPoint
    {
        int[] ints = { 2, 5, 6, 1, 7, 3, 4 };
        private List<int> WithoutLinq()
        {
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

            int x;
            int j;
            for (int i = 1; i < bList.Count; i++)
            {
                x = bList[i];
                j = i;
                while (j > 0 && bList[j - 1] > x)
                {
                    Swap(bList, j, j - 1);
                    j -= 1;
                }
                bList[j] = x;
            }
            return bList;
        }
        static void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private List<int> WithLinq()
        {
            var evenList2 = from nl in ints where nl % 2 == 0 select nl;
            var unevenList2 = from nl2 in ints where nl2 % 2 != 0 select nl2;
            List<int> eList = evenList2.ToList();
            List<int> uneList = unevenList2.ToList();
            var answ = eList.Concat(uneList).ToList();
            answ.Sort();
            return answ.ToList();
        }

        public void ConclusionFourthPoint()
        {
            Console.WriteLine("Пункт З: ");
            Console.WriteLine("-------");

            Console.WriteLine("Без LINQ");
            Console.WriteLine();
            List<int> list = WithoutLinq();
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.WriteLine();

            Console.WriteLine("С LINQ");
            Console.WriteLine();
            List<int> list2 = WithLinq();
            foreach (var item in list2)
                Console.WriteLine(item);

            Console.WriteLine("-------");
        }
    }
}
