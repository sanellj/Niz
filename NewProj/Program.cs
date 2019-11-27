using System;

namespace NewProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Niz
            Cas_Niz();
            Console.ReadKey();
        }
            static void Cas_Niz()
        {
            //deklaracije niza 
            int[] clanovi = new int[10];
            double[] stanje = { 1234.56, 789.12 };
            int[] poeni = new int[3] { 5, 10, 19 };

            //pristupanje clanovima niza kroz for petlju
            for (int i = 0; i < 10; i++) {
                clanovi[i] = i * 10;
            }

            //ispisivanje clanova niza kroz for petlju
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Vrijednost elementa clanovi[{0}] = {1}", clanovi[i]);
            }
            
            //koriscenje foreach petlje
            foreach(int clan in clanovi) { 
                Console.WriteLine("Vrijednost elemenata {0}", clan);
            }
        }
    }
}
