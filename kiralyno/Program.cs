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
            for (int i = 0; i < N; i++)
            {
                int sor = rnd.Next(0, 8);
                int oszlop = rnd.Next(0, 8);

                while (T[sor, oszlop] == 'K')
                {
                    sor = rnd.Next(0, 8);
                    oszlop = rnd.Next(0, 8);
                }
                T[sor, oszlop] = 'K';

            }
            
        }

        public void FajlbaIr()
        {

        }

        



        public bool UresOszlop(int oszlop)
        {
            int j = 0;
            for (int i = 0; i < oszlop; i++)
            {
                while (j < oszlop && T[j, oszlop] != 'K')
                {
                    if (j < oszlop)
                    {
                        return true;
                    }
                }
            }
            
        }

        public bool UresSor(int sor)
        {
            
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

            t.Elhelyez(8);
            Console.WriteLine();
            t.Megjelenit();
            

            Console.ReadKey();
        }
    }
}
