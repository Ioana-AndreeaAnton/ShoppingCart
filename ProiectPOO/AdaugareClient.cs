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
    public partial class AdaugareClient : Form
    {
        public AdaugareClient()
        {
            InitializeComponent();
        }




        private void nume_TextChanged(object sender, EventArgs e)
        {
            if (nume.Text.Trim().Length > 0)
            {
                if (prenume.Text.Trim().Length > 0)
                {
                    if (adresa.Text.Trim().Length > 0)
                    {
                        if (banca.Text.Trim().Length > 0)
                        {
                            if (cont.Text.Trim().Length > 0)
                            {
                                button1.Enabled = true;
                            }
                            else button1.Enabled = false;
                        }
                        else button1.Enabled = false;
                    }
                    else button1.Enabled = false;
                }
                else button1.Enabled = false;
            }
            else button1.Enabled = false;
        }

        private void prenume_TextChanged(object sender, EventArgs e)
        {
            nume_TextChanged(sender, e);
        }

        private void adresa_TextChanged(object sender, EventArgs e)
        {
            nume_TextChanged(sender, e);
        }

        private void banca_TextChanged(object sender, EventArgs e)
        {
            nume_TextChanged(sender, e);
        }

        private void cont_TextChanged(object sender, EventArgs e)
        {
            nume_TextChanged(sender, e);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream("Clienti.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(nume.Text);
                sw.Write("|");
                sw.Write(prenume.Text);
                sw.Write("/");
                sw.Write(adresa.Text);
                sw.Write("/");
                sw.Write(banca.Text);
                sw.Write("/");
                sw.Write(cont.Text);
                sw.WriteLine();
                sw.Flush();
                sw.Close();
                this.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Eroare la scriere in fisiere");
            }
        }
    }
}
