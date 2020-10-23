using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProiectPOO
{
    class Administrator
    {
        public static Administrator admin;//o singura instanta care este disponibila oriunde in aplicatie
        //o singura instanta controleza progtamul

        private Administrator() { }

        public static Administrator Admin //metoda statica care returneaza o referinta a instantei
        {
            get
            {
                if (admin == null)
                {
                    admin = new Administrator();
                }
                return admin;
            }
        }

        public Dictionary<string,ProdusAlimentar> ListAlimentar = new Dictionary<string,ProdusAlimentar>();
        public Dictionary<string,ProdusNealimentar> ListNealimentar = new Dictionary<string,ProdusNealimentar>();

        public void alimentare()
        {
            try
            {
                string a, b, c, d, e, f;
                int g;//cate mai sunt
                FileStream fs2 = null;
                StreamReader sr2 = null;
                fs2 = new FileStream("alimentare.txt", FileMode.Open, FileAccess.Read);
                sr2 = new StreamReader(fs2);
                string linie;
                if (new FileInfo("alimentare.txt").Length == 0)
                    throw new Exception("Nu s-au gasit produse alimentare in depozit");
                else
                    for (int j = 0; j < 100; j++)
                    {
                        linie = sr2.ReadLine();
                        if (string.IsNullOrEmpty(linie))
                            break;
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        a = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));//codul produsului
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        b= Convert.ToString(linie.Substring(0, linie.IndexOf(";")));//denumirea produsului
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        c= Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        d = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        e = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        f = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        g = Convert.ToInt32(linie.Substring(0, linie.IndexOf(";")));

                        ProdusAlimentar PrAlimentar = new ProdusAlimentar(a, b, c, d, e, f, g);
                        ListAlimentar.Add(a,PrAlimentar);
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare la citirea produselor alimentare" + ex.Message);
            }
            finally { }
        }

        public string MaiSuntAlimentare(string cod)
        {
            foreach(KeyValuePair<string,ProdusAlimentar> author in ListAlimentar)
            {
                if (author.Key == cod)
                {
                    if (author.Value.catemaisunt > 0)
                    {
                        return ("Mai sunt " + author.Value.catemaisunt + " produse");
                    }
                }
            }
            return ("Produsul nu se mai afla in stoc");
        }

        public void nealimentare()
        {
            try
            {
                string a, b, c, d, e, f;
                int g;//cate mai sunt
                FileStream fs = null;
                StreamReader sr = null;
                fs = new FileStream("nealimentare.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string linie;
                if (new FileInfo("nealimentare.txt").Length == 0)
                    throw new Exception("Nu s-au gasit produse nealimentare in depozit");
                else for (int j = 0; j < 100; j++)
                    {
                        linie = sr.ReadLine();
                        if (string.IsNullOrEmpty(linie))
                            break;
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        a = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));//codul produsului
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        b = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));//denumirea produsului
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        c = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        d = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        e = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        f = Convert.ToString(linie.Substring(0, linie.IndexOf(";")));
                        linie = linie.Substring(linie.IndexOf("*") + 1);
                        g = Convert.ToInt32(linie.Substring(0, linie.IndexOf(";")));

                        ProdusNealimentar PrNealimentar = new ProdusNealimentar(a, b, c, d, e, f, g);
                        ListNealimentar.Add(a, PrNealimentar);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea produselor nealimentare" + ex.Message);
            }
            finally { }
        }
        public string MaiSuntNealimentare(string cod)
        {
            foreach (KeyValuePair<string, ProdusNealimentar> author in ListNealimentar)
            {
                if (author.Key == cod)
                {
                    if (author.Value.catemaisunt > 0)
                    {
                        return ("Mai sunt " + author.Value.catemaisunt + " produse");
                    }
                }
            }
            return ("Produsul nu se mai afla in stoc");
        }
    }
}
