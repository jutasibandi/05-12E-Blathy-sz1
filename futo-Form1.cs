using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace futo
{
    public partial class Form1 : Form
    {
        public static List<Futo> futok = new List<Futo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Beolvas()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Szövegfájl|*.txt";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            futok.Clear();
            lstNevek.Items.Clear();

            foreach (string sor in File.ReadAllLines(ofd.FileName))
            {
                if (sor.Trim() == "") continue;
                string[] a = sor.Split(';');
                if (a.Length < 5) continue;

                Futo f = new Futo();
                f.Rajtszam = a[0];
                f.Nev = a[1];
                f.Szul = a[2];
                f.Orszag = a[3];
                f.Ido = a[4];

                futok.Add(f);
                lstNevek.Items.Add(f.Nev);
            }
        }

        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void megnyitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beolvas();
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            Beolvas();
        }

        private void lstNevek_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstNevek.SelectedIndex;
            if (i < 0) return;

            Futo f = futok[i];
            txtRajtszam.Text = f.Rajtszam;
            txtOrszag.Text = f.Orszag;
            txtIdo.Text = f.Ido;

            int szulEv = int.Parse(f.Szul.Substring(0, 4));
            txtEletkor.Text = (DateTime.Today.Year - szulEv).ToString();
        }

        private void eredmenylistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ablak = new Form2();
            ablak.Show();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
    public class Futo
    {
        public string Rajtszam = "";
        public string Nev = "";
        public string Szul = "";
        public string Orszag = "";
        public string Ido = "";
    }
}