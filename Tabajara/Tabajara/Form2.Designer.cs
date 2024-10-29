namespace Tabajara
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            rdbCaixa = new RadioButton();
            rdbProduto = new RadioButton();
            btnVoltarIncio = new Button();
            panelCaixa = new Panel();
            label4 = new Label();
            label3 = new Label();
            txtEmailCaixa = new TextBox();
            lblEmailCaixa = new Label();
            btnAtualizar = new Button();
            btnExcluirCaixa = new Button();
            btnCadastrar = new Button();
            txtCPFCaixa = new TextBox();
            txtDataAniverCaixa = new TextBox();
            txtNomeCaixa = new TextBox();
            lblCpf = new Label();
            lblDataAniversario = new Label();
            lblNome = new Label();
            pictureBox1 = new PictureBox();
            panelProduto = new Panel();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblDescricaoProduto = new Label();
            lblTipoProduto = new Label();
            lblNomeProduto = new Label();
            panelCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProduto.SuspendLayout();
            SuspendLayout();
            // 
            // rdbCaixa
            // 
            rdbCaixa.AutoSize = true;
            rdbCaixa.BackColor = Color.Transparent;
            rdbCaixa.Location = new Point(47, 216);
            rdbCaixa.Name = "rdbCaixa";
            rdbCaixa.Size = new Size(57, 18);
            rdbCaixa.TabIndex = 0;
            rdbCaixa.Text = "Caixa";
            rdbCaixa.UseVisualStyleBackColor = false;
            rdbCaixa.CheckedChanged += rdbCaixa_CheckedChanged;
            // 
            // rdbProduto
            // 
            rdbProduto.AutoSize = true;
            rdbProduto.BackColor = Color.Transparent;
            rdbProduto.Location = new Point(47, 240);
            rdbProduto.Name = "rdbProduto";
            rdbProduto.Size = new Size(71, 18);
            rdbProduto.TabIndex = 1;
            rdbProduto.Text = "Produto";
            rdbProduto.UseVisualStyleBackColor = false;
            rdbProduto.CheckedChanged += rdbProduto_CheckedChanged;
            // 
            // btnVoltarIncio
            // 
            btnVoltarIncio.BackColor = Color.FromArgb(162, 208, 255);
            btnVoltarIncio.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            btnVoltarIncio.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            btnVoltarIncio.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnVoltarIncio.FlatStyle = FlatStyle.Flat;
            btnVoltarIncio.Location = new Point(47, 264);
            btnVoltarIncio.Name = "btnVoltarIncio";
            btnVoltarIncio.Size = new Size(75, 23);
            btnVoltarIncio.TabIndex = 2;
            btnVoltarIncio.Text = "Voltar";
            btnVoltarIncio.UseVisualStyleBackColor = false;
            btnVoltarIncio.Click += btnVoltarIncio_Click;
            // 
            // panelCaixa
            // 
            panelCaixa.BackColor = Color.FromArgb(240, 208, 149);
            panelCaixa.Controls.Add(label4);
            panelCaixa.Controls.Add(label3);
            panelCaixa.Controls.Add(txtEmailCaixa);
            panelCaixa.Controls.Add(lblEmailCaixa);
            panelCaixa.Controls.Add(btnAtualizar);
            panelCaixa.Controls.Add(btnExcluirCaixa);
            panelCaixa.Controls.Add(btnCadastrar);
            panelCaixa.Controls.Add(txtCPFCaixa);
            panelCaixa.Controls.Add(txtDataAniverCaixa);
            panelCaixa.Controls.Add(txtNomeCaixa);
            panelCaixa.Controls.Add(lblCpf);
            panelCaixa.Controls.Add(lblDataAniversario);
            panelCaixa.Controls.Add(lblNome);
            panelCaixa.Location = new Point(350, 53);
            panelCaixa.Name = "panelCaixa";
            panelCaixa.Size = new Size(401, 241);
            panelCaixa.TabIndex = 0;
            panelCaixa.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 185, 99);
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(289, 34);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 13;
            label4.Text = "CAIXA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 185, 99);
            label3.Location = new Point(291, 17);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 13;
            label3.Text = "Cadastro";
            // 
            // txtEmailCaixa
            // 
            txtEmailCaixa.Location = new Point(90, 120);
            txtEmailCaixa.Name = "txtEmailCaixa";
            txtEmailCaixa.Size = new Size(100, 21);
            txtEmailCaixa.TabIndex = 10;
            // 
            // lblEmailCaixa
            // 
            lblEmailCaixa.AutoSize = true;
            lblEmailCaixa.Location = new Point(41, 127);
            lblEmailCaixa.Name = "lblEmailCaixa";
            lblEmailCaixa.Size = new Size(43, 14);
            lblEmailCaixa.TabIndex = 9;
            lblEmailCaixa.Text = "Email:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(162, 208, 255);
            btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.Location = new Point(250, 163);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(78, 60);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.TextAlign = ContentAlignment.BottomCenter;
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluirCaixa
            // 
            btnExcluirCaixa.BackColor = Color.FromArgb(162, 208, 255);
            btnExcluirCaixa.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            btnExcluirCaixa.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            btnExcluirCaixa.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnExcluirCaixa.FlatStyle = FlatStyle.Flat;
            btnExcluirCaixa.Image = (Image)resources.GetObject("btnExcluirCaixa.Image");
            btnExcluirCaixa.Location = new Point(166, 163);
            btnExcluirCaixa.Name = "btnExcluirCaixa";
            btnExcluirCaixa.Size = new Size(78, 60);
            btnExcluirCaixa.TabIndex = 7;
            btnExcluirCaixa.Text = "Excluir";
            btnExcluirCaixa.TextAlign = ContentAlignment.BottomCenter;
            btnExcluirCaixa.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(162, 208, 255);
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(82, 163);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 60);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtCPFCaixa
            // 
            txtCPFCaixa.Location = new Point(82, 92);
            txtCPFCaixa.Name = "txtCPFCaixa";
            txtCPFCaixa.Size = new Size(100, 21);
            txtCPFCaixa.TabIndex = 5;
            // 
            // txtDataAniverCaixa
            // 
            txtDataAniverCaixa.Location = new Point(173, 63);
            txtDataAniverCaixa.Name = "txtDataAniverCaixa";
            txtDataAniverCaixa.Size = new Size(100, 21);
            txtDataAniverCaixa.TabIndex = 4;
            // 
            // txtNomeCaixa
            // 
            txtNomeCaixa.Location = new Point(92, 36);
            txtNomeCaixa.Name = "txtNomeCaixa";
            txtNomeCaixa.Size = new Size(100, 21);
            txtNomeCaixa.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(41, 98);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(35, 14);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblDataAniversario
            // 
            lblDataAniversario.AutoSize = true;
            lblDataAniversario.Location = new Point(41, 72);
            lblDataAniversario.Name = "lblDataAniversario";
            lblDataAniversario.Size = new Size(126, 14);
            lblDataAniversario.TabIndex = 1;
            lblDataAniversario.Text = "Data de Aniversário:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(41, 43);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 14);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(350, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelProduto
            // 
            panelProduto.BackColor = Color.FromArgb(240, 208, 149);
            panelProduto.Controls.Add(label2);
            panelProduto.Controls.Add(label1);
            panelProduto.Controls.Add(button3);
            panelProduto.Controls.Add(button2);
            panelProduto.Controls.Add(button1);
            panelProduto.Controls.Add(textBox3);
            panelProduto.Controls.Add(textBox2);
            panelProduto.Controls.Add(textBox1);
            panelProduto.Controls.Add(lblDescricaoProduto);
            panelProduto.Controls.Add(lblTipoProduto);
            panelProduto.Controls.Add(lblNomeProduto);
            panelProduto.Location = new Point(350, 53);
            panelProduto.Name = "panelProduto";
            panelProduto.Size = new Size(401, 241);
            panelProduto.TabIndex = 5;
            panelProduto.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 185, 99);
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(278, 33);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 12;
            label2.Text = "PRODUTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 185, 99);
            label1.Location = new Point(294, 15);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 6;
            label1.Text = "Cadastro";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(162, 208, 255);
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(251, 150);
            button3.Name = "button3";
            button3.Size = new Size(78, 60);
            button3.TabIndex = 11;
            button3.Text = "Atualizar";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(162, 208, 255);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(167, 150);
            button2.Name = "button2";
            button2.Size = new Size(78, 60);
            button2.TabIndex = 11;
            button2.Text = "Excluir";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(162, 208, 255);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 33, 66);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 33, 66);
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(83, 150);
            button1.Name = "button1";
            button1.Size = new Size(78, 60);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 72);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 72);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 21);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 4;
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Location = new Point(32, 79);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(70, 14);
            lblDescricaoProduto.TabIndex = 2;
            lblDescricaoProduto.Text = "Descrição:";
            // 
            // lblTipoProduto
            // 
            lblTipoProduto.AutoSize = true;
            lblTipoProduto.Location = new Point(31, 53);
            lblTipoProduto.Name = "lblTipoProduto";
            lblTipoProduto.Size = new Size(82, 14);
            lblTipoProduto.TabIndex = 1;
            lblTipoProduto.Text = "Cod. Barras:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(32, 29);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(45, 14);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome:";
            // 
            // Supervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(774, 328);
            Controls.Add(panelProduto);
            Controls.Add(pictureBox1);
            Controls.Add(panelCaixa);
            Controls.Add(btnVoltarIncio);
            Controls.Add(rdbProduto);
            Controls.Add(rdbCaixa);
            DoubleBuffered = true;
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Supervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor";
            panelCaixa.ResumeLayout(false);
            panelCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProduto.ResumeLayout(false);
            panelProduto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbCaixa;
        private RadioButton rdbProduto;
        private Button btnVoltarIncio;
        private Panel panelCaixa;
        private TextBox txtCPFCaixa;
        private TextBox txtDataAniverCaixa;
        private TextBox txtNomeCaixa;
        private Label lblCpf;
        private Label lblDataAniversario;
        private Label lblNome;
        private Button btnCadastrar;
        private TextBox txtEmailCaixa;
        private Label lblEmailCaixa;
        private Button btnAtualizar;
        private Button btnExcluirCaixa;
        private PictureBox pictureBox1;
        private Panel panelProduto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblDescricaoProduto;
        private Label lblTipoProduto;
        private Label lblNomeProduto;
    }
}