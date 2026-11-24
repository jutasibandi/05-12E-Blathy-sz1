namespace futo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lstNevek = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRajtszam = new TextBox();
            txtOrszag = new TextBox();
            txtIdo = new TextBox();
            txtEletkor = new TextBox();
            btnAdatbe = new Button();
            btnBezar = new Button();
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            megnyitToolStripMenuItem = new ToolStripMenuItem();
            eredménylistaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 35);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 1;
            label1.Text = "Maratoni futóverseny";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 89);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 2;
            label2.Text = "RÉSZTVEVŐK";
            // 
            // lstNevek
            // 
            lstNevek.FormattingEnabled = true;
            lstNevek.ItemHeight = 15;
            lstNevek.Location = new Point(32, 126);
            lstNevek.Name = "lstNevek";
            lstNevek.Size = new Size(120, 229);
            lstNevek.TabIndex = 3;
            lstNevek.Click += lstNevek_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 131);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 4;
            label3.Text = "Rajtszám";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(205, 189);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 5;
            label4.Text = "ország";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(205, 253);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 6;
            label5.Text = "időeredmény";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(205, 308);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 7;
            label6.Text = "életkor";
            // 
            // txtRajtszam
            // 
            txtRajtszam.Location = new Point(329, 126);
            txtRajtszam.Name = "txtRajtszam";
            txtRajtszam.ReadOnly = true;
            txtRajtszam.Size = new Size(100, 23);
            txtRajtszam.TabIndex = 8;
            // 
            // txtOrszag
            // 
            txtOrszag.Location = new Point(329, 189);
            txtOrszag.Name = "txtOrszag";
            txtOrszag.ReadOnly = true;
            txtOrszag.Size = new Size(100, 23);
            txtOrszag.TabIndex = 9;
            // 
            // txtIdo
            // 
            txtIdo.Location = new Point(329, 248);
            txtIdo.Name = "txtIdo";
            txtIdo.ReadOnly = true;
            txtIdo.Size = new Size(100, 23);
            txtIdo.TabIndex = 10;
            // 
            // txtEletkor
            // 
            txtEletkor.Location = new Point(329, 308);
            txtEletkor.Name = "txtEletkor";
            txtEletkor.ReadOnly = true;
            txtEletkor.Size = new Size(100, 23);
            txtEletkor.TabIndex = 11;
            // 
            // btnAdatbe
            // 
            btnAdatbe.BackColor = Color.LightGreen;
            btnAdatbe.Location = new Point(32, 379);
            btnAdatbe.Name = "btnAdatbe";
            btnAdatbe.Size = new Size(120, 31);
            btnAdatbe.TabIndex = 12;
            btnAdatbe.Text = "adatBe";
            btnAdatbe.UseVisualStyleBackColor = false;
            btnAdatbe.Click += btnAdatBe_Click;
            // 
            // btnBezar
            // 
            btnBezar.BackColor = Color.LightCoral;
            btnBezar.Location = new Point(329, 379);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(100, 31);
            btnBezar.TabIndex = 13;
            btnBezar.Text = "bezár";
            btnBezar.UseVisualStyleBackColor = false;
            btnBezar.Click += btnBezar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, megnyitToolStripMenuItem, eredménylistaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip2";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            fájlToolStripMenuItem.Click += fájlToolStripMenuItem_Click;
            // 
            // megnyitToolStripMenuItem
            // 
            megnyitToolStripMenuItem.Name = "megnyitToolStripMenuItem";
            megnyitToolStripMenuItem.Size = new Size(63, 20);
            megnyitToolStripMenuItem.Text = "Megnyit";
            megnyitToolStripMenuItem.Click += megnyitToolStripMenuItem_Click;
            // 
            // eredménylistaToolStripMenuItem
            // 
            eredménylistaToolStripMenuItem.Name = "eredménylistaToolStripMenuItem";
            eredménylistaToolStripMenuItem.Size = new Size(93, 20);
            eredménylistaToolStripMenuItem.Text = "Eredménylista";
            eredménylistaToolStripMenuItem.Click += eredmenylistaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBezar);
            Controls.Add(btnAdatbe);
            Controls.Add(txtEletkor);
            Controls.Add(txtIdo);
            Controls.Add(txtOrszag);
            Controls.Add(txtRajtszam);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstNevek);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "futóverseny";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private ListBox lstNevek;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtRajtszam;
        private TextBox txtOrszag;
        private TextBox txtIdo;
        private TextBox txtEletkor;
        private Button btnAdatbe;
        private Button btnBezar;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem megnyitToolStripMenuItem;
        private ToolStripMenuItem eredménylistaToolStripMenuItem;
    }
}
