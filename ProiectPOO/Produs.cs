using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPOO
{
    public class Produs : Form1
    {
        public static int nrproduse;
        public string cod;
        public string denumire;
        public string descriere;
        public string categorie;
        public string pret;

        public Produs(string cod, string denumire, string descriere, string categorie, string pret)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.descriere = descriere;
            this.categorie = categorie;
            this.pret = pret;
            nrproduse++;
        }
    }

    public class ProdusAlimentar : Produs
    {
        public int valabilitate;
        public int catemaisunt;
        public static int nralimentare;

        public ProdusAlimentar(string cod, string denumire, string descriere, string categorie, string pret, string valabilitate, int catemaisunt) : base(cod, denumire, descriere, categorie, pret)
        {
            this.valabilitate = Convert.ToInt32(valabilitate);
            this.catemaisunt = catemaisunt;
            nralimentare++;
        }
    }

    public class ProdusNealimentar: Produs
    {
        public int garantie;
        public int catemaisunt;
       public static int nrnealimentare;

        public ProdusNealimentar(string cod, string denumire, string descriere, string categorie, string pret, string garantie, int catemaisunt): base(cod, denumire, descriere, categorie, pret)
        {
            this.garantie = Convert.ToInt32(garantie);
            this.catemaisunt = catemaisunt;
            nrnealimentare++;
        }
    }
}
