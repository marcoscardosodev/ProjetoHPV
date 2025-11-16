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
            // Esconde a tela inicial e abre o menu principal
            FormMenuPrincipal formMenu = new FormMenuPrincipal();
            formMenu.Show();
            this.Hide(); // Esconde a tela atual

            // Quando o menu principal fechar, mostra novamente a tela inicial
            formMenu.FormClosed += (s, args) => this.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormCreditos formCreditos = new FormCreditos();
            formCreditos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Configurações adicionais podem ser feitas aqui
            this.CenterToScreen();
        }
    }
}