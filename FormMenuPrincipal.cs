using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTituloMenu = new Label();
            panelBotoes = new Panel();
            btnOQueEHPV = new Button();
            btnSintomas = new Button();
            btnPrevencao = new Button();
            btnDiagnostico = new Button();
            btnEstatisticas = new Button();
            this.btnQuiz = new Button();
            this.btnVoltar = new Button();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMenu.ForeColor = Color.DarkBlue;
            lblTituloMenu.Location = new Point(50, 30);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(291, 31);
            lblTituloMenu.TabIndex = 0;
            lblTituloMenu.Text = "Menu de Navegação - HPV";
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = Color.Transparent;
            panelBotoes.Controls.Add(this.btnVoltar);
            panelBotoes.Controls.Add(this.btnQuiz);
            panelBotoes.Controls.Add(btnEstatisticas);
            panelBotoes.Controls.Add(btnDiagnostico);
            panelBotoes.Controls.Add(btnPrevencao);
            panelBotoes.Controls.Add(btnSintomas);
            panelBotoes.Controls.Add(btnOQueEHPV);
            panelBotoes.Location = new Point(50, 100);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(800, 500);
            panelBotoes.TabIndex = 1;
            // 
            // btnOQueEHPV
            // 
            btnOQueEHPV.BackColor = Color.LightSteelBlue;
            btnOQueEHPV.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOQueEHPV.Location = new Point(50, 50);
            btnOQueEHPV.Name = "btnOQueEHPV";
            btnOQueEHPV.Size = new Size(250, 60);
            btnOQueEHPV.TabIndex = 0;
            btnOQueEHPV.Text = "O que é HPV";
            btnOQueEHPV.UseVisualStyleBackColor = false;
            // 
            // btnSintomas
            // 
            btnSintomas.BackColor = Color.LightSalmon;
            btnSintomas.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSintomas.Location = new Point(350, 50);
            btnSintomas.Name = "btnSintomas";
            btnSintomas.Size = new Size(250, 60);
            btnSintomas.TabIndex = 1;
            btnSintomas.Text = "Sintomas e Sinais";
            btnSintomas.UseVisualStyleBackColor = false;
            // 
            // btnPrevencao
            // 
            btnPrevencao.BackColor = Color.LightGreen;
            btnPrevencao.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevencao.Location = new Point(50, 150);
            btnPrevencao.Name = "btnPrevencao";
            btnPrevencao.Size = new Size(250, 60);
            btnPrevencao.TabIndex = 2;
            btnPrevencao.Text = "Prevenção e Vacina";
            btnPrevencao.UseVisualStyleBackColor = false;
            // 
            // btnDiagnostico
            // 
            btnDiagnostico.BackColor = Color.LightGoldenrodYellow;
            btnDiagnostico.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiagnostico.Location = new Point(350, 150);
            btnDiagnostico.Name = "btnDiagnostico";
            btnDiagnostico.Size = new Size(250, 60);
            btnDiagnostico.TabIndex = 3;
            btnDiagnostico.Text = "Diagnóstico e Tratamento";
            btnDiagnostico.UseVisualStyleBackColor = false;
            // 
            // btnEstatisticas
            // 
            btnEstatisticas.BackColor = Color.LightPink;
            btnEstatisticas.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstatisticas.Location = new Point(50, 250);
            btnEstatisticas.Name = "btnEstatisticas";
            btnEstatisticas.Size = new Size(250, 60);
            btnEstatisticas.TabIndex = 4;
            btnEstatisticas.Text = "Estatísticas e Dados";
            btnEstatisticas.UseVisualStyleBackColor = false;
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = Color.Plum;
            this.btnQuiz.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnQuiz.Location = new Point(350, 250);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new Size(250, 60);
            this.btnQuiz.TabIndex = 5;
            this.btnQuiz.Text = "Quiz Educativo";
            this.btnQuiz.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = Color.LightCoral;
            this.btnVoltar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnVoltar.Location = new Point(350, 350);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new Size(250, 60);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar para Tela Inicial";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormMenuPrincipal
            // 
            BackColor = Color.White;
            ClientSize = new Size(884, 661);
            Controls.Add(panelBotoes);
            Controls.Add(lblTituloMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal - HPV";
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
