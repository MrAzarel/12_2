using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    internal class FirstPoint
    {
        Random rnd = new Random();
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        private int WithoutLinq(int[] arr1, int[] arr2)
        {
            int x1 = 0;
            int y1 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr1[i] % 5 == 0)
                    x1++;
                if (arr2[i] % 5 == 0)
                    y1++;
            }
            return x1 * y1;
        }
        private int WithLinq(int[] arr1, int[] arr2)
        {
            var temp1 = from array1 in arr1 where (array1 % 5).CompareTo(0) == 0 select array1;
            var temp2 = from array2 in arr2 where (array2 % 5).CompareTo(0) == 0 select array2;
            int x2 = temp1.Count();
            int y2 = temp2.Count();
            return x2 * y2;
        }
        public void FirstPointConclusion()
        {
            Console.WriteLine("Пункт Д: ");
            Console.WriteLine("-------");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rnd.Next();
                arr2[i] = rnd.Next();
            }

            Console.WriteLine();
            Console.WriteLine("Без LINQ");
            Console.WriteLine("Колличество пар: " + WithoutLinq(arr1, arr2));

            Console.WriteLine();
            Console.WriteLine("С LINQ");
            Console.WriteLine("Колличество пар: " + WithLinq(arr1, arr2));

            Console.WriteLine("-------");
        }
    }
}
