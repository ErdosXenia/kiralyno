using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiralyno
{
    class tabla
    {
        private char[,] T;
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        public tabla(char ch)//konstruktor
        {
            T = new char[8, 8];
            UresCella = ch; //<-- "ch" paraméter

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = UresCella;
                }
            }

        }

        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ", T[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Elhelyez(int N)
        {
            /*1. véletlen helyérték létrehozása
              - Random osztály [0,7]
              - véletlen sor és oszlop
              - elhelyezzük a 'K'-t csak akkor ha üres -> "#" 
            */

            //Házi: N db királynő elhelyezése

            Random rnd = new Random();
            int sor = rnd.Next(0, 8);
            int oszlop = rnd.Next(0, 8);


            
            if (T[sor,oszlop] == '#')
            {
                T[sor, oszlop] = 'K';
            }
        }

        public void FajlbaIr()
        {

        }

        



        public int UresOszlop()
        {
            return 0;
        }

        public int UresSor()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynő feladat");

            tabla t = new tabla('#');

            Console.WriteLine("Üres tábla:");
            t.Megjelenit();

            Random db = new Random();
            int szam = db.Next(0, 8);
            for (int i = 0; i < 8; i++)
            {
                t.Elhelyez(szam);
                Console.WriteLine();
                t.Megjelenit();
            }
            

            Console.ReadKey();
        }
    }
}
