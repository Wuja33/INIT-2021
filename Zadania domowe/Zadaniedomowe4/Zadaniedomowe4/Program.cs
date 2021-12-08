using System;

namespace Zadaniedomowe4
{
    class Program
    {
        static void testresult(double procent)
        {
            if (procent < 30.0) Console.WriteLine("Ocena: 1");
            else if (procent >= 30.0 && procent <= 50.0) Console.WriteLine("Ocena: 2");
            else if (procent > 50.0 && procent < 75.0) Console.WriteLine("Ocena: 3");
            else if (procent >= 75.0 && procent <= 90.0) Console.WriteLine("Ocena: 4");
            else if (procent > 90.0 && procent < 100.0) Console.WriteLine("Ocena: 5");
            else if (procent == 100.0) Console.WriteLine("Ocena: 6");
        }
        static double Tax(double income)
        {
            if (income <= 85_528.0) return (income * 0.17);
            else if (income > 85_528.0 && income < 1_000_000.0) return (85_528.0 * 0.17 + (income- 85_528.0) * 0.32);
            else return (85_528.0 * 0.17 + (1_000_000.0 - 85_528.0)* 0.32 + (income - 1_000_000.0) * 0.36);
        }
        static double calculator(double x, double y, char z)
        {
            switch(z)
            {
                case '+':
                    {
                        return (x + y);
                        break;
                    }
                case '-':
                    {
                        return (x - y);
                        break;
                    }
                case '*':
                    {
                        return (x * y);
                        break;
                    }
                case '/':
                    {
                        return (x / y);
                        break;
                    }
                default:
                    return 0;
                    break;
            }
        }
        static void Main(string[] args)
        {
            double procentest;
            bool bug = false;
            do
            {
                Console.WriteLine("Podaj procent z testu (0-100): ");
                if (double.TryParse(Console.ReadLine(), out procentest) && procentest >= 0 && procentest <= 100)
                {
                    testresult(procentest);
                    bug = false;
                }else
                {
                    Console.WriteLine("Podałeś niepoprawną daną! Podaj ponownie.\n\n ");
                    bug = true;
                }
                
            } while (bug == true);

            double income;
            do
            {
                Console.WriteLine("Podaj dochód: ");
                if (double.TryParse(Console.ReadLine(), out income) && income > 0)
                {
                    Console.WriteLine($"Twój podatek wynosi: {Tax(income)}"); 
                    bug = false;
                }
                else
                {
                    Console.WriteLine("Podałeś niepoprawną daną! Podaj ponownie.\n\n ");
                    bug = true;
                }
            } while (bug == true);

            char sign;
            bool exitcalc = false;
            double number1, number2;
            do
            {
                Console.WriteLine("KALKULATOR\n");
                Console.WriteLine("Podaj 2 liczby oraz operator ( - ;  + ; * ; / ): \n");
                do
                {
                    Console.WriteLine("Podaj 1 liczbe: ");
                    if (double.TryParse(Console.ReadLine(), out number1)) bug = false;
                    else
                    {
                        Console.WriteLine("Podałeś niepoprawną daną! Podaj ponownie.\n\n ");
                        bug = true;
                    }

                } while (bug == true);

                do
                {
                    Console.WriteLine("Podaj 2 liczbe: ");
                    if (double.TryParse(Console.ReadLine(), out number2)) bug = false;
                    else
                    {
                        Console.WriteLine("Podałeś niepoprawną daną! Podaj ponownie.\n\n ");
                        bug = true;
                    }

                } while (bug == true);

                do
                {
                    Console.WriteLine("Podaj znak: ");
                    if (char.TryParse(Console.ReadLine(), out sign) && (sign == '-' || sign == '+' || sign == '*' || sign == '/'))
                    {
                        if (number2 == 0.0 && sign == '/')
                        {
                            Console.WriteLine("Nie można dzielić przez zero!");
                            break;
                        }
                        Console.WriteLine("Wynik działania: {0}", calculator(number1, number2, sign));
                        bug = false;
                    }
                    else
                    {
                        Console.WriteLine("Podałeś niepoprawną daną! Podaj ponownie.\n\n ");
                        bug = true;
                    }
                } while (bug == true);
                Console.WriteLine("Aby wykonać kolejne działanie, wciśnij 1. Aby zakończyc program wciśnij 0.");

                do
                {
                    Console.WriteLine("Podaj 1 lub 0: ");
                    if (char.TryParse(Console.ReadLine(), out sign) && (sign == '1' || sign == '0'))
                    {
                        if (sign == '1')
                        {
                            bug = false;
                            exitcalc = false;
                        }
                        else if (sign == '0') Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś niepoprawną daną! Podaj ponownie.\n\n ");
                        bug = true;
                    }
                } while (bug == true);
                Console.Clear();
            } while (exitcalc == false);
        }
    }
}
