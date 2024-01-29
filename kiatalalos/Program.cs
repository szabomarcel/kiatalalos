using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kiatalalos
{
    internal class Program
    {

        public struct jegyrekord
        {
            public string rejtettszo;
            public string tipp;
            public string valasz;
        }
        static int tippeles = 0;
        static jegyrekord[] tejtettszavak = new jegyrekord[2000];
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
            throw new NotImplementedException();
        }

        private static void feladat3()
        {
            Console.WriteLine("3. Feladat:");
            for (int i = 0; i < tippeles; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("3 tippeléssel sikerült kitalálni");
                }               
            }
        }

        private static void feladat2()
        {
            Console.WriteLine("2. Feladat:");
            Console.WriteLine("Az eredmény: {0} {1} {2} {3} {4} {5} {6}", tippeles);
        }

        private static void feladat1()
        {
            FileStream sr = new FileStream("szavak.txt", FileMode.Open);
            Console.WriteLine("1. Feladat: ");
            Console.WriteLine();
            StreamReader beolvas = new StreamReader(sr);
            while (!beolvas.EndOfStream)
            {
                string[] valaszt = beolvas.ReadLine().Split(' ');
                
            }
            beolvas.Close();
            sr.Close();
        }
    }
}
