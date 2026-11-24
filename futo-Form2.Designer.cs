namespace futo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lstEredmeny = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mentésToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 22);
            label1.Name = "label1";
            label1.Size = new Size(278, 27);
            label1.TabIndex = 0;
            label1.Text = "verseny eredmény lista";
            // 
            // lstEredmeny
            // 
            lstEredmeny.ContextMenuStrip = contextMenuStrip1;
            lstEredmeny.FormattingEnabled = true;
            lstEredmeny.ItemHeight = 15;
            lstEredmeny.Location = new Point(177, 74);
            lstEredmeny.Name = "lstEredmeny";
            lstEredmeny.Size = new Size(333, 244);
            lstEredmeny.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mentésToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 26);
            contextMenuStrip1.Text = "Mentés";
            // 
            // mentésToolStripMenuItem
            // 
            mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            mentésToolStripMenuItem.Size = new Size(113, 22);
            mentésToolStripMenuItem.Text = "Mentés";
            mentésToolStripMenuItem.Click += mentesToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEredmeny);
            Controls.Add(label1);
            Name = "Form2";
            Text = "eredmények";
            Load += Form2_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstEredmeny;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mentésToolStripMenuItem;
    }
}