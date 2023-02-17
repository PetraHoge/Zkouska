using System;
using System.Collections.Generic;
using System.Text;

namespace Zkouska
{
    public class Clovek
    {
        public string Jmeno;
        public string Prijmeni;
        public int Vek;
        public string TelefonniCislo;

        public Clovek(string Jmeno, string Prijmeni, int Vek, string TelefonniCislo)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Vek = Vek;
            this.TelefonniCislo = TelefonniCislo;
        }

        public override string ToString()
        {
            return $"{Jmeno}\t {Prijmeni}\t{Vek}\t{TelefonniCislo}";
            
        }


 }   }
     




        
    

     
