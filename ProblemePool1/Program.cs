using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemePool1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva problemele pool 1");
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
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema17();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema18();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema19();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema20();
            Console.WriteLine("Va rog asteptati,se incarca ultima problema...");
            Thread.Sleep(500);
            Problema21();
            Console.WriteLine("Ati ajuns la final!");
            Console.ReadKey();
        }
        private static void Problema1()
        {
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                float x;
                x = -b / a;
                Console.WriteLine($"x este {x}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema2()
        {
            Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0");
            try
            {
                int a, b, c;
                double x1, x2;
                float delta;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                delta = b * b - (4 * (a * c));
                Console.Write("Delta este egal cu: ");
                Console.WriteLine(delta);
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.Write("Radacinile ecuatiei sunt:", " ");
                    Console.Write(x1);
                    Console.Write(" si ");
                    Console.WriteLine(x2);
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = -b / (2 * a);
                    Console.Write("Radacinile ecuatiei sunt:", " ");
                    Console.Write(x1);
                    Console.Write(" si ");
                    Console.WriteLine(x2);
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are ca radacini numere reale");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema3()
        {
            Console.WriteLine("3.Determinati daca n se divide cu k");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                if (n % k == 0)
                    Console.WriteLine("n se divide cu k");
                else
                    Console.WriteLine("n nu se divide cu k");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema4()
        {
            Console.WriteLine("4.Determinati daca un an y este an bisect");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 4 == 0)
                    Console.WriteLine("An bisect");
                else
                    Console.WriteLine("Nu este an bisect");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema5()
        {
            Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int nr = 0;
                while (n != 0)
                    if ((k - nr) != 1)
                    {
                        n = n / 10;
                        nr++;
                    }
                    else
                    {
                        Console.Write(n % 10);
                        break;
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema6()
        {
            Console.WriteLine("6.Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (a + b < c)
                    Console.WriteLine("Nu pot fi");
                else if (a + c < b)
                    Console.WriteLine("Nu pot fi");
                else if (b + c < a)
                    Console.WriteLine("Nu pot fi");
                else
                    Console.WriteLine("Da,pot fi");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema7()
        {
            Console.WriteLine("7.(Swap)Se dau doua variabile numerice a si b ale caror valori trebuie inversate");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int aux = a;
                a = b;
                b = aux;
                Console.WriteLine("Dupa interschimbare valorile sunt:");
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema8()
        {
            Console.WriteLine("8.(Swap)Se dau doua variabile numerice a si b ale caror valori trebuie inversate fara alte variabile");
            try
            {
                int a, b;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("Dupa interschimbare variabilele sunt:");
                Console.WriteLine(a + " ");
                Console.WriteLine(b + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema9()
        {
            Console.WriteLine("9.Afisati toti divizorii numarului n");
            try
            {
                int i;
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Divizorii numarului sunt:");
                for (i = 1; i <= n; i++)
                    if (n % i == 0)
                        Console.WriteLine(i + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema10()
        {
            Console.WriteLine("10.Test de primalitate:determinati daca un numar n este prim");
            try
            {
                int i, nr = 0;
                int n = int.Parse(Console.ReadLine());
                for (i = 1; i <= n; i++)
                    if (n % i == 0)
                        nr++;
                if (nr == 2)
                    Console.WriteLine("Numarul este prim");
                else
                    Console.WriteLine("Numarul nu este prim");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema11()
        {
            Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n");
            try
            {
                int n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    Console.WriteLine(n % 10 + " ");
                    n = n / 10;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema12()
        {
            Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
            try
            {
                int nr = 0, aux;
                int n = int.Parse(Console.ReadLine());
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    aux = a;
                    a = b;
                    b = a;
                }
                for (int i = a; i <= b; i++)
                    if (i % n == 0)
                        nr++;
                Console.WriteLine(nr);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema13()
        {
            Console.WriteLine("13.Determinati cati ani bisecti sunt intre doi ani");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int counter = 0;
                int i = a + 1;
                while (i < b)
                {
                    if (i % 4 == 0)
                    {
                        counter++;
                        i = i + 4;
                    }
                    else
                        i++;
                }
                Console.WriteLine($"Sunt {counter} ani");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema14()
        {
            Console.WriteLine("14.Determinati daca un numar n este palindrom");
            try
            {
                int m, ogli = 0;
                int n = int.Parse(Console.ReadLine());
                m = n;
                while (m != 0)
                {
                    ogli = ogli * 10 + m % 10;
                    m = m / 10;
                }
                if (ogli == n)
                    Console.WriteLine("Numarul este palidrom");
                else
                    Console.WriteLine("Numarul nu este palidrom");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema15()
        {
            Console.WriteLine("15.Se dau 3 numere.Sa se afiseze in ordine crescatoare");
            try
            {
                int aux;
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    aux = a;
                    a = b;
                    b = aux;
                }
                if (a > c)
                {
                    aux = a;
                    a = c;
                    c = aux;
                }

                if (b > c)
                {
                    aux = b;
                    b = c;
                    c = aux;
                }
                Console.WriteLine("Primele 3 numere ordonate crescator sunt:" + a + " " + b + " " + c);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema16()
        {
            Console.WriteLine("16.Se dau 5 numere.Sa se afiseze in ordine crescatoare,fara tablouri");
            try
            {
                int a, b, c, d, e, aux;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                e = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    aux = a;
                    a = b;
                    b = aux;
                }
                if (a > c)
                {
                    aux = a;
                    a = c;
                    c = aux;
                }
                if (b > c)
                {
                    aux = b;
                    b = c;
                    c = aux;
                }
                if (a > d)
                {
                    aux = a;
                    a = d;
                    d = aux;
                }
                if (a > e)
                {
                    aux = a;
                    a = e;
                    e = aux;
                }
                if (b > d)
                {
                    aux = b;
                    b = d;
                    d = aux;
                }
                if (b > e)
                {
                    aux = b;
                    b = e;
                    e = aux;
                }
                if (c > d)
                {
                    aux = c;
                    c = d;
                    d = aux;
                }
                if (c > e)
                {
                    aux = c;
                    c = e;
                    e = aux;
                }
                if (d > e)
                {
                    aux = d;
                    d = e;
                    e = aux;
                }
                Console.WriteLine("Primele 5 numere ordonate crescator sunt:" + a + " " + b + " " + c + " " + d + " " + e);
            }
            catch (Exception er)
            {
                Console.WriteLine($" {er.Message}");
            }
        }
        private static void Problema17()
        {
            Console.WriteLine("17.Determinati CMMDC si CMMC a doua numere,folosind algoritmul lui Euclid");
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z, t;
                int xz = x;
                int yz = y;
                while (x != y)
                {
                    if (x > y)
                        x -= y;
                    else
                        y -= x;
                }
                z = xz;
                t = yz;
                while (xz != yz)
                {
                    if (yz < xz)
                        yz += z;
                    else
                        xz += t;
                }
                Console.WriteLine($"CMMDC: {x} CMMC: {yz}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema18()
        {
            Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int d = 2;
                int pr = 0;
                while (a > 1)
                {
                    pr = 0;
                    while (a % d == 0)
                    {
                        pr++;
                        a = a / d;
                    }

                    if (pr > 0)
                    {
                        Console.WriteLine($"{d} - {pr}");
                    }
                    d++;

                    if (a > 1 && d * d > a)
                    {
                        d = (int)a;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema19()
        {
            Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre repetitive");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int[] v = new int[10];
                int nr = 0;
                for (int i = 0; i < 10; i++)
                    v[i] = 0;
                while (a != 0)
                {
                    v[a % 10]++;
                    a /= 10;
                }
                for (int i = 0; i < 10; i++)
                    if (v[i] != 0)
                        nr++;
                if (nr == 2)
                    Console.WriteLine("Da");
                else
                    Console.WriteLine("Nu");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema20()
        {
            Console.WriteLine("20.Afisati fractia m/n in format zecimal,cu perioada intre paranteze");
            try
            {
                float m = float.Parse(Console.ReadLine());
                float n = float.Parse(Console.ReadLine());
                float impart = 0;
                impart = m / n;
                string numar = Convert.ToString(impart);
                char[] dot = { '.' };
                string[] numere_intregi = numar.Split(dot, StringSplitOptions.RemoveEmptyEntries);
                int partint = int.Parse(numere_intregi[0]);
                int partzec = int.Parse(numere_intregi[1]);
                Console.WriteLine($"Rezultatul impartirii este:{partint}" + "," + $"({partzec})");
                Console.WriteLine($"Partea zecimala este:{partzec}");
                double fract = impart - Math.Truncate(impart);
                int maxDecimal = 6;
                while (maxDecimal > 0 && fract != 0)
                {
                    int cifraZecimala;
                    cifraZecimala = (int)Math.Truncate(fract * 10);
                    fract = fract * 10 - Math.Truncate(fract * 10);
                    maxDecimal--;
                    Console.Write($"{cifraZecimala}");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        static Random rng = new Random();
        private static void Problema21()
        {
            Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 prin intrebari");
            try
            {
                int random = rng.Next(1025);
                int g = 0;
                while (g == 0)
                {
                    int numar = int.Parse(Console.ReadLine());
                    if (numar < random) Console.WriteLine("Incearca un numar mai mare");
                    if (numar > random) Console.WriteLine("Incearca un numar mai mic");
                    if (numar == random)
                    {
                        Console.WriteLine($"Ai gasit numarul {random}");
                        g = 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
