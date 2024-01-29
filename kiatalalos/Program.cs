using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static kiatalalos.Kitalalos;

namespace kiatalalos
{
    internal class Program
    {
        static int tippeles = 0;
        static szavak[] rejtettszavak = new szavak[100];
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            Console.WriteLine("Kérem az eredmény");
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4.Feladat");
            Console.WriteLine("Kérem írja be a stopot ha szeretné: ");
            string tipp =Console.ReadLine();
            if (tipp.ToLower() == "stop")
            {
                break;
            }
            else
            {
                tippSzam++;
            }
        }

        private static void feladat3(string rejtettszo, string tipp)
        {
            Console.WriteLine("\n3. Feladat:");
            string eredmeny = "";
            for (int i = 0; i < rejtettszo.Length; i++)
            {
                if (rejtettszo[i] == tipp[i])
                {
                    eredmeny += rejtettszo[i];
                }
                else
                {
                    eredmeny += ".";
                }
            }
        }

        private static void feladat2()
        {
            Console.WriteLine("\n2. Feladat:");
            Console.WriteLine("Az eredmény: {0} {1} {2} {3} {4} {5} {6}", tippeles);
        }

        private static void feladat1()
        {
            List<string> szavak = new List<string> {"fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska", "farkas", "almafa", "babona", "gerinc", "dervis", "bagoly", "ecetes", "angyal", "boglya" };
            FileStream sr = new FileStream("szavak.txt", FileMode.Open);
            Console.WriteLine("1. Feladat: ");
            Console.WriteLine();
            StreamReader beolvas = new StreamReader(sr);
            while (!beolvas.EndOfStream)
            {
                string[] valaszt = beolvas.ReadLine().Split(' ');
                if(tippeles < rejtettszavak.Length)
                {
                    rejtettszavak[tippeles] = valaszt[0];
                    tippeles++;
                }
                else
                {
                    break;
                }
            }
            beolvas.Close();
            sr.Close();
        }
    }
}
