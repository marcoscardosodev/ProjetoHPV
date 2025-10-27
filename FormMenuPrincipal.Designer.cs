using System;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormMenuPrincipal : Form
    {
       

        private void btnOQueEHPV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo tela: O que é HPV", "Navegação",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSintomas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo tela: Sintomas e Sinais", "Navegação",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrevencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo tela: Prevenção e Vacina", "Navegação",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo tela: Diagnóstico e Tratamento", "Navegação",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo tela: Estatísticas e Dados", "Navegação",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo tela: Quiz Educativo", "Navegação",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha este form e volta para o principal
            this.Close();
        }
        private Label lblTituloMenu;
        private Panel panelBotoes;
        private Button btnSintomas;
        private Button btnOQueEHPV;
        private Button btnEstatisticas;
        private Button btnDiagnostico;
        private Button btnPrevencao;
        private Button btnVoltar;
        private Button btnQuiz;
    }
}