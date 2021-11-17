using System;

namespace Pracadomowa1DawidSzelag
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = Console.ReadLine();
            Console.Write(nazwa+"\n");
            char znak = Console.ReadKey().KeyChar;
            Console.Write(znak+"\n");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.Write(liczba+"\n");
            decimal liczba2;
            decimal.TryParse(Console.ReadLine(),out liczba2);
            Console.Write(liczba2 + "\n");
            float liczba3;
            float.TryParse(Console.ReadLine(), out liczba3);
            Console.Write(liczba3 + "\n");
            double liczba4;
            double.TryParse(Console.ReadLine(), out liczba4);
            Console.Write(liczba4 + "\n");
        }
    }
}
