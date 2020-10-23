using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;

namespace ProiectPOO
{
    public partial class CosCumparaturi : Form
    {
        List<Client> clienti;
        public CosCumparaturi()
        {
            InitializeComponent();
            clienti = new List<Client>();
        }
        void adaugainlista(string produs, TextBox cantitate, int produsedisponibile)
        {
            try
            {
                int isNumeric;
                if (int.TryParse(cantitate.Text, out isNumeric))//convertim numarul din stringul cantitate in int
                {
                    if (isNumeric <= 0 || isNumeric > produsedisponibile)
                        MessageBox.Show("Nu dispunem de atatea produse.");
                    else
                    {
                        TextBox adaugare = new TextBox();
                        adaugare.Width = 300;
                        adaugare.TextAlign = HorizontalAlignment.Center;
                        string produsadaugat2 = "Produsul :" + produs + " /" + cantitate.Text + " produse";
                        adaugare.Text = produsadaugat2;
                        CosCumparaturiFlow.Controls.Add(adaugare);


                    }

                }

                else throw new Exception("Valoare introdusa nu este valida .");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
       /* void citeste()
        {
            clienti.Clear();
            try
            {
                FileStream fs = new FileStream("clienti.txt", FileMode.Open, FileAccess.Read);
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
        }*/
       

        private void CosCumparaturi_Load(object sender, EventArgs e)
        {
            
            foreach (KeyValuePair<string,ProdusAlimentar> author in Administrator.Admin.ListAlimentar)
            {
                TextBox adauga = new TextBox();
                Button btnadauga=new Button();
                TextBox cantitate = new TextBox();
                Bitmap produs = new Bitmap(600, 100);
                System.Drawing.Font f2 = new System.Drawing.Font("Segoe UI", 10);

                using (Graphics gr = Graphics.FromImage(produs))
                {
                    gr.DrawString(author.Value.denumire, f2, Brushes.Black, 0, 0);
                }
                PictureBox lista = new PictureBox();
                lista.Height = 60;
                lista.Width = 550;
                lista.Image = produs;

                cantitate.Text = Convert.ToString(Administrator.Admin.MaiSuntAlimentare(author.Key));
                cantitate.TextAlign = HorizontalAlignment.Center;
                cantitate.Width = 110;
                cantitate.Height = 30;
                cantitate.Location = new Point(lista.Width-250, 10);
                lista.Controls.Add(cantitate);

                btnadauga.Text = "Adauga";
                btnadauga.ForeColor = Color.OrangeRed;
                btnadauga.Font = f2;
                btnadauga.Width = 90;
                btnadauga.Height = 30;
                btnadauga.Location = new Point(lista.Width-90 , 10);
                lista.Controls.Add(btnadauga);

                //folosim delegate pentru a incapsula o metoda 
                //exemplu public delegate void Del(string message)
                //am declarat un delegate cu numele Del care incapsuleaza o metoda care are un string ca argument si returneaza void
                btnadauga.Click += delegate { adaugainlista(author.Key, cantitate, Convert.ToInt32(author.Value.catemaisunt)); };

              
                ListaProduseFlow.Controls.Add(lista);
            }
            
        }

       
    }
}
