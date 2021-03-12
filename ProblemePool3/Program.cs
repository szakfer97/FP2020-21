using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemePool3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva problemele pool 3");
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
            Console.WriteLine("Ati ajuns la final!");
            Console.ReadKey();
        }
        private static void Problema1()
        {
            Console.WriteLine("1.Calculati suma elementelor unui vector");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                    sum += v[i];
                }
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema2()
        {
            Console.WriteLine("2.Se cere sa se determine prima pozitie din vectorul cu numere n pe care apare k");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int k = int.Parse(Console.ReadLine());
                int g = 0;
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < n && g == 0; i++)
                {
                    if (v[i] == k)
                    {
                        g = 1;
                        Console.WriteLine(i);
                    }
                }
                if (g == 0)
                    Console.WriteLine("-1");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema3()
        {
            Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                int max;
                int min;
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                min = max = a[0];
                for (int i = 1; i < n; i++)
                {
                    if (a[i] < min)
                        min = a[i];
                    else if (a[i] > max)
                        max = a[i];
                }
                Console.WriteLine($"Cel mai mic e {min},cel mai mare e {max}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema4()
        {
            Console.WriteLine("4.Deteminati cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                int[] f = new int[100000];
                for (int i = 0; i < f.Length; i++)
                    f[i] = 1;
                int max;
                int min;
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                min = max = a[0];
                for (int i = 1; i < n; i++)
                {

                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                    else if (a[i] == min)
                        f[min]++;
                    else if (a[i] > max)
                    {
                        max = a[i];
                    }
                    else if (a[i] == max)
                        f[max]++;
                }
                Console.WriteLine($"Minima e {min} si apare de {f[min]} ori");
                Console.WriteLine($"Maxima e {max} si apare de {f[max]} ori");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema5()
        {
            Console.WriteLine("5.Se da vectorul cu n elemente,valoare e si pozitie k.Se cere inserarea valoareai e in vector pe pozitia k");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int[] a = new int[n + 1];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                for (int i = n - 1; i > k - 1; i--)
                    a[i + 1] = a[i];
                n = n + 1;
                a[k] = e;
                for (int i = 0; i < n; i++)
                    Console.WriteLine($"{a[i]} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema6()
        {
            Console.WriteLine("6.Se cere sa se stearga din vector elementul de pe pozitia k");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int[] a = new int[n + 1];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                for (int i = k; i < n - 1; i++)
                    a[i] = a[i + 1];
                n = n - 1;
                for (int i = 0; i < n; i++)
                    Console.WriteLine($"{a[i] }");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema7()
        {
            Console.WriteLine("7.Se cere sa se inverseze ordinea elementelor din vectorul cu n elemente");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                int k = n - 1;
                int aux;
                for (int i = 0; i <= k; i++)
                {
                    aux = a[i];
                    a[i] = a[k];
                    a[k] = aux;
                    k--;
                }
                for (int i = 0; i < n; i++)
                    Console.Write($"{a[i]} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema8()
        {
            Console.WriteLine("8.Rotiti vectorul cu n elemente cu o pozitie spre stanga");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                int aux;
                for (int i = 0; i < n - 1; i++)
                {
                    aux = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = aux;
                }
                for (int i = 0; i < n; i++)
                    Console.Write($"{a[i]} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema9()
        {
            Console.WriteLine("9.Rotiti vectorul cu n elemente cu k pozitii spre stanga");
            try
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                int g = 0;
                int aux;
                for (g = 0; g < k; g++)
                    for (int i = 0; i < n - 1; i++)
                    {
                        aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                    }
                for (int i = 0; i < n; i++)
                    Console.Write($"{a[i]} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema10()
        {
            Console.WriteLine("10.Determinati cel mai mare divizor comun al vectorului cu n elemente");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int CMMDC = 0;
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                CMMDC = a[0];
                for (int i = 1; i < n; i++)
                {
                    int b = a[i];
                    while (b != CMMDC)
                    {
                        if (b > CMMDC)
                            b -= CMMDC;
                        else if (b < CMMDC)
                            CMMDC -= b;
                    }
                }
                Console.WriteLine($"{CMMDC}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
