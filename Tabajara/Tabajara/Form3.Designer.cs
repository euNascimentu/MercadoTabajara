namespace Tabajara
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            grbCupomFiscal = new GroupBox();
            btnAbreCupom = new Button();
            txtCupomFiscal = new TextBox();
            ckbCupomFiscal = new CheckBox();
            lblMercadoLogo = new Label();
            lblTabajaraLogo = new Label();
            grbProdutoAtual = new GroupBox();
            btnAdicionarProduto = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblDescricao = new Label();
            lblPrecoUnitario = new Label();
            lblQuantidade = new Label();
            lblCodBarras = new Label();
            grbDetalhesCupom = new GroupBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            btnRemoverProduto = new Button();
            grbFormasPagamento = new GroupBox();
            rdbDinheiro = new RadioButton();
            rdbDebito = new RadioButton();
            rdbCredito = new RadioButton();
            btnFinalizarCompra = new Button();
            btnPagar = new Button();
            lblValorTotal1 = new Label();
            lblValorTotal2 = new Label();
            lblTotal = new Label();
            lblValorTotal = new Label();
            grbCupomFiscal.SuspendLayout();
            grbProdutoAtual.SuspendLayout();
            grbDetalhesCupom.SuspendLayout();
            grbFormasPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // grbCupomFiscal
            // 
            grbCupomFiscal.Controls.Add(btnAbreCupom);
            grbCupomFiscal.Controls.Add(txtCupomFiscal);
            grbCupomFiscal.Controls.Add(ckbCupomFiscal);
            grbCupomFiscal.Location = new Point(16, 13);
            grbCupomFiscal.Margin = new Padding(4, 3, 4, 3);
            grbCupomFiscal.Name = "grbCupomFiscal";
            grbCupomFiscal.Padding = new Padding(4, 3, 4, 3);
            grbCupomFiscal.Size = new Size(267, 243);
            grbCupomFiscal.TabIndex = 1;
            grbCupomFiscal.TabStop = false;
            // 
            // btnAbreCupom
            // 
            btnAbreCupom.FlatAppearance.BorderColor = Color.Black;
            btnAbreCupom.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAbreCupom.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnAbreCupom.FlatStyle = FlatStyle.Flat;
            btnAbreCupom.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbreCupom.Image = (Image)resources.GetObject("btnAbreCupom.Image");
            btnAbreCupom.Location = new Point(40, 100);
            btnAbreCupom.Margin = new Padding(4, 3, 4, 3);
            btnAbreCupom.Name = "btnAbreCupom";
            btnAbreCupom.Size = new Size(151, 97);
            btnAbreCupom.TabIndex = 2;
            btnAbreCupom.Text = "Abrir Cupom";
            btnAbreCupom.TextAlign = ContentAlignment.BottomCenter;
            btnAbreCupom.UseVisualStyleBackColor = true;
            // 
            // txtCupomFiscal
            // 
            txtCupomFiscal.Location = new Point(40, 56);
            txtCupomFiscal.Margin = new Padding(4, 3, 4, 3);
            txtCupomFiscal.Name = "txtCupomFiscal";
            txtCupomFiscal.Size = new Size(149, 21);
            txtCupomFiscal.TabIndex = 2;
            // 
            // ckbCupomFiscal
            // 
            ckbCupomFiscal.AutoSize = true;
            ckbCupomFiscal.Location = new Point(57, 31);
            ckbCupomFiscal.Margin = new Padding(4, 3, 4, 3);
            ckbCupomFiscal.Name = "ckbCupomFiscal";
            ckbCupomFiscal.Size = new Size(105, 18);
            ckbCupomFiscal.TabIndex = 2;
            ckbCupomFiscal.Text = "Cupom Fiscal";
            ckbCupomFiscal.UseVisualStyleBackColor = true;
            // 
            // lblMercadoLogo
            // 
            lblMercadoLogo.AutoSize = true;
            lblMercadoLogo.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMercadoLogo.ForeColor = Color.FromArgb(0, 33, 66);
            lblMercadoLogo.Location = new Point(792, 60);
            lblMercadoLogo.Margin = new Padding(4, 0, 4, 0);
            lblMercadoLogo.Name = "lblMercadoLogo";
            lblMercadoLogo.Size = new Size(212, 43);
            lblMercadoLogo.TabIndex = 2;
            lblMercadoLogo.Text = "MERCADO";
            // 
            // lblTabajaraLogo
            // 
            lblTabajaraLogo.AutoSize = true;
            lblTabajaraLogo.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTabajaraLogo.ForeColor = Color.FromArgb(0, 33, 66);
            lblTabajaraLogo.Location = new Point(707, 113);
            lblTabajaraLogo.Margin = new Padding(4, 0, 4, 0);
            lblTabajaraLogo.Name = "lblTabajaraLogo";
            lblTabajaraLogo.Size = new Size(385, 75);
            lblTabajaraLogo.TabIndex = 3;
            lblTabajaraLogo.Text = "TABAJARA";
            // 
            // grbProdutoAtual
            // 
            grbProdutoAtual.Controls.Add(btnAdicionarProduto);
            grbProdutoAtual.Controls.Add(textBox4);
            grbProdutoAtual.Controls.Add(textBox3);
            grbProdutoAtual.Controls.Add(textBox2);
            grbProdutoAtual.Controls.Add(textBox1);
            grbProdutoAtual.Controls.Add(lblDescricao);
            grbProdutoAtual.Controls.Add(lblPrecoUnitario);
            grbProdutoAtual.Controls.Add(lblQuantidade);
            grbProdutoAtual.Controls.Add(lblCodBarras);
            grbProdutoAtual.Location = new Point(346, 252);
            grbProdutoAtual.Name = "grbProdutoAtual";
            grbProdutoAtual.Size = new Size(526, 230);
            grbProdutoAtual.TabIndex = 4;
            grbProdutoAtual.TabStop = false;
            grbProdutoAtual.Text = "Produto Atual";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.FlatAppearance.BorderColor = Color.Black;
            btnAdicionarProduto.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAdicionarProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnAdicionarProduto.FlatStyle = FlatStyle.Flat;
            btnAdicionarProduto.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionarProduto.Image = (Image)resources.GetObject("btnAdicionarProduto.Image");
            btnAdicionarProduto.Location = new Point(406, 127);
            btnAdicionarProduto.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(113, 97);
            btnAdicionarProduto.TabIndex = 3;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.TextAlign = ContentAlignment.BottomCenter;
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 121);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(281, 103);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 94);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 21);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 64);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 21);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 36);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 21);
            textBox1.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(33, 128);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(70, 14);
            lblDescricao.TabIndex = 10;
            lblDescricao.Text = "Descrição:";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(33, 101);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(93, 14);
            lblPrecoUnitario.TabIndex = 9;
            lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(33, 71);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 14);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblCodBarras
            // 
            lblCodBarras.AutoSize = true;
            lblCodBarras.Location = new Point(33, 43);
            lblCodBarras.Name = "lblCodBarras";
            lblCodBarras.Size = new Size(114, 14);
            lblCodBarras.TabIndex = 7;
            lblCodBarras.Text = "Código de Barras:";
            // 
            // grbDetalhesCupom
            // 
            grbDetalhesCupom.Controls.Add(richTextBox1);
            grbDetalhesCupom.Controls.Add(button1);
            grbDetalhesCupom.Controls.Add(textBox5);
            grbDetalhesCupom.Controls.Add(btnRemoverProduto);
            grbDetalhesCupom.Location = new Point(346, 488);
            grbDetalhesCupom.Name = "grbDetalhesCupom";
            grbDetalhesCupom.Size = new Size(526, 285);
            grbDetalhesCupom.TabIndex = 5;
            grbDetalhesCupom.TabStop = false;
            grbDetalhesCupom.Text = "Carrinho";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(379, 239);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(425, 227);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(85, 26);
            button1.TabIndex = 16;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(409, 200);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 21);
            textBox5.TabIndex = 14;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.FlatAppearance.BorderColor = Color.Black;
            btnRemoverProduto.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnRemoverProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnRemoverProduto.FlatStyle = FlatStyle.Flat;
            btnRemoverProduto.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverProduto.Image = (Image)resources.GetObject("btnRemoverProduto.Image");
            btnRemoverProduto.Location = new Point(406, 97);
            btnRemoverProduto.Margin = new Padding(4, 3, 4, 3);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Size = new Size(113, 97);
            btnRemoverProduto.TabIndex = 15;
            btnRemoverProduto.Text = "Remover Produto";
            btnRemoverProduto.TextAlign = ContentAlignment.BottomCenter;
            btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // grbFormasPagamento
            // 
            grbFormasPagamento.Controls.Add(lblValorTotal);
            grbFormasPagamento.Controls.Add(lblTotal);
            grbFormasPagamento.Controls.Add(rdbDinheiro);
            grbFormasPagamento.Controls.Add(rdbDebito);
            grbFormasPagamento.Controls.Add(rdbCredito);
            grbFormasPagamento.Controls.Add(btnFinalizarCompra);
            grbFormasPagamento.Location = new Point(878, 488);
            grbFormasPagamento.Name = "grbFormasPagamento";
            grbFormasPagamento.Size = new Size(391, 285);
            grbFormasPagamento.TabIndex = 9;
            grbFormasPagamento.TabStop = false;
            grbFormasPagamento.Text = "Formas de Pagamentos";
            // 
            // rdbDinheiro
            // 
            rdbDinheiro.AutoSize = true;
            rdbDinheiro.Location = new Point(49, 222);
            rdbDinheiro.Name = "rdbDinheiro";
            rdbDinheiro.Size = new Size(73, 18);
            rdbDinheiro.TabIndex = 18;
            rdbDinheiro.TabStop = true;
            rdbDinheiro.Text = "Dinheiro";
            rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rdbDebito
            // 
            rdbDebito.AutoSize = true;
            rdbDebito.Location = new Point(49, 189);
            rdbDebito.Name = "rdbDebito";
            rdbDebito.Size = new Size(63, 18);
            rdbDebito.TabIndex = 17;
            rdbDebito.TabStop = true;
            rdbDebito.Text = "Débito";
            rdbDebito.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(49, 156);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(68, 18);
            rdbCredito.TabIndex = 16;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Crédito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.FlatAppearance.BorderColor = Color.Black;
            btnFinalizarCompra.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnFinalizarCompra.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnFinalizarCompra.FlatStyle = FlatStyle.Flat;
            btnFinalizarCompra.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarCompra.Image = (Image)resources.GetObject("btnFinalizarCompra.Image");
            btnFinalizarCompra.Location = new Point(196, 156);
            btnFinalizarCompra.Margin = new Padding(4, 3, 4, 3);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(151, 97);
            btnFinalizarCompra.TabIndex = 15;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.TextAlign = ContentAlignment.BottomCenter;
            btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.FlatAppearance.BorderColor = Color.Black;
            btnPagar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnPagar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 185, 99);
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Image = (Image)resources.GetObject("btnPagar.Image");
            btnPagar.Location = new Point(18, 101);
            btnPagar.Margin = new Padding(4, 3, 4, 3);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(151, 97);
            btnPagar.TabIndex = 14;
            btnPagar.Text = "Ir para Pagamento";
            btnPagar.TextAlign = ContentAlignment.BottomCenter;
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // lblValorTotal1
            // 
            lblValorTotal1.AutoSize = true;
            lblValorTotal1.Location = new Point(18, 71);
            lblValorTotal1.Name = "lblValorTotal1";
            lblValorTotal1.Size = new Size(73, 14);
            lblValorTotal1.TabIndex = 15;
            lblValorTotal1.Text = "Valor Total:";
            // 
            // lblValorTotal2
            // 
            lblValorTotal2.AutoSize = true;
            lblValorTotal2.Location = new Point(97, 71);
            lblValorTotal2.Name = "lblValorTotal2";
            lblValorTotal2.Size = new Size(19, 14);
            lblValorTotal2.TabIndex = 16;
            lblValorTotal2.Text = "...";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(49, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(73, 14);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "Valor Total:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(128, 60);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(19, 14);
            lblValorTotal.TabIndex = 20;
            lblValorTotal.Text = "...";
            // 
            // Caixa
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 185, 99);
            ClientSize = new Size(1604, 785);
            Controls.Add(grbFormasPagamento);
            Controls.Add(grbDetalhesCupom);
            Controls.Add(grbProdutoAtual);
            Controls.Add(lblTabajaraLogo);
            Controls.Add(lblMercadoLogo);
            Controls.Add(grbCupomFiscal);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Caixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa";
            WindowState = FormWindowState.Maximized;
            grbCupomFiscal.ResumeLayout(false);
            grbCupomFiscal.PerformLayout();
            grbProdutoAtual.ResumeLayout(false);
            grbProdutoAtual.PerformLayout();
            grbDetalhesCupom.ResumeLayout(false);
            grbDetalhesCupom.PerformLayout();
            grbFormasPagamento.ResumeLayout(false);
            grbFormasPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbCupomFiscal;
        private Button btnAbreCupom;
        private TextBox txtCupomFiscal;
        private CheckBox ckbCupomFiscal;
        private Label lblMercadoLogo;
        private Label lblTabajaraLogo;
        private GroupBox grbProdutoAtual;
        private Label lblDescricao;
        private Label lblPrecoUnitario;
        private Label lblQuantidade;
        private Label lblCodBarras;
        private GroupBox grbDetalhesCupom;
        private GroupBox grbFormasPagamento;
        private Button btnAdicionarProduto;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox5;
        private Button btnRemoverProduto;
        private Button btnPagar;
        private Button btnFinalizarCompra;
        private Label lblValorTotal2;
        private Label lblValorTotal1;
        private RadioButton rdbDinheiro;
        private RadioButton rdbDebito;
        private RadioButton rdbCredito;
        private Label lblValorTotal;
        private Label lblTotal;
    }
}