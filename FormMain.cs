using System;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo menu principal...", "Iniciando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Esconde a tela inicial e abre o menu principal
            FormMenuPrincipal formMenu = new FormMenuPrincipal();
            formMenu.Show();
            this.Hide(); // Esconde a tela atual

            // Quando o menu principal fechar, mostra novamente a tela inicial
            formMenu.FormClosed += (s, args) => this.Show();
        }
        
        

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto de concientização sobre o HPV\n\n" + "Desenvolvido para educar sobre prevenção, "
                + "Sintomas, Tratamento, Método de Contaminação", "Regiões mais atingidas do Papilomavírus Humano", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
