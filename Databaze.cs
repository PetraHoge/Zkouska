using System;
using System.Collections.Generic;
using System.Text;

namespace Zkouska
{
    internal class Databaze
    {// ulozeni pojistence, do listu

        List<Clovek> lidi;


        public Databaze()
        {
            lidi = new List<Clovek>()
            {
                new Clovek("Jan", "Novak", 50, "+420 123 123 123"),
                new Clovek("Eva", "Adamova",40, "+420 321 321 321") 
            };


        }
        
        //pridat cloveka 1.
        public void Pridat(Clovek c)
        {
            lidi.Add(c);
           
                   
        }

        // vypis 2.
        public void Vypis()
        {
          foreach (Clovek c in lidi)
                   Console.WriteLine(c);
        } 
       


            //najdi 3.
        public Clovek NajdiPojistence(string jmeno, string prijmeni)
        {
            //  vyhledat podle jmena a prijmeni

            // vyhledani pojistencu
           
            Clovek clovek = lidi.Find(clovek => clovek.Jmeno == jmeno && clovek.Prijmeni == prijmeni);
            return clovek;

           
        }

    }
}






