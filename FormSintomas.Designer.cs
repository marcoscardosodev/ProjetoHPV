namespace ProjetoHPV
{
    partial class FormSintomas
    {
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIntroducao = new Label();
            panelConteudo = new Panel();
            rtbRecomendacoes = new RichTextBox();
            lblQuandoMedico = new Label();
            rtbHomens = new RichTextBox();
            lblHomens = new Label();
            rtbMulheres = new RichTextBox();
            lblMulheres = new Label();
            btnVoltar = new Button();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(147, 112, 219);
            lblTitulo.Location = new Point(50, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(412, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sintomas e Sinais do HPV";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIntroducao
            // 
            lblIntroducao.AutoSize = false;
            lblIntroducao.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblIntroducao.ForeColor = Color.FromArgb(186, 85, 211);
            lblIntroducao.Location = new Point(50, 80);
            lblIntroducao.Name = "lblIntroducao";
            lblIntroducao.Size = new Size(800, 40);
            lblIntroducao.TabIndex = 1;
            lblIntroducao.Text = "Muitas pessoas com HPV NÃO apresentam sintomas, podendo transmitir o vírus sem saber. Quando aparecem, os sintomas variam conforme o tipo de HPV.";
            lblIntroducao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelConteudo
            // 
            panelConteudo.AutoScroll = true;
            panelConteudo.BackColor = Color.FromArgb(248, 248, 255);
            panelConteudo.BorderStyle = BorderStyle.FixedSingle;
            panelConteudo.Controls.Add(rtbRecomendacoes);
            panelConteudo.Controls.Add(lblQuandoMedico);
            panelConteudo.Controls.Add(rtbHomens);
            panelConteudo.Controls.Add(lblHomens);
            panelConteudo.Controls.Add(rtbMulheres);
            panelConteudo.Controls.Add(lblMulheres);
            panelConteudo.Location = new Point(50, 140);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(800, 450);
            panelConteudo.TabIndex = 2;
            // 
            // rtbRecomendacoes
            // 
            rtbRecomendacoes.BackColor = Color.FromArgb(253, 245, 255);
            rtbRecomendacoes.BorderStyle = BorderStyle.FixedSingle;
            rtbRecomendacoes.Font = new Font("Arial", 10F);
            rtbRecomendacoes.ForeColor = Color.FromArgb(64, 64, 64);
            rtbRecomendacoes.Location = new Point(40, 350);
            rtbRecomendacoes.Name = "rtbRecomendacoes";
            rtbRecomendacoes.ReadOnly = true;
            rtbRecomendacoes.Size = new Size(720, 80);
            rtbRecomendacoes.TabIndex = 5;
            rtbRecomendacoes.Text = "";
            // 
            // lblQuandoMedico
            // 
            lblQuandoMedico.AutoSize = true;
            lblQuandoMedico.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblQuandoMedico.ForeColor = Color.FromArgb(220, 20, 60);
            lblQuandoMedico.Location = new Point(20, 320);
            lblQuandoMedico.Name = "lblQuandoMedico";
            lblQuandoMedico.Size = new Size(322, 22);
            lblQuandoMedico.TabIndex = 4;
            lblQuandoMedico.Text = "⚠️ QUANDO PROCURAR MÉDICO:";
            // 
            // rtbHomens
            // 
            rtbHomens.BackColor = Color.FromArgb(253, 245, 255);
            rtbHomens.BorderStyle = BorderStyle.FixedSingle;
            rtbHomens.Font = new Font("Arial", 10F);
            rtbHomens.ForeColor = Color.FromArgb(64, 64, 64);
            rtbHomens.Location = new Point(40, 200);
            rtbHomens.Name = "rtbHomens";
            rtbHomens.ReadOnly = true;
            rtbHomens.Size = new Size(720, 100);
            rtbHomens.TabIndex = 3;
            rtbHomens.Text = "";
            // 
            // lblHomens
            // 
            lblHomens.AutoSize = true;
            lblHomens.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHomens.ForeColor = Color.FromArgb(138, 43, 226);
            lblHomens.Location = new Point(20, 170);
            lblHomens.Name = "lblHomens";
            lblHomens.Size = new Size(253, 22);
            lblHomens.TabIndex = 2;
            lblHomens.Text = "🔍 Sintomas em HOMENS:";
            // 
            // rtbMulheres
            // 
            rtbMulheres.BackColor = Color.FromArgb(253, 245, 255);
            rtbMulheres.BorderStyle = BorderStyle.FixedSingle;
            rtbMulheres.Font = new Font("Arial", 10F);
            rtbMulheres.ForeColor = Color.FromArgb(64, 64, 64);
            rtbMulheres.Location = new Point(40, 50);
            rtbMulheres.Name = "rtbMulheres";
            rtbMulheres.ReadOnly = true;
            rtbMulheres.Size = new Size(720, 100);
            rtbMulheres.TabIndex = 1;
            rtbMulheres.Text = "";
            // 
            // lblMulheres
            // 
            lblMulheres.AutoSize = true;
            lblMulheres.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblMulheres.ForeColor = Color.FromArgb(138, 43, 226);
            lblMulheres.Location = new Point(20, 20);
            lblMulheres.Name = "lblMulheres";
            lblMulheres.Size = new Size(276, 22);
            lblMulheres.TabIndex = 0;
            lblMulheres.Text = "🔍 Sintomas em MULHERES:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(220, 20, 60);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(375, 610);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(160, 45);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar ao Menu";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormSintomas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 670);
            Controls.Add(btnVoltar);
            Controls.Add(panelConteudo);
            Controls.Add(lblIntroducao);
            Controls.Add(lblTitulo);
            MinimumSize = new Size(800, 600);
            Name = "FormSintomas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sintomas e Sinais - HPV";
            Load += FormSintomas_Load;
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblIntroducao;
        private Panel panelConteudo;
        private RichTextBox rtbMulheres;
        private Label lblMulheres;
        private RichTextBox rtbHomens;
        private Label lblHomens;
        private RichTextBox rtbRecomendacoes;
        private Label lblQuandoMedico;
        private Button btnVoltar;
    }
}