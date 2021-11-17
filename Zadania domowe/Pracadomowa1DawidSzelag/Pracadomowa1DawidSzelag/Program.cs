using System;

namespace Pracadomowa1DawidSzelag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj stringa: ");
            string nazwa = Console.ReadLine();
            Console.Write(nazwa+"\n");
            Console.WriteLine("Podaj char'a: ");
            char znak = Console.ReadKey().KeyChar;
            Console.Write("\n"+znak+"\n");
            Console.WriteLine("Podaj inta: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.Write(liczba+"\n");
            Console.WriteLine("Podaj decimal'a: ");
            decimal liczba2;
            decimal.TryParse(Console.ReadLine(),out liczba2);
            Console.Write(liczba2 + "\n");
            Console.WriteLine("Podaj float'a: ");
            float liczba3;
            float.TryParse(Console.ReadLine(), out liczba3);
            Console.Write(liczba3 + "\n");
            Console.WriteLine("Podaj double'a: ");
            double liczba4;
            double.TryParse(Console.ReadLine(), out liczba4);
            Console.Write(liczba4 + "\n");
            Console.WriteLine("Podaj 2 liczby do działań: \n");
            decimal jeden, dwa;
            decimal.TryParse(Console.ReadLine(), out jeden);
            decimal.TryParse(Console.ReadLine(), out dwa);
            Console.WriteLine($"Mnożenie: {jeden * dwa}\nDzielenie: {jeden / dwa}\nDodawanie: {jeden + dwa}\nOdejmowanie: {jeden - dwa}");
        }
    }
}
