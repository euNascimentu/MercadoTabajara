namespace ShowDaPobreza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            TituloPergunta = new Label();
            btnIniciar = new Button();
            btnParar = new Button();
            rdbAlternativaA = new RadioButton();
            rdbAlternativaB = new RadioButton();
            rdbAlternativaC = new RadioButton();
            rdbAlternativaD = new RadioButton();
            btnConfirmar = new Button();
            lblBoasVindas = new Label();
            SuspendLayout();
            // 
            // TituloPergunta
            // 
            TituloPergunta.AutoSize = true;
            TituloPergunta.BackColor = Color.Transparent;
            TituloPergunta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TituloPergunta.Location = new Point(161, 108);
            TituloPergunta.Name = "TituloPergunta";
            TituloPergunta.Size = new Size(318, 15);
            TituloPergunta.TabIndex = 0;
            TituloPergunta.Text = "!-------- COLOCAR AS PERGUNTAS AQUI -----------------!";
            TituloPergunta.Visible = false;
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.BorderColor = Color.Black;
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Location = new Point(252, 436);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.FlatAppearance.BorderColor = Color.Black;
            btnParar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnParar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnParar.FlatStyle = FlatStyle.Flat;
            btnParar.Location = new Point(171, 436);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(75, 23);
            btnParar.TabIndex = 6;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Visible = false;
            // 
            // rdbAlternativaA
            // 
            rdbAlternativaA.AutoSize = true;
            rdbAlternativaA.BackColor = Color.Transparent;
            rdbAlternativaA.Location = new Point(128, 204);
            rdbAlternativaA.Name = "rdbAlternativaA";
            rdbAlternativaA.Size = new Size(93, 19);
            rdbAlternativaA.TabIndex = 7;
            rdbAlternativaA.Text = "Alternativa A";
            rdbAlternativaA.UseVisualStyleBackColor = false;
            rdbAlternativaA.Visible = false;
            // 
            // rdbAlternativaB
            // 
            rdbAlternativaB.AutoSize = true;
            rdbAlternativaB.BackColor = Color.Transparent;
            rdbAlternativaB.Location = new Point(130, 260);
            rdbAlternativaB.Name = "rdbAlternativaB";
            rdbAlternativaB.Size = new Size(92, 19);
            rdbAlternativaB.TabIndex = 8;
            rdbAlternativaB.Text = "Alternativa B";
            rdbAlternativaB.UseVisualStyleBackColor = false;
            rdbAlternativaB.Visible = false;
            // 
            // rdbAlternativaC
            // 
            rdbAlternativaC.AutoSize = true;
            rdbAlternativaC.BackColor = Color.Transparent;
            rdbAlternativaC.Location = new Point(128, 308);
            rdbAlternativaC.Name = "rdbAlternativaC";
            rdbAlternativaC.Size = new Size(92, 19);
            rdbAlternativaC.TabIndex = 9;
            rdbAlternativaC.Text = "Alternativa C";
            rdbAlternativaC.UseVisualStyleBackColor = false;
            rdbAlternativaC.Visible = false;
            // 
            // rdbAlternativaD
            // 
            rdbAlternativaD.AutoSize = true;
            rdbAlternativaD.BackColor = Color.Transparent;
            rdbAlternativaD.Location = new Point(128, 361);
            rdbAlternativaD.Name = "rdbAlternativaD";
            rdbAlternativaD.Size = new Size(94, 19);
            rdbAlternativaD.TabIndex = 10;
            rdbAlternativaD.Text = "Alternativa D";
            rdbAlternativaD.UseVisualStyleBackColor = false;
            rdbAlternativaD.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatAppearance.BorderColor = Color.Black;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(333, 436);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Visible = false;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.BackColor = Color.Transparent;
            lblBoasVindas.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBoasVindas.Location = new Point(86, 155);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(458, 27);
            lblBoasVindas.TabIndex = 11;
            lblBoasVindas.Text = "Seja Bem-Vindo ao Show da Pobreza!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 561);
            Controls.Add(lblBoasVindas);
            Controls.Add(btnConfirmar);
            Controls.Add(rdbAlternativaD);
            Controls.Add(rdbAlternativaC);
            Controls.Add(rdbAlternativaB);
            Controls.Add(rdbAlternativaA);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(TituloPergunta);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form2";
            Text = "Form2";
            FormClosed += FecharPrograma;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloPergunta;
        private Button btnIniciar;
        private Button btnParar;
        private RadioButton rdbAlternativaA;
        private RadioButton rdbAlternativaB;
        private RadioButton rdbAlternativaC;
        private RadioButton rdbAlternativaD;
        private Button btnConfirmar;
        private Label lblBoasVindas;
    }
}