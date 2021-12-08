using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class Program
    {
        /// <summary>
        /// Funkcja, która gratuluje użytkownikowi
        /// </summary>
        static void Congratulations(string name,int age = -1)
        {
            Console.WriteLine("Gratulacje " + name + "! Napisałeś pierwszą funkcję! Masz " + age + " lat. ");
        }
        /// <summary>
        /// Funkcja obliczająca długość okręgu
        /// </summary>
        /// <param name="radius">Promień okręgu</param>
        static void CalculateCircleLength(double radius)
        {
            Console.WriteLine($"Długość okręgu to: {Math.Round(2*radius*Math.PI,2)} ");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Suma x i y</returns>
        static int Add(int x,int y)
        {
            int z = x + y;
            return z;
        }
        /// <summary>
        /// Obliczanie pola
        /// </summary>
        /// <param name="radius">Promień</param>
        /// <returns>pole</returns>
        static double field(double radius)
        {
            return Math.Round(Math.Pow(radius,2)*Math.PI,2);
        }
        
        static bool przestepny(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) return true;
                    else return false;
                }
                else return true;
            }
            else return false;
        }

        static List<string> fruit(List<string> listf)
        {
            var list1 = listf.Where(owoc => owoc.Length < 6 && owoc.StartsWith('l')).OrderBy(owoc => owoc).ToList();
            return list1;
        }
        static void Main(string[] args)
        {
            /*
            Program.Congratulations("Dawid",19);
            Congratulations("Dawid");
            CalculateCircleLength(3);
            Console.WriteLine(Add(1,3));
            
            Console.WriteLine($"bool wynosi: {przestepny(2012)}");
            */

            List<string> owoce = new List<string>() { "limonka","liczi","laskowiec" };
            

            fruit(owoce);
            foreach (string item in fruit(owoce))
            {
                Console.WriteLine(item);
            }

            /*
            int[] scores = new int[] { 97, 60, 10, 20, 71, 80 ,85, 100};

            var scoresQuery = from score in scores where score > 70 select score;
            
            foreach (int score in scoresQuery)
            {
                Console.WriteLine(score);
            }

            var scoresQueryMethodBased = scores.Where(score => score > 70).OrderBy(score => score).ToList();

            foreach (int score in scoresQueryMethodBased)
            {
                Console.WriteLine(score);
            }

            var wordsA = new string[] { "apple", "peach", "blueberry" };

            var wordsB = new string[] { "apple", "peach", "blueberry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine(match);

            List<int> testList = Enumerable.Range(0, 1000).ToList();

            var max = testList.Max();

            var min = testList.Min();

            var avarage = testList.Average();

            var firstOrDefault = testList.FirstOrDefault(number => number > 99);
            */
        }
    }
}
