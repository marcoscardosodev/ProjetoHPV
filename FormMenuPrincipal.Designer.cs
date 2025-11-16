namespace ProjetoHPV
{
    partial class FormMenuPrincipal
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
            lblTituloMenu = new Label();
            panelBotoes = new Panel();
            btnVoltar = new Button();
            btnQuiz = new Button();
            btnEstatisticas = new Button();
            btnDiagnostico = new Button();
            btnPrevencao = new Button();
            btnSintomas = new Button();
            btnOQueEHPV = new Button();
            panelHeader = new Panel();
            lblSubtitulo = new Label();
            panelFooter = new Panel();
            lblVersao = new Label();
            panelBotoes.SuspendLayout();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMenu.ForeColor = Color.White;
            lblTituloMenu.Location = new Point(45, 20);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(423, 45);
            lblTituloMenu.TabIndex = 0;
            lblTituloMenu.Text = "Menu de Navegação - HPV";
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = Color.Transparent;
            panelBotoes.Controls.Add(btnVoltar);
            panelBotoes.Controls.Add(btnQuiz);
            panelBotoes.Controls.Add(btnEstatisticas);
            panelBotoes.Controls.Add(btnDiagnostico);
            panelBotoes.Controls.Add(btnPrevencao);
            panelBotoes.Controls.Add(btnSintomas);
            panelBotoes.Controls.Add(btnOQueEHPV);
            panelBotoes.Location = new Point(50, 140);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(900, 500);
            panelBotoes.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(158, 158, 158);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(350, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(200, 50);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "🏠 Voltar ao Início";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnQuiz
            // 
            btnQuiz.BackColor = Color.FromArgb(233, 30, 99);
            btnQuiz.FlatAppearance.BorderSize = 0;
            btnQuiz.FlatStyle = FlatStyle.Flat;
            btnQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuiz.ForeColor = Color.White;
            btnQuiz.Location = new Point(500, 250);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(300, 80);
            btnQuiz.TabIndex = 5;
            btnQuiz.Text = "\U0001f9e0 Quiz Educativo";
            btnQuiz.UseVisualStyleBackColor = false;
            btnQuiz.Click += btnQuiz_Click;
            // 
            // btnEstatisticas
            // 
            btnEstatisticas.BackColor = Color.FromArgb(63, 81, 181);
            btnEstatisticas.FlatAppearance.BorderSize = 0;
            btnEstatisticas.FlatStyle = FlatStyle.Flat;
            btnEstatisticas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstatisticas.ForeColor = Color.White;
            btnEstatisticas.Location = new Point(100, 250);
            btnEstatisticas.Name = "btnEstatisticas";
            btnEstatisticas.Size = new Size(300, 80);
            btnEstatisticas.TabIndex = 4;
            btnEstatisticas.Text = "📊 Estatísticas e Dados";
            btnEstatisticas.UseVisualStyleBackColor = false;
            btnEstatisticas.Click += btnEstatisticas_Click;
            // 
            // btnDiagnostico
            // 
            btnDiagnostico.BackColor = Color.FromArgb(255, 87, 34);
            btnDiagnostico.FlatAppearance.BorderSize = 0;
            btnDiagnostico.FlatStyle = FlatStyle.Flat;
            btnDiagnostico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiagnostico.ForeColor = Color.White;
            btnDiagnostico.Location = new Point(500, 130);
            btnDiagnostico.Name = "btnDiagnostico";
            btnDiagnostico.Size = new Size(300, 80);
            btnDiagnostico.TabIndex = 3;
            btnDiagnostico.Text = "💊 Diagnóstico e Tratamento";
            btnDiagnostico.UseVisualStyleBackColor = false;
            btnDiagnostico.Click += btnDiagnostico_Click;
            // 
            // btnPrevencao
            // 
            btnPrevencao.BackColor = Color.FromArgb(0, 150, 136);
            btnPrevencao.FlatAppearance.BorderSize = 0;
            btnPrevencao.FlatStyle = FlatStyle.Flat;
            btnPrevencao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevencao.ForeColor = Color.White;
            btnPrevencao.Location = new Point(100, 130);
            btnPrevencao.Name = "btnPrevencao";
            btnPrevencao.Size = new Size(300, 80);
            btnPrevencao.TabIndex = 2;
            btnPrevencao.Text = "🛡️ Prevenção e Vacina";
            btnPrevencao.UseVisualStyleBackColor = false;
            btnPrevencao.Click += btnPrevencao_Click;
            // 
            // btnSintomas
            // 
            btnSintomas.BackColor = Color.FromArgb(156, 39, 176);
            btnSintomas.FlatAppearance.BorderSize = 0;
            btnSintomas.FlatStyle = FlatStyle.Flat;
            btnSintomas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSintomas.ForeColor = Color.White;
            btnSintomas.Location = new Point(500, 10);
            btnSintomas.Name = "btnSintomas";
            btnSintomas.Size = new Size(300, 80);
            btnSintomas.TabIndex = 1;
            btnSintomas.Text = "🔍 Sintomas e Sinais";
            btnSintomas.UseVisualStyleBackColor = false;
            btnSintomas.Click += btnSintomas_Click;
            // 
            // btnOQueEHPV
            // 
            btnOQueEHPV.BackColor = Color.FromArgb(103, 58, 183);
            btnOQueEHPV.FlatAppearance.BorderSize = 0;
            btnOQueEHPV.FlatStyle = FlatStyle.Flat;
            btnOQueEHPV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOQueEHPV.ForeColor = Color.White;
            btnOQueEHPV.Location = new Point(100, 10);
            btnOQueEHPV.Name = "btnOQueEHPV";
            btnOQueEHPV.Size = new Size(300, 80);
            btnOQueEHPV.TabIndex = 0;
            btnOQueEHPV.Text = "\U0001f9ec O que é HPV";
            btnOQueEHPV.UseVisualStyleBackColor = false;
            btnOQueEHPV.Click += btnOQueEHPV_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(147, 112, 219);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTituloMenu);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 120);
            panelHeader.TabIndex = 2;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Lavender;
            lblSubtitulo.Location = new Point(47, 70);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(385, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Escolha uma opção para aprender mais sobre prevenção";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(250, 250, 250);
            panelFooter.Controls.Add(lblVersao);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 661);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1000, 40);
            panelFooter.TabIndex = 3;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVersao.ForeColor = Color.Gray;
            lblVersao.Location = new Point(20, 12);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(254, 15);
            lblVersao.TabIndex = 0;
            lblVersao.Text = "Versão 2.0 • Desenvolvido para conscientização";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 701);
            Controls.Add(panelFooter);
            Controls.Add(panelBotoes);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 700);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal - HPV";
            Load += FormMenuPrincipal_Load;
            panelBotoes.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnOQueEHPV;
        private System.Windows.Forms.Button btnSintomas;
        private System.Windows.Forms.Button btnPrevencao;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.Button btnEstatisticas;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnVoltar;
        private Panel panelHeader;
        private Label lblSubtitulo;
        private Panel panelFooter;
        private Label lblVersao;
    }
}