namespace Tabajara
{
    partial class TabajaraInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabajaraInicial));
            btnSupervisor = new Button();
            btnCaixa = new Button();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSupervisor
            // 
            btnSupervisor.FlatAppearance.BorderColor = Color.Black;
            btnSupervisor.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSupervisor.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnSupervisor.FlatStyle = FlatStyle.Flat;
            btnSupervisor.Location = new Point(185, 326);
            btnSupervisor.Name = "btnSupervisor";
            btnSupervisor.Size = new Size(89, 26);
            btnSupervisor.TabIndex = 0;
            btnSupervisor.Text = "Supervisor";
            btnSupervisor.UseVisualStyleBackColor = true;
            btnSupervisor.Click += btnSupervisor_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.FlatAppearance.BorderColor = Color.Black;
            btnCaixa.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Location = new Point(352, 326);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(89, 26);
            btnCaixa.TabIndex = 1;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(241, 185, 99);
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(560, 24);
            menuStrip1.TabIndex = 10;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem1, sairToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(53, 20);
            sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(109, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            sobreToolStripMenuItem1.Click += sobreToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(109, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // TabajaraInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 447);
            Controls.Add(btnCaixa);
            Controls.Add(btnSupervisor);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "TabajaraInicial";
            Text = "Mercado Tabajara";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSupervisor;
        private Button btnCaixa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}