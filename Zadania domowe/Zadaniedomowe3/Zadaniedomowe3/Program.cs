    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Globalization;
    using System.IO;
    using System.Linq;

namespace Zadaniedomowe3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dawid Szeląg

            List<string> words = File.ReadAllLines(@"C:\Users\Dawid\Desktop\Piwa.txt").ToList();
            List <char> guess = new List<char>(); //struktura z zgadniętymi znakami
            var los = new Random();
            int cluenumber = los.Next(words.Count); //losowanie hasła
            List<char> clue = new List<char>(); //struktura ze znakami od hasła
            for (int i=0;i<words[cluenumber].Length;i++)
            {
                clue.Add(words[cluenumber][i]); //uzupełnianie listy clue, literami z hasła
            }
            string help=""; //pomoc do zagwiazdkowanego hasła
            for (int i = 0; i < clue.Count; i++)
            {
                help += '*'; 
            }
            StringBuilder secret = new StringBuilder(help); //zagwiazdkowane hasło
            int life = 5; //ilość żyć=5
            char sign; //znak od użytkownika
            int meter = clue.Count; //ilość znaków w haśle (licznik ile zostało do zgadnięcia)
            while (meter>0)
            {
                Console.WriteLine("Kategoria: PIWO");
                Console.WriteLine($"Ilość żyć: {life}");
                Console.WriteLine($"Ilość liter: {clue.Count}");
                Console.WriteLine($"Hasło: {secret}");
                Console.Write($"Użyte litery: {String.Join(",",guess.ToArray())}");
                Console.Write("\nZgadnij znak, który znajduję się w powyższym haśle!\nPodaj znak: ");
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                sign = Char.ToLower(Console.ReadKey().KeyChar,new CultureInfo("pl-PL"));
                Console.WriteLine();
                if (!(guess.Contains(sign))) //sprawdzanie czy gracz się nie powtórzył
                {
                    guess.Add(sign);
                    if (clue.Contains(sign))
                    {
                        for (int j = 0; j < clue.Count; j++)
                        {
                            
                            if (clue[j] == sign) 
                            {
                                secret[j] = sign;
                                meter--;
                            }
                        }
                    }
                    else
                    {
                        life--;
                    }
                }
                else
                {
                    Console.WriteLine("\nPodałeś już wcześniej ten znak! Spróbuj innego znaku.\n\n");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
                if (life == 0 || meter ==0 ) // Jeśli gracz wygra lub przegra, co wtedy
                {
                    Console.Clear();
                    Console.WriteLine("Kategoria: PIWO");
                    Console.WriteLine($"Ilość żyć: {life}");
                    Console.WriteLine($"Ilość liter: {clue.Count}");
                    Console.WriteLine($"Hasło: {secret}");
                    Console.Write($"Użyte litery: {String.Join(",", guess.ToArray())}");
                    if (meter == 0) Console.WriteLine("\n\nBrawo! Udało ci się odgadnąć hasło!\n\n");
                    if (life == 0)
                    {
                        Console.WriteLine("\n\nStraciłeś wszystkie życia!\n\n");
                        Console.WriteLine($"Poprawne hasło to: {words[cluenumber]}\n\n");
                    }
                    char x;
                    do
                    {
                        Console.WriteLine("Kliknij 1, aby zagrać ponownie. Jeśli chcesz zakończyć grę, wciśnij 0:  ");
                        x = Console.ReadKey().KeyChar;
                        if (x == '1') //jeśli chce grać od nowa, reset
                        {
                            life = 5;
                            guess.Clear();
                            clue.Clear();
                            cluenumber = los.Next(words.Count);
                            for (int i = 0; i < words[cluenumber].Length; i++)
                            {
                                clue.Add(words[cluenumber][i]); //uzupełnianie listy clue, literami z hasła
                            }
                            meter = clue.Count; //ilość znaków w haśle (licznik ile zostało do zgadnięcia)
                            help = ""; //pomoc do zagwiazdkowanego hasła
                            for (int i = 0; i < clue.Count; i++)
                            {
                                help += '*';
                            }
                            secret = new StringBuilder(help);
                        }
                        if (x == '0') Environment.Exit(0); //jeśli nie chce grać, zamknij konsole
                        if (x !='1')
                        {
                            Console.WriteLine("\nPodałeś zły znak! Podaj jeszcze raz ;)");
                            System.Threading.Thread.Sleep(1400);
                            Console.Clear();
                        }
                    }while (x != '1');
                    
                }
                Console.WriteLine("\n\n");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
