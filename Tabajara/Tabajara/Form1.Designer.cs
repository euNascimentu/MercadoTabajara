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
            lblLoginNome = new Label();
            lblCPFLogin = new Label();
            txtCPFLogin = new TextBox();
            txtNomeLogin = new TextBox();
            lblCodUnico = new Label();
            lblSenhaCaixa = new Label();
            txtCodUnico = new TextBox();
            txtSenhaCaixa = new TextBox();
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
            // lblLoginNome
            // 
            lblLoginNome.AutoSize = true;
            lblLoginNome.BackColor = Color.Transparent;
            lblLoginNome.Location = new Point(185, 120);
            lblLoginNome.Name = "lblLoginNome";
            lblLoginNome.Size = new Size(45, 14);
            lblLoginNome.TabIndex = 2;
            lblLoginNome.Text = "Nome:";
            lblLoginNome.Visible = false;
            // 
            // lblCPFLogin
            // 
            lblCPFLogin.AutoSize = true;
            lblCPFLogin.BackColor = Color.Transparent;
            lblCPFLogin.Location = new Point(352, 120);
            lblCPFLogin.Name = "lblCPFLogin";
            lblCPFLogin.Size = new Size(35, 14);
            lblCPFLogin.TabIndex = 3;
            lblCPFLogin.Text = "CPF:";
            lblCPFLogin.Visible = false;
            // 
            // txtCPFLogin
            // 
            txtCPFLogin.Location = new Point(352, 137);
            txtCPFLogin.Name = "txtCPFLogin";
            txtCPFLogin.Size = new Size(89, 21);
            txtCPFLogin.TabIndex = 4;
            txtCPFLogin.Visible = false;
            // 
            // txtNomeLogin
            // 
            txtNomeLogin.Location = new Point(185, 137);
            txtNomeLogin.Name = "txtNomeLogin";
            txtNomeLogin.Size = new Size(89, 21);
            txtNomeLogin.TabIndex = 5;
            txtNomeLogin.Visible = false;
            // 
            // lblCodUnico
            // 
            lblCodUnico.AutoSize = true;
            lblCodUnico.BackColor = Color.Transparent;
            lblCodUnico.Location = new Point(185, 120);
            lblCodUnico.Name = "lblCodUnico";
            lblCodUnico.Size = new Size(89, 14);
            lblCodUnico.TabIndex = 6;
            lblCodUnico.Text = "Código Unico:";
            lblCodUnico.Visible = false;
            // 
            // lblSenhaCaixa
            // 
            lblSenhaCaixa.AutoSize = true;
            lblSenhaCaixa.BackColor = Color.Transparent;
            lblSenhaCaixa.Location = new Point(352, 120);
            lblSenhaCaixa.Name = "lblSenhaCaixa";
            lblSenhaCaixa.Size = new Size(47, 14);
            lblSenhaCaixa.TabIndex = 7;
            lblSenhaCaixa.Text = "Senha:";
            lblSenhaCaixa.Visible = false;
            // 
            // txtCodUnico
            // 
            txtCodUnico.Location = new Point(185, 137);
            txtCodUnico.MaxLength = 4;
            txtCodUnico.Name = "txtCodUnico";
            txtCodUnico.Size = new Size(89, 21);
            txtCodUnico.TabIndex = 8;
            txtCodUnico.Visible = false;
            // 
            // txtSenhaCaixa
            // 
            txtSenhaCaixa.Location = new Point(352, 137);
            txtSenhaCaixa.MaxLength = 8;
            txtSenhaCaixa.Name = "txtSenhaCaixa";
            txtSenhaCaixa.Size = new Size(89, 21);
            txtSenhaCaixa.TabIndex = 9;
            txtSenhaCaixa.Visible = false;
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
            sobreToolStripMenuItem1.Size = new Size(180, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            sobreToolStripMenuItem1.Click += sobreToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // TabajaraInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 447);
            Controls.Add(txtSenhaCaixa);
            Controls.Add(txtCodUnico);
            Controls.Add(lblSenhaCaixa);
            Controls.Add(lblCodUnico);
            Controls.Add(txtNomeLogin);
            Controls.Add(txtCPFLogin);
            Controls.Add(lblCPFLogin);
            Controls.Add(lblLoginNome);
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
        private Label lblLoginNome;
        private Label lblCPFLogin;
        private TextBox txtCPFLogin;
        private TextBox txtNomeLogin;
        private Label lblCodUnico;
        private Label lblSenhaCaixa;
        private TextBox txtCodUnico;
        private TextBox txtSenhaCaixa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}