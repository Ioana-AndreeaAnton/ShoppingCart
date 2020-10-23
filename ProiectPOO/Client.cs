using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPOO
{
    public class Client:Form1
     {
            public String nume;
            public String prenume;
            public String adresa;
            public String banca;
            public String cont;
            public int id;

            public Client(String nume, String prenume, String adresa, String banca, String cont)
            {
                this.nume = nume;
                this.prenume = prenume;
                this.adresa = adresa;
                this.banca = banca;
                this.cont = cont;
                id = nrclienti;
                nrclienti++;

            }
            public String Nume
            {
                get { return nume; }
                set { this.nume = value; }
            }
            public String Prenume
            {
                get { return prenume; }
                set { this.prenume = value; }
            }
            public String Adresa
            {
                get { return adresa; }
                set { this.adresa = value; }
            }
            public String Banca
            {
                get { return banca; }
                set { this.banca = value; }
            }
            public String Cont
            {
                get { return cont; }
                set { this.cont = value; }
            }
            public static bool operator <=(Client C1, Client C2)
            {
                return String.Compare(C1.nume, C2.nume) <= 0;
            }
        public static bool operator >=(Client C1, Client C2)
        {
            return String.Compare(C1.nume, C2.nume) >= 0;
        }

        }
    }
