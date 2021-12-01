using System;
using System.Collections.Generic;

namespace Laboratorium3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            bool test = true;
            
            if (test)
            {
                Console.WriteLine("If bool true");
                Console.WriteLine("Druga linia");
            }
            else
            {
                Console.WriteLine("W elsie");
            }
            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"{a} jest większe");
            else
                Console.WriteLine($"{b} jest większe");
            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Liczby są równe");
            }
            else
                Console.WriteLine("Liczby są różne");
            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a>b && a>10)
            {
                Console.WriteLine("a jest większe od b i większe od 10");
            }
            else
            {
                Console.WriteLine("warunek nie został spełniony");
            }
            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a>=b || b==50)
            {
                Console.WriteLine("Przynajmniej jeden warunek został spełniony");
            }
            else
            {
                Console.WriteLine("oba warunki nie sa spelnione");
            }
            

            int a = 5;
            int b = 10;
            int c = 15;
            if (a == 10)
            {
                Console.WriteLine("Pierwszy if");

            }
            else if (b == 15)
            {
                Console.WriteLine("Drugi if");
            }
            else if (c==20)
            {
                Console.WriteLine("Trzeci if");
            }
            else
            {
                Console.WriteLine("Ostatni else");
            }
            
            int d = 202;

            switch(d)
            {
                case 5:
                    Console.WriteLine("5");
                    break;
                case 15:
                    Console.WriteLine("15");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            if (a > b && a>c)
                Console.WriteLine("a jest najwieksze");
            if (b > a && b > c)
                Console.WriteLine("b jest najwieksze");
            if (c > b && c > a)
                Console.WriteLine("c jest najwieksze");
            
            int counter = 5;
            while (counter>0)
            {
                counter--;
                Console.WriteLine(counter);
            }

            counter = 5;
            do
            {
                counter--;
                Console.WriteLine(counter);
            } while (counter > 0);
            
            int x = Int32.Parse(Console.ReadLine());

            for (int i=0;i<x;i++)
            {
                if (i >= 5)
                    continue;

                if (i%2==0)
                    Console.WriteLine($"{i} jest parzyste");
                else
                    Console.WriteLine($"{i} jest nieparzyste");
            }
            
           
            */
            int[] tab = { 10, 3, -1, 20 };
            int[] tab2 = new int[10];

            tab2[2] = 100;
            tab2[9] = -10;
            
            for (int i=0; i < tab2.Length; i++)
            {
                Console.WriteLine(tab2[i]);
            }
            
            
            foreach(int item in tab)
            {
                Console.WriteLine(item);
            }
            
            object[] tab3 = { true, 10, 3.3, "napis" };

            foreach(object item in tab3)
            {
                Console.WriteLine(item);
            }
            

            int[][] matrix = new int[3][];
            matrix[0] = new int[5];
            matrix[1] = new int[2];
            matrix[2] = new int[3];
            matrix[0][2] = 5;
            for (int i=0;i<matrix.Length;i++)
            {
                for (int j=0;j<matrix[i].Length;j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
            

            List<string> list = new List<string>() { "pies", "kot" }; //do listy trzeba dodać biblioteke  using System.Collections.Generic;

            list.Add("tygrys");

            list.Insert(1, "koń");

            list.RemoveAt(0);

            list.ForEach(Console.WriteLine);

            

            List<int> list2 = new List<int>() { 10, -1, 2, 6, 10, 0 };
            list2.ForEach(Console.WriteLine);

            list2.Sort(); //sortowanie rosnąco
            Console.WriteLine();
            list2.ForEach(Console.WriteLine);

            list2.Reverse(); //sortowanie malejąco
            Console.WriteLine();
            list2.ForEach(Console.WriteLine);
           

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("kot");
            queue.Enqueue("pies");
            queue.Enqueue("koń");
            for (int i=0;i < 3;i++)
            {
            Console.WriteLine(queue.Dequeue()); // Dequeue zwraca ostatnią wartość i później usuwa
            }

            Console.WriteLine();

            Stack<string> stack = new Stack<string>();
            stack.Push("kot");
            stack.Push("pies");
            stack.Push("koń");

            for (int i=0;i < 3;i++)
            {
                Console.WriteLine(stack.Pop());
            }
            */

            Dictionary<string, int> dict = new Dictionary<string, int>(); //klucz jest unikatowy

            dict.Add("azor", 10);
            dict.Add("nero", 8);
            dict.Add("fafik", 1);

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} klucz, {item.Value} wartosc");
            }

            Console.WriteLine();

            dict.Remove("nero");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} klucz, {item.Value} wartosc");
            }
        }
    }
}
