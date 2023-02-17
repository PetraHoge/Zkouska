using System;

namespace Zkouska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("EVIDENCE POJISTENYCH");
            Console.WriteLine("----------------------");

            Databaze databaze = new Databaze();

            while (true)

            {
                Console.WriteLine("Vyber si akci:");
                Console.WriteLine("1 - pridat noveho pojistence");
                Console.WriteLine("2 - vypsat vsechny pojistence");
                Console.WriteLine("3 - vyhledat pojistence");
                Console.WriteLine("4 - konec");

                int volba = int.Parse(Console.ReadLine());
                if (volba == 4)
                    break;

                if (volba > 0 && volba < 4)
                {
                    switch (volba)
                    {
                        case 1:  //pridat
                            Console.WriteLine("Pridat noveho pojistence");
                            Console.WriteLine("Zadejte jmeno:");
                            string jmeno = Console.ReadLine();
                            Console.WriteLine("Zadejte prijmeni:");
                            string prijmeni = Console.ReadLine();
                            Console.WriteLine("Zadejte vek:");
                            int vek = int.Parse(Console.ReadLine());

                            Console.WriteLine("Zadejte telefon:");

                            string telefonniCislo = Console.ReadLine();
                            databaze.Pridat(new Clovek (jmeno, prijmeni, vek, telefonniCislo));
                            Console.WriteLine("Data byla ulozena, muzete pokracovat");
                            break;

                        case 2: //Vypsat vsechny pojistence
                                
                            Console.WriteLine("Vypis vsech pojistencu");
                            databaze.Vypis();
                            break;

                        case 3: //vyhledat
                                // funguje,pouze na vypsane lidi (2 osoby) v databazi v okne databaze 
                            Console.WriteLine("Vyhledat pojistence");
                            Console.WriteLine("Zadejte jmeno:");
                            string jmeno2 = Console.ReadLine();
                            Console.WriteLine("Zadejte prijmeni:");
                            string prijmeni2 = Console.ReadLine();
                            Clovek clovek = databaze.NajdiPojistence (jmeno2, prijmeni2);
                            Console.WriteLine(clovek.ToString());
                            break;
                    }
                }
                else
                    Console.WriteLine("neplatna volba, zadej 1 az 4");
            }
            Console.WriteLine("Dekuji za pouziti programu. Program se ukonci libovolnou klavesou");
            Console.ReadLine();
        }
    }
}

            
        
    

