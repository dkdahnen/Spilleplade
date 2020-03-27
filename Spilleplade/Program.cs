

using System;

namespace Spilleplade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******     START     *****");
            Terning T1 = new Terning("basic",10);
            Terning T2 = new Terning("advance",20);
            Terning T3 = new Terning("advance", 30);

            T1.Kast();
            T2.Kast();
            T3.Kast();

            Console.WriteLine("---------  SLUT PRUT     -------");
            Console.WriteLine("xx");
        }
    }
    class Terning
    {
        public int Antal_kast { get; private set; }
        public string Navn_Simulering { get; private set; }

        public Terning(string navn, int antal_kast)
        {
            // klasse initiering
            this.Antal_kast = antal_kast;
            this.Navn_Simulering = navn;
        }

        public void Kast() 
        {
            int k;
            float SandSyn = 0 ;
            float forekomst = 0;
            int[] stat = new int[10];
            float Min;
            float Max;
            float Diff;

            Random Minrand = new Random();

            for (int i = 0; i < this.Antal_kast; i++)

            {
                k = Minrand.Next(1, 7);
                stat[k]++; 
             //   Console.WriteLine("Kast nr " + i + " " + k + " " + "SLUT");
            }
        
            Console.WriteLine("---------  statistik     -------" + this.Navn_Simulering);
            Console.WriteLine("Antal kast: " + Antal_kast.ToString("N0"));
            Min = 99;
            Max = 0;

            for (int i = 1; i < 7; i++)
            {
                k = i + 1;
                forekomst = stat[i] ;
                SandSyn = forekomst / Antal_kast;
                Console.WriteLine("Terning " + i + " : " + stat[i].ToString("N0") + " " + "SandSyn : " + SandSyn.ToString("N5"));
                if (SandSyn < Min)
                    { Min = SandSyn; }
                if (SandSyn > Max)
                { Max = SandSyn; }
            }
            Diff = Max - Min;
            Console.WriteLine("Ant kast  : " + Antal_kast.ToString("N0")
                    +         "  Afv   : " + Diff.ToString("E4")
                );
            
            Console.WriteLine("Minimum   : " + Min.ToString("N3")
                           +  "  Max   : " + Max.ToString("N3"));
            
        }


    }
}
