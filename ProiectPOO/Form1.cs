using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//functionalitatea de baza
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;

namespace ProiectPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //lista clienti
      //  static Dictionary<int, Client> ListClienti = new Dictionary<int, Client>();

       // static public int nrproduse = 0;
       static public int nrclienti = 0;
        //static public int nralimentare = 0;
        //static public int nrnealimentare = 0;
        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // FileStream fs = null;
            //StreamReader sr = null;
            // string a, b, c, d, f, g, h;

            produseFlow.FlowDirection = FlowDirection.TopDown;

            Administrator.Admin.alimentare();
            Administrator.Admin.nealimentare();

            
            
           
        }
        public static Bitmap AfisareCodgrafic(string cod)
        {
            
            System.Drawing.Font f = new System.Drawing.Font("Times New Roman", 12);

            //ean8
            string ean13pas2 = "";

            if (cod.Length == 8|| cod.Length == 13)
            {
                for (int i = 0; i < cod.Length; i++)
                {
                    if (!(cod[i] >= 48 && cod[i] <= 57))//Important! Conditie pentru a fi cifre
                    {
                        Bitmap error = new Bitmap(230, 200);

                        using (Graphics eroare = Graphics.FromImage(error))
                        {

                            eroare.DrawString("Cod eronat.", f, Brushes.Blue, 30, 30);//scriem textul in locul specificat folosind un Font si un Brush
                            return error;
                        }
                    }
                }
                if ( cod.Length == 8)
                {
                    int sum8impare = 0;//vom calcula suma numerelor de pe pozitii impare
                    int sum8pare = 0;//vom calcula suma numerelor de pe pozitii pare
                    for (int i = 0; i < cod.Length - 1; i++)//ultimul numar nu se ia in calcul, acesta fiind numarul de verificare
                    {
                        if (!(i % 2 == 0))//daca pozitia este para se adauga in suma numerelor de pe pozitii pare
                            sum8pare = sum8pare + (cod[i] - 48);//am calculat suma numerelor de pe pozitii pare
                        else sum8impare += cod[i] - 48;//am calculat suma numerelor de pe pozitii impare

                    }

                    int pas1 = 3 * sum8impare + sum8pare;//la pasul 1 ni se spune sa calculam de 3 ori suma de pe pozitii impare + suma de pe pozitii pare
                    int pas2 = pas1;


                    switch (pas1 % 10)
                    {
                        case 1: { pas2 = pas1 + 9; break; }
                        case 2: { pas2 = pas1 + 8; break; }
                        case 3: { pas2 = pas1 + 7; break; }
                        case 4: { pas2 = pas1 + 6; break; }
                        case 5: { pas2 = pas1 + 5; break; }
                        case 6: { pas2 = pas1 + 4; break; }
                        case 7: { pas2 = pas1 + 5; break; }
                        case 8: { pas2 = pas1 + 2; break; }
                        case 9: { pas2 = pas1 + 1; break; }

                    }

                    if (pas2 - pas1 == (cod[cod.Length - 1] - 48))//verificam  daca diferenta ditre cei doi pasi este ultima cifra din cod
                                                                  //doar in felul acesta valoarea data este valida
                    {
                        string unusizeo = "";
                        unusizeo = unusizeo + "101";//se adauga 101 marcajului de start

                        for (int i = 0; i < cod.Length; i++)
                        {
                            if (i < 4) //corespunzatro coloanei L adica pentru primele 4 cifre
                                switch (cod[i] - 48) //tot cum o dam, tot valoarea din ascii o avem si de aceea trebuie sa scadem 
                                {
                                    case 0: { unusizeo = unusizeo + "0001101"; break; } //daca est 0 se adauga sirul de 7 biti pe care il citim din tabel
                                    case 1: { unusizeo = unusizeo + "0011001"; break; } //daca este 1
                                    case 2: { unusizeo = unusizeo + "0010011"; break; } //daca este 2
                                    case 3: { unusizeo = unusizeo + "0111101"; break; } //daca este 3
                                    case 4: { unusizeo = unusizeo + "0100011"; break; } //daca este 4
                                    case 5: { unusizeo = unusizeo + "0110001"; break; } //daca este 5
                                    case 6: { unusizeo = unusizeo + "0101111"; break; } //daca este 6
                                    case 7: { unusizeo = unusizeo + "0111011"; break; } //daca este 7
                                    case 8: { unusizeo = unusizeo + "0110111"; break; } //daca este 8
                                    case 9: { unusizeo = unusizeo + "0001011"; break; } //daca este 9

                                }

                            if (i == 4)
                                unusizeo = unusizeo + "01010"; //corespunzator marcajului de la mijloc
                            if (i >= 4)
                                switch (cod[i] - 48) //corespunzator coloanei R adica pentru ultimile 4 cifre
                                {
                                    case 0: { unusizeo = unusizeo + "1110010"; break; }
                                    case 1: { unusizeo = unusizeo + "1100110"; break; }
                                    case 2: { unusizeo = unusizeo + "1101100"; break; }
                                    case 3: { unusizeo = unusizeo + "1000010"; break; }
                                    case 4: { unusizeo = unusizeo + "1011100"; break; }
                                    case 5: { unusizeo = unusizeo + "1001110"; break; }
                                    case 6: { unusizeo = unusizeo + "1010000"; break; }
                                    case 7: { unusizeo = unusizeo + "1000100"; break; }
                                    case 8: { unusizeo = unusizeo + "1001000"; break; }
                                    case 9: { unusizeo = unusizeo + "1110100"; break; }

                                }
                        }
                        unusizeo = unusizeo + "101"; //se adauga 101 corespunzator marcajului de final
                        Bitmap cod2Dean8 = new Bitmap(230, 120);

                        //desenam codul de bare prin linii verticale de latimi egale
                        //o linie neagra pentru 1
                        //o linie alba pentru 0
                        using (Graphics cd = Graphics.FromImage(cod2Dean8))
                        {
                            for (int i = 0; i < 2 * unusizeo.Length; i += 2)
                            {//mergem pana la jumatate
                                if (i / 2 == 33 || i / 2 == 34 || i / 2 == 31 || i / 2 == 32)//pozitiile 33 34 32 pentru ca ele sunt cele mai lungi
                                {
                                    if (unusizeo[i / 2] == 49)//codul ASCII pentru 1
                                        cd.DrawLine(new Pen(Color.Black, 2), i + 50, 10, i + 50, 100);//daca este 1 desenam cu negru
                                    else cd.DrawLine(new Pen(Color.Gainsboro, 2), i + 50, 10, i + 50, 100);//altfel, desenam cu alb
                                }
                                else
                                {
                                    if (unusizeo[i / 2] == 49)
                                    {
                                        if (i / 2 < 3 || i / 2 > 62)//cati de 0 si 1 intra in sir
                                            cd.DrawLine(new Pen(Color.Black, 2), i + 50, 10, i + 50, 100);
                                        else cd.DrawLine(new Pen(Color.Black, 2), i + 50, 10, i + 50, 90);
                                    }
                                    else
                                    {
                                        if (i / 2 < 3 || i / 2 > 62)
                                            cd.DrawLine(new Pen(Color.Gainsboro, 2), i + 50, 10, i + 50, 100);
                                        else cd.DrawLine(new Pen(Color.Gainsboro, 2), i + 50, 10, i + 50, 90);
                                    }
                                }
                            }
                            cd.DrawString(Convert.ToString(cod[0] - 48) + " " + Convert.ToString(cod[1] - 48) + " " + Convert.ToString(cod[2] - 48) + " " + Convert.ToString(cod[3] - 48), f, Brushes.Black, 55, 90);
                            cd.DrawString(Convert.ToString(cod[4] - 48) + " " + Convert.ToString(cod[5] - 48) + " " + Convert.ToString(cod[6] - 48) + " " + Convert.ToString(cod[7] - 48), f, Brushes.Black, 126, 90);
                        }

                        return cod2Dean8;


                    }
                    else
                    {

                        Bitmap error = new Bitmap(230, 120);

                        using (Graphics eroare = Graphics.FromImage(error))
                        {

                            eroare.DrawString("Cod eronat.", f, Brushes.Black, 30, 30);

                            return error;
                        }
                    }


                }
                //ean 13








                if (cod.Length == 12 || cod.Length == 13)
                {
                    int sum13impare = 0;
                    int sum13pare = 0;






                    for (int i = 0; i < cod.Length - 1; i++)
                    {
                        if (!(i % 2 == 0))
                            sum13pare = sum13pare + (cod[i] - 48);
                        else sum13impare += cod[i] - 48;

                    }
                    // MessageBox.Show(Convert.ToString(sum13impare) + " " + Convert.ToString(sum13pare));

                    int pas1 = sum13impare + 3 * sum13pare;
                    int pas11 = pas1;


                    switch (pas1 % 10)
                    {
                        case 1: { pas11 = pas1 + 9; break; }
                        case 2: { pas11 = pas1 + 8; break; }
                        case 3: { pas11 = pas1 + 7; break; }
                        case 4: { pas11 = pas1 + 6; break; }
                        case 5: { pas11 = pas1 + 5; break; }
                        case 6: { pas11 = pas1 + 4; break; }
                        case 7: { pas11 = pas1 + 5; break; }
                        case 8: { pas11 = pas1 + 2; break; }
                        case 9: { pas11 = pas1 + 1; break; }

                    }

                    if (pas11 - pas1 == (cod[cod.Length - 1] - 48))
                    {
                        switch (cod[0] - 48)
                        {
                            case 0: { ean13pas2 = "LLLLLLRRRRRR"; break; }
                            case 1: { ean13pas2 = "LLGLGGRRRRRR"; break; }
                            case 2: { ean13pas2 = "LLGGLGRRRRRR"; break; }
                            case 3: { ean13pas2 = "LLGGGLRRRRRR"; break; }
                            case 4: { ean13pas2 = "LGLLGGRRRRRR"; break; }
                            case 5: { ean13pas2 = "LGGLLGRRRRRR"; break; }
                            case 6: { ean13pas2 = "LGGGLLRRRRRR"; break; }
                            case 7: { ean13pas2 = "LGLGLGRRRRRR"; break; }
                            case 8: { ean13pas2 = "LGLGGLRRRRRR"; break; }
                            case 9: { ean13pas2 = "LGGLGLRRRRRR"; break; }


                        }
                        string unusizeo13 = "101";

                        for (int i = 1; i < cod.Length; i++)
                        {
                            if (i <= 6)
                            {
                                if (ean13pas2[i - 1] == 'L')
                                    switch (cod[i] - 48)
                                    {
                                        case 0: { unusizeo13 = unusizeo13 + "0001101"; break; }
                                        case 1: { unusizeo13 = unusizeo13 + "0011001"; break; }
                                        case 2: { unusizeo13 = unusizeo13 + "0010011"; break; }
                                        case 3: { unusizeo13 = unusizeo13 + "0111101"; break; }
                                        case 4: { unusizeo13 = unusizeo13 + "0100011"; break; }
                                        case 5: { unusizeo13 = unusizeo13 + "0110001"; break; }
                                        case 6: { unusizeo13 = unusizeo13 + "0101111"; break; }
                                        case 7: { unusizeo13 = unusizeo13 + "0111011"; break; }
                                        case 8: { unusizeo13 = unusizeo13 + "0110111"; break; }
                                        case 9: { unusizeo13 = unusizeo13 + "0001011"; break; }

                                    }
                                else
                                {
                                    switch (cod[i] - 48)
                                    {
                                        case 0: { unusizeo13 = unusizeo13 + "0100111"; break; }
                                        case 1: { unusizeo13 = unusizeo13 + "0110011"; break; }
                                        case 2: { unusizeo13 = unusizeo13 + "0011011"; break; }
                                        case 3: { unusizeo13 = unusizeo13 + "0100001"; break; }
                                        case 4: { unusizeo13 = unusizeo13 + "0011101"; break; }
                                        case 5: { unusizeo13 = unusizeo13 + "0111001"; break; }
                                        case 6: { unusizeo13 = unusizeo13 + "0000101"; break; }
                                        case 7: { unusizeo13 = unusizeo13 + "0010001"; break; }
                                        case 8: { unusizeo13 = unusizeo13 + "0001001"; break; }
                                        case 9: { unusizeo13 = unusizeo13 + "0010111"; break; }

                                    }
                                }

                            }
                            if (i == 6)
                                unusizeo13 = unusizeo13 + "01010";
                            if (i > 6)
                            {
                                switch (cod[i] - 48)
                                {
                                    case 0: { unusizeo13 = unusizeo13 + "1110010"; break; }
                                    case 1: { unusizeo13 = unusizeo13 + "1100110"; break; }
                                    case 2: { unusizeo13 = unusizeo13 + "1101100"; break; }
                                    case 3: { unusizeo13 = unusizeo13 + "1000010"; break; }
                                    case 4: { unusizeo13 = unusizeo13 + "1011100"; break; }
                                    case 5: { unusizeo13 = unusizeo13 + "1001110"; break; }
                                    case 6: { unusizeo13 = unusizeo13 + "1010000"; break; }
                                    case 7: { unusizeo13 = unusizeo13 + "1000100"; break; }
                                    case 8: { unusizeo13 = unusizeo13 + "1001000"; break; }
                                    case 9: { unusizeo13 = unusizeo13 + "1110100"; break; }

                                }
                            }

                        }
                        unusizeo13 += "101";

                        Bitmap cod2Dean13 = new Bitmap(230, 120);

                        using (Graphics cd = Graphics.FromImage(cod2Dean13))
                        {
                            for (int i = 0; i < 2 * unusizeo13.Length; i += 2)
                            {
                                if (i / 2 == 45 || i / 2 == 46 || i / 2 == 47 || i / 2 == 48)
                                {
                                    if (unusizeo13[i / 2] == 49)
                                        cd.DrawLine(new Pen(Color.Black, 2), i + 25, 10, i + 25, 100);
                                    else cd.DrawLine(new Pen(Color.Gainsboro, 2), i + 25, 10, i + 25, 100);
                                }
                                else
                                {
                                    if (unusizeo13[i / 2] == 49)
                                    {
                                        if (i / 2 < 4 || i / 2 > 91)
                                            cd.DrawLine(new Pen(Color.Black, 2), i + 25, 10, i + 25, 100);
                                        else cd.DrawLine(new Pen(Color.Black, 2), i + 25, 10, i + 25, 90);
                                    }
                                    else
                                    {
                                        if (i / 2 < 4 || i / 2 > 91)
                                            cd.DrawLine(new Pen(Color.Gainsboro, 2), i + 25, 10, i + 25, 100);
                                        else cd.DrawLine(new Pen(Color.Gainsboro, 2), i + 25, 10, i + 25, 90);
                                    }
                                }
                            }
                            cd.DrawString(Convert.ToString(cod[1] - 48) + " " + Convert.ToString(cod[2] - 48) + " " + Convert.ToString(cod[3] - 48) + " " + Convert.ToString(cod[4] - 48) + " " + Convert.ToString(cod[5] - 48) + " " + Convert.ToString(cod[6] - 48), f, Brushes.Black, 35, 90);
                            cd.DrawString(Convert.ToString(cod[7] - 48) + " " + Convert.ToString(cod[8] - 48) + " " + Convert.ToString(cod[9] - 48) + " " + Convert.ToString(cod[10] - 48) + " " + Convert.ToString(cod[11] - 48) + " " + Convert.ToString(cod[12] - 48), f, Brushes.Black, 130, 90);
                            cd.DrawString(Convert.ToString(cod[0]), f, Brushes.Black, 8, 90);
                        }

                        return cod2Dean13;

                    }
                }


                Bitmap error2 = new Bitmap(230, 120);

                using (Graphics eroare2 = Graphics.FromImage(error2))
                {

                    eroare2.DrawString("Codul eronat.", f, Brushes.Red, 30, 30);
                    //eroare.drawString("Cod eronat.", f, Brushes.Blue, 30, 30);
                    return error2;
                }
            }


            else
            {
                Bitmap error = new Bitmap(230, 120);

                using (Graphics eroare = Graphics.FromImage(error))
                {

                    eroare.DrawString("Codul eronat.", f, Brushes.Blue, 30, 30);
                    //eroare.drawString("Cod eronat.", f, Brushes.Blue, 30, 30);
                    return error;
                }

            }

        }

        private void AdaugaClient_Click(object sender, EventArgs e)
        {
            AdaugareClient hello = new AdaugareClient();
            hello.ShowDialog();
        }

        private void VeziClienti_Click(object sender, EventArgs e)
        {
            VizualizareClienti hello = new VizualizareClienti();
            hello.ShowDialog();
        }


        private void ProdusAlimentarButton_Click(object sender, EventArgs e)
        {
            produseflow2.Controls.Clear();
            foreach(KeyValuePair<string, ProdusAlimentar> author in Administrator.Admin.ListAlimentar)
            {
                Panel panel = new Panel();
                

                Bitmap bmp = new Bitmap(1000, 300);

                System.Drawing.Font f = new System.Drawing.Font("Segoe UI", 12);

                using(Graphics gr = Graphics.FromImage(bmp))
                {
                    Bitmap bm2 = AfisareCodgrafic(author.Value.cod);
                    Rectangle r = new Rectangle(10, 10, 300, 150);
                    gr.DrawImage(bm2,r);
                    gr.DrawString("Cod produs: " + Convert.ToString(author.Value.cod), f, Brushes.OrangeRed, 350, 0);
                    gr.DrawString("Nume Produs: "+ Convert.ToString(author.Value.denumire), f, Brushes.Black,350, 20);
                    gr.DrawString("Descriere Produs: " + Convert.ToString(author.Value.descriere), f, Brushes.Black,350, 40);
                    gr.DrawString("Categorie Produs: " + Convert.ToString(author.Value.categorie), f, Brushes.Black,350, 60);
                    gr.DrawString("Pret Produs: " + Convert.ToString(author.Value.pret), f, Brushes.Black, 350, 80);
                    gr.DrawString("Valabilitate Produs: " + Convert.ToString(author.Value.valabilitate)+" luni", f, Brushes.Black, 350, 100);
                    gr.DrawString(Administrator.Admin.MaiSuntAlimentare(author.Key), f, Brushes.Black, 350,120 );
                }
                PictureBox produs = new PictureBox();
                produs.Width =1000 ;
                produs.Height = 200;
                produs.Image = bmp;
                produseflow2.Controls.Add(produs);
            }

        }

        private void ProdusNealimentarButton_Click(object sender, EventArgs e)
        {
            produseflow2.Controls.Clear();
            foreach (KeyValuePair<string, ProdusNealimentar> author in Administrator.Admin.ListNealimentar)
            {
                Panel panel = new Panel();


                Bitmap bmp = new Bitmap(1000, 300);

                System.Drawing.Font f = new System.Drawing.Font("Segoe UI", 12);

                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    Bitmap bm2 = AfisareCodgrafic(author.Value.cod);
                    Rectangle r = new Rectangle(10, 10, 300, 150);
                    gr.DrawImage(bm2, r);
                    gr.DrawString("Cod produs: " + Convert.ToString(author.Value.cod), f, Brushes.OrangeRed, 350, 0);
                    gr.DrawString("Nume Produs: " + Convert.ToString(author.Value.denumire), f, Brushes.Black, 350, 20);
                    gr.DrawString("Descriere Produs: " + Convert.ToString(author.Value.descriere), f, Brushes.Black, 350, 40);
                    gr.DrawString("Categorie Produs: " + Convert.ToString(author.Value.categorie), f, Brushes.Black, 350, 60);
                    gr.DrawString("Pret Produs: " + Convert.ToString(author.Value.pret), f, Brushes.Black, 350, 80);
                    gr.DrawString("Garantie Produs: " + Convert.ToString(author.Value.garantie) + " luni", f, Brushes.Black, 350, 100);
                    gr.DrawString(Administrator.Admin.MaiSuntNealimentare(author.Key), f, Brushes.Black, 350, 120);
                }
                PictureBox produs = new PictureBox();
                produs.Width = 1000;
                produs.Height = 200;
                produs.Image = bmp;
                produseflow2.Controls.Add(produs);
            }
        }

        private void CosCumparaturi_Click(object sender, EventArgs e)
        {
            CosCumparaturi hello = new CosCumparaturi();
            hello.ShowDialog();
        }

       
    }

    }