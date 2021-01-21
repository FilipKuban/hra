using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hra_sibenice_konzole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] slova = new string[6];

            slova[0] = "letadlo";
            slova[1] = "automobil";
            slova[2] = "fotoaparat";
            slova[3] = "lokomotiva";
            slova[4] = "televize";
            slova[5] = "verliba";

            int celkoveSkore = 0;

            for (int A = 0; A < slova.Length; A++)
            {
                bool hraProbiha = true;
                string hadaneSlovo = slova[A];
                int zbyvajiciPokusy = 10;
                int uhodnutaPismena = 0;
                char hadanyZnak;
                char[] znakySlova = new char[hadaneSlovo.Length];

            int puvodniPocet = uhodnutaPismena;

                for (int I = 0; I < hadaneSlovo.Length; I++)
                {
                    znakySlova[I] = '*';
                }
                bool hraPokracuje = true;

                while (hraProbiha)
                {
                    Console.WriteLine(znakySlova);
                    Console.WriteLine("Zadej pismeno, zbyva ti " + zbyvajiciPokusy + " pokusu");
                    string zadnyText = Console.ReadLine();
                    if (zadnyText.Length == 0)
                    {
                        continue;
                    }
                    hadanyZnak = zadnyText[0];
                    zbyvajiciPokusy--;
                    for (int I = 0; I < znakySlova.Length; I++)
                    {
                        if (znakySlova[I] == '*')
                        {
                            if (hadaneSlovo[I] == hadanyZnak)
                            {
                                znakySlova[I] = hadanyZnak;
                                uhodnutaPismena++;
                                zbyvajiciPokusy++;
                                celkoveSkore++;
                            }
                        }
                    }

                    if (puvodniPocet == uhodnutaPismena)
                    {
                        celkoveSkore--;
                    }

                    if (zbyvajiciPokusy == 0 || uhodnutaPismena == hadaneSlovo.Length)
                    {
                        hraProbiha = false;
                    }
                }
                if (zbyvajiciPokusy == 0)
                {
                    Console.WriteLine("Prohra");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Vyhra \n Celkove skore: "+ celkoveSkore);
                }
                Console.ReadKey();
            }
        }
    }
}
