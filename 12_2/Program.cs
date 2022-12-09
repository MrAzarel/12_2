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
            FirstPoint firstPoint = new FirstPoint();

            SecondPoint secondPoint = new SecondPoint();

            ThirdPoint thirdPoint = new ThirdPoint();

            FourthPoint fourthPoint = new FourthPoint();

            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("1. Первый пункт. \n2. Второй пункт. \n" +
                "3. Третий пункт. \n4. Четвертый пункт. \n5. Завершение программы.");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        firstPoint.FirstPointConclusion();
                        break;
                    case "2":
                        Console.Clear();
                        secondPoint.ConclusionSecondPoint();
                        break;
                    case "3":
                        Console.Clear();
                        thirdPoint.ConclusionThirdPoint();
                        break;
                    case "4":
                        Console.Clear();
                        fourthPoint.ConclusionFourthPoint();
                        break;
                }
            }
        }
    }
}
