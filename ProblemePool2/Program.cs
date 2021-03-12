using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemePool2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva problemele pool 2");
            Problema1();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema2();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema3();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema4();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema5();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema6();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema7();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema8();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema9();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema10();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema11();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema12();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema13();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema14();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema15();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema16();
            Console.WriteLine("Va rog asteptati,se incarca ultima problema...");
            Thread.Sleep(500);
            Problema17();
            Console.WriteLine("Ati ajuns la final!");
            Console.ReadKey();
        }
        private static void Problema1()
        {
            Console.WriteLine("1.Se da o secventa de n numere.Sa se determine cate din ele sunt pare");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int numar = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x % 2 == 0)
                        numar++;
                }
                Console.WriteLine(numar);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema2()
        {
            Console.WriteLine("2.Se da o secventa de n numere.Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int neg = 0, nul = 0, poz = 0; ;
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x < 0)
                        neg++;
                    else if (x > 0)
                        poz++;
                    else if (x == 0)
                        nul++;
                }
                Console.WriteLine($"negative {neg} pozitive {poz} zero {nul}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema3()
        {
            Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0, prod = 1;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                    prod *= i;
                }
                Console.WriteLine($"suma {sum} produs {prod}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema4()
        {
            Console.WriteLine("4.Se da o secventa de n numere.Determinati pe ce pozitie se afla in secventa un numar a");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int a = int.Parse(Console.ReadLine());
                int m = 0, poz = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x == a)
                    {
                        m = 1;
                        poz = i;
                    }
                }
                if (m == 1)
                    Console.WriteLine($"pozitie {poz} ");
                else
                    Console.WriteLine("-1");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema5()
        {
            Console.WriteLine("5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int numar = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x == i)
                        numar++;
                }
                Console.WriteLine(numar);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema6()
        {
            Console.WriteLine("6.Se da o secventa de n numere.Sa se determine daca numerele din secventa sunt in ordine crescatoare");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int numar = 0;
                for (int i = 1; i < n; i++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (y >= x)
                        numar = 0;
                    else
                        numar++;
                    x = y;
                }
                if (numar == 0)
                    Console.WriteLine("Da,sunt in ordine crescatoare");
                else
                    Console.WriteLine("Nu sunt in ordine crescatoare");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema7()
        {
            Console.WriteLine("7.Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int x = int.Parse(Console.ReadLine());
                int min, max;
                min = max = x;
                for (int i = 1; i < n; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                    if (a < min)
                        min = a;
                    else if (a > max)
                        max = a;
                }
                Console.WriteLine("minim " + min);
                Console.WriteLine("maxim " + max);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema8()
        {
            Console.WriteLine("8.Determianti al n-lea numar din sirul lui Fibonacci");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = 0;
                int y = 1;
                int z = 0;
                for (int i = 2; i < n; i++)
                {
                    z = y + x;
                    x = y;
                    y = z;
                }
                Console.WriteLine($"Al {n}-lea numar este {z}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema9()
        {
            Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int cresc = 0;
                int decresc = 0;
                int x = int.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (x <= y)
                        cresc++;
                    else
                        decresc++;
                    y = x;
                }
                if (decresc == 0)
                    Console.WriteLine("Secventa e monoton crescatoare");
                else if (cresc == 0)
                    Console.WriteLine("Secventa e monoton descrescatoare");
                else
                    Console.WriteLine("Secventa nu este monotona");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema10()
        {
            Console.WriteLine("10.Se da o secventa de n numere.Care este numarul maxim de numere consecutive egale din secventa");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int a = 1, max = 0; ;
                for (int i = 1; i < n; i++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (x == y)
                        a++;
                    else
                        a = 1;
                    if (a >= max)
                        max = a;
                }
                Console.WriteLine(max);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema11()
        {
            Console.WriteLine("11.Se da o secventa de n numere.Se cere sa se caculeze suma inverselor acestor numere");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int s = 0;
                int inv;
                for (int i = 0; i < n; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                    inv = 0;
                    while (a != 0)
                    {
                        inv = inv * 10 + a % 10;
                        a = a / 10;
                    }
                    s += inv;
                }
                Console.WriteLine("Suma inverselor este " + s);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema12()
        {
            Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere");
            try
            {
                string secventa = Console.ReadLine();
                string[] delim = secventa.Split('0');
                int i = 0, grup = 0;
                int descresc = 0, cresc = 0, numar = 0;
                for (i = 0; i < delim.Length; i++)
                {
                    cresc = 0;
                    numar = 0;
                    foreach (char c in delim[i])
                    {

                        if (Char.IsDigit(c))
                        {
                            if (c != '0')
                            {
                                if ((int)c > descresc)
                                {
                                    cresc++;
                                }
                                numar++;
                                descresc = (int)c;
                            }
                        }
                    }
                    if (cresc == numar && cresc != 0 && numar != 0)
                        grup++;
                }
                Console.WriteLine($"Numarul de grupuri e :{grup}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema13()
        {
            Console.WriteLine("13.Secventa crescatoare rotita poate fi in ordine crescatoare/poate fi transformata in ordine crescatoare");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int minim = x;
                bool cresc = true;
                int descresc = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (x > y)
                    {
                        cresc = false;
                    }
                    if (x > y && minim > y)
                    {
                        descresc++;
                    }
                    x = y;
                }
                if (cresc == true || descresc == 1)
                    Console.WriteLine("Da,este rotita crescatoare");
                else
                    Console.WriteLine("Nu este rotita crescatoare");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema14()
        {
            Console.WriteLine("14.O secventa monotona rotita este monotona/poate fi transformata intr-o secventa monotona");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int a = int.Parse(Console.ReadLine());
                int min, max;
                min = max = a;
                bool cresc = true, descresc = true;
                int cadereCresc = 0, cadereDescresc = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    int b = int.Parse(Console.ReadLine());
                    if (a > b)
                    {
                        cresc = false;
                    }
                    else if (a < b)
                    {
                        descresc = false;
                    }
                    if (a > b && min > b)
                    {
                        cadereCresc++;
                    }
                    if (a < b && max < b)
                    {
                        cadereDescresc++;
                    }
                    a = b;
                }
                if (cresc == true || cadereCresc == 1)
                    Console.WriteLine("Da,este monoton crescatoare rotita");
                else if (descresc == true || cadereDescresc == 1)
                    Console.WriteLine("Da,este monoton descrescatoare rotita");
                else
                    Console.WriteLine("Nu este monotona");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema15()
        {
            Console.WriteLine("15.O secventa bitonica incepe monoton crescator si continua monoton descrecator");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = 0;
                int y = 0;
                bool cresc = false, descresc = false;
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < n - 1; i++)
                {
                    int b = int.Parse(Console.ReadLine());
                    if (b >= a && descresc == false)
                    {
                        cresc = true;
                        x++;
                    }
                    else if (b <= a && cresc == true)
                    {
                        descresc = true;
                        y++;
                    }
                    a = b;
                }
                if (y + x == n - 1)
                    Console.WriteLine("Da,secventa este bitonica");
                else
                    Console.WriteLine("Nu este bitonica");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema16()
        {
            Console.WriteLine("16.O secventa bitonica rotita este bitonica/poate fi transformata intr-o secventa bitonica");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int comparDescresc = x;
                int comparCresc = x;
                bool cresc = false;
                bool descresc = false, biton = false;
                for (int i = 0; i < n - 1; i++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (y <= x && cresc == false)
                    {
                        descresc = true;
                    }
                    else if (y >= comparCresc && cresc == false && descresc == false)
                    {
                        cresc = true;
                        descresc = true;
                    }
                    else if (y >= x && cresc == false)
                    {
                        cresc = true;
                    }
                    else if (y <= x && cresc == true)
                    {
                        descresc = true;
                    }
                    else if (y <= x && descresc == true)
                    {
                        cresc = true;
                    }
                    else if (y >= x && descresc == true && cresc == true)
                    {
                        if (y >= comparDescresc || y >= comparCresc)
                        {
                            biton = true;
                        }
                        else
                        {
                            biton = false;
                        }
                    }
                    x = y;
                }
                if (biton == true)
                    Console.WriteLine("Da,este bitonica rotita");
                else
                    Console.WriteLine("Nu este bitonica rotita");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema17()
        {
            Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa");
            try
            {
                string secven = Console.ReadLine();
                int x = 0, a = 1, numar = 0, maxinc = -1;
                foreach (char s in secven)
                {
                    if (s == '0')
                        x++;
                    else if (s == '1' && x > 0)
                        x--;
                    else
                        a = 0;
                }
                if (a != 0 && x == 0)
                {
                    Console.WriteLine("Parantezele sunt sortate corect");
                    foreach (char s in secven)
                    {
                        if (s == '0')
                            numar++;
                        else
                            numar--;
                        if (numar > maxinc)
                            maxinc = numar;
                    }
                    Console.WriteLine($"Incuibarea maxima este {maxinc}");
                }
                else
                    Console.WriteLine("Nu sunt sortate corect parantezele");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
