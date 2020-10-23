using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProiectPOO
{
    public partial class VizualizareClienti : Form
    {
        List<Client> clienti;
        public VizualizareClienti()
        {
            InitializeComponent();
            clienti = new List<Client>();
        }
        void citeste(String cale)
        {
            clienti.Clear();
            try
            {
                FileStream fs = new FileStream(cale, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                for (; ; )
                {
                    String linie = sr.ReadLine();
                    if (linie == null) break;
                    String[] separator = linie.Split('/');// Split creaza un tablou de siruri de caractere pe baza separatorului dat
                    int pos = separator[0].IndexOf("|");//IndexOf intoarce indexul elementului specificat
                    if (separator[1].StartsWith(" ")) separator[1] = separator[1].Substring(1).Trim();
                    clienti.Add(new Client(separator[0].Substring(0, pos), separator[0].Substring(pos + 1), separator[1], separator[2], separator[3]));
                }
                sr.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Fisierul nu are formatul corespunzator", "Atentie");
            }
        }
        void afiseaza()
        {
            l1.Items.Clear();
            for (int i = 0; i < clienti.Count; i++)
                l1.Items.Add(clienti[i].Nume + " " + clienti[i].Prenume + ", " + clienti[i].Adresa);
        }
        void cauta_clienti()
        {
            l1.Items.Clear();
            for (int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Nume.ToLower().IndexOf(filtru.Text.ToLower().Trim()) >= 0 || clienti[i].Prenume.ToLower().IndexOf(filtru.Text.ToLower().Trim()) >= 0)
                {
                    //Trim, TrimEnd, TrimStart pentru eliminarea spatiilor dintr-un sir de caractere
                    l1.Items.Add(clienti[i].Nume + " " + clienti[i].Prenume + ", " + clienti[i].Adresa);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void VizualizareClienti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cauta_clienti();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            of.InitialDirectory = Directory.GetCurrentDirectory();
            of.FileName = "";
            of.Filter = "Text file|*.txt";//stabilim filtrul
            of.ShowDialog();
            citeste(of.FileName);
        }

        private void listeaza_Click(object sender, EventArgs e)
        {
            afiseaza();
        }

        private void of_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
