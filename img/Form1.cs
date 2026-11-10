using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cukraszda
{
    public partial class Form1 : Form
    {
        private List<Dessert> desserts = new List<Dessert>();
        private List<OrderItem> order = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dessertPictureBox.LoadAsync("https://images.pexels.com/photos/9500884/pexels-photo-9500884.jpeg?auto=compress&cs=tinysrgb&w=800");
            }
            catch
            {
            }
        }

        private void LoadMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Süteménylista kiválasztása";
            dialog.Filter = "Szövegfájl (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            dialog.InitialDirectory = Application.StartupPath;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                List<Dessert> loadedDesserts = new List<Dessert>();
                string[] lines = File.ReadAllLines(dialog.FileName);

                foreach (string line in lines)
                {
                    if (line.Trim() == "")
                        continue;

                    string[] parts = line.Split(';');
                    int price;

                    if (parts.Length != 2 || parts[0].Trim() == "" ||
                        !int.TryParse(parts[1].Trim(), out price) || price <= 0)
                    {
                        throw new Exception("Hibás sor: " + line);
                    }

                    loadedDesserts.Add(new Dessert(parts[0].Trim(), price));
                }

                if (loadedDesserts.Count == 0)
                    throw new Exception("A fájl nem tartalmaz süteményeket.");

                desserts = loadedDesserts;
                dessertsMenuItem.Enabled = true;
                OpenOrderForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült betölteni a fájlt.\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DessertsMenuItem_Click(object sender, EventArgs e)
        {
            if (desserts.Count == 0)
            {
                MessageBox.Show("Először töltsd be a süteménylistát!", "Figyelem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenOrderForm();
        }

        private void OpenOrderForm()
        {
            using (OrderForm form = new OrderForm(desserts, order))
            {
                form.ShowDialog(this);
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cukrászda rendelőprogram\nKészítették: Tóth Martin, Jutasi András, Szabó Domán",
                "Névjegy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowInvoice()
        {
            invoiceRichTextBox.Clear();

            if (order.Count == 0)
            {
                invoiceRichTextBox.Text = "Még nincs rendelés.";
                MessageBox.Show("Még nem adtál le rendelést!", "Számla",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            invoiceRichTextBox.AppendText("CUKRÁSZDA - SZÁMLA\n");
            invoiceRichTextBox.AppendText("--------------------------------\n");

            int total = 0;

            foreach (OrderItem item in order)
            {
                int lineTotal = item.Price * item.Quantity;
                invoiceRichTextBox.AppendText(item.Name + "   " + item.Quantity +
                    " db   " + lineTotal + " Ft\n");
                total += lineTotal;
            }

            invoiceRichTextBox.AppendText("--------------------------------\n");
            invoiceRichTextBox.AppendText("FIZETENDŐ: " + total + " Ft");
        }
    }
}
