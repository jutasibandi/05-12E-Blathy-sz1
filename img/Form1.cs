namespace cukraszda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.ReadAllLines(ofd.FileName);
                süteményekToolStripMenuItem.Enabled = true;
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void süteményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void névjegyzékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cukrászda program\nKészítette: Tóth Martin és Jutasi András és Szabó Domán",
                "Névjegy");
        }
    }
}
