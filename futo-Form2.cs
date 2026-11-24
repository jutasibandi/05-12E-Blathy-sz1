using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace futo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Futo> rendezett = new List<Futo>(Form1.futok);

            
            rendezett.Sort((x, y) => string.CompareOrdinal(y.Ido, x.Ido));

            foreach (Futo f in rendezett)
            {
                lstEredmeny.Items.Add(f.Nev + " - " + f.Ido);
            }
        }

        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> sorok = new List<string>();
            foreach (object elem in lstEredmeny.Items)
            {
                sorok.Add(elem.ToString() ?? "");
            }

            File.WriteAllLines("EREDMENYEK.txt", sorok);
            MessageBox.Show("Mentve: EREDMENYEK.txt");
        }
    }
}