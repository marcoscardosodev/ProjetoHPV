using System;
using System.Windows.Forms;
using System.Drawing;


namespace ProjetoHPV
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            
            btnIniciar.MouseEnter += (s, e) => btnIniciar.BackColor = System.Drawing.Color.FromArgb(132, 99, 210);
            btnIniciar.MouseLeave += (s, e) => btnIniciar.BackColor = System.Drawing.Color.FromArgb(147, 112, 219);

            btnSobre.MouseEnter += (s, e) => btnSobre.BackColor = System.Drawing.Color.FromArgb(166, 65, 191);
            btnSobre.MouseLeave += (s, e) => btnSobre.BackColor = System.Drawing.Color.FromArgb(186, 85, 211);

            btnSair.MouseEnter += (s, e) => btnSair.BackColor = System.Drawing.Color.FromArgb(200, 0, 40);
            btnSair.MouseLeave += (s, e) => btnSair.BackColor = System.Drawing.Color.FromArgb(220, 20, 60);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();
            this.Hide();

            menu.FormClosed += (s, args) => this.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormCreditos form = new FormCreditos();
            form.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            this.CenterToScreen();
        }


    }
}
