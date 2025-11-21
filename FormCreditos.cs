using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public class FormCreditos : Form
    {
        private TableLayoutPanel mainTable;
        private FlowLayoutPanel leftPanel;
        private FlowLayoutPanel rightPanel;

        public FormCreditos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            // Configurações básicas do formulário
            Text = "Créditos - Projeto HPV";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            // Layout principal horizontal
            mainTable = new TableLayoutPanel();
            mainTable.Dock = DockStyle.Fill;
            mainTable.ColumnCount = 2;
            mainTable.RowCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.Padding = new Padding(10);
            mainTable.BackColor = Color.White;

            // Painel esquerdo - Informações principais
            leftPanel = new FlowLayoutPanel();
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.FlowDirection = FlowDirection.TopDown;
            leftPanel.WrapContents = false;
            leftPanel.AutoScroll = true;
            leftPanel.Padding = new Padding(15);
            leftPanel.BackColor = Color.FromArgb(248, 248, 255);

            // Painel direito - Logos e versão
            rightPanel = new FlowLayoutPanel();
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.FlowDirection = FlowDirection.TopDown;
            rightPanel.WrapContents = false;
            rightPanel.AutoScroll = true;
            rightPanel.Padding = new Padding(15);
            rightPanel.BackColor = Color.FromArgb(252, 252, 255);

            // === PAINEL ESQUERDO ===

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "Créditos";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = Color.FromArgb(120, 81, 169);
            lblTitulo.Margin = new Padding(0, 0, 0, 25);
            leftPanel.Controls.Add(lblTitulo);

            // Disciplina
            AddSection(leftPanel, "📚 Disciplina", "Programação De Computadores");

            // Professor
            AddSection(leftPanel, "👨‍🏫 Professor Responsável", "Prof. Dr. Elvio Gilberto da Silva");

            // Integrantes
            Label lblIntegrantesTitulo = new Label();
            lblIntegrantesTitulo.Text = "👥 Integrantes:";
            lblIntegrantesTitulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblIntegrantesTitulo.AutoSize = true;
            lblIntegrantesTitulo.Margin = new Padding(0, 15, 0, 8);
            leftPanel.Controls.Add(lblIntegrantesTitulo);

            string[] integrantes = {
                "• Marcos Cardoso Ferreira Marques",
                "• Kauã Campaner de Lima",
                "• Elias Henrique Peixoto",
                "• Vitor Aguiar",
                "• Matheus Kenji Zucchi Yamamoto"
            };

            foreach (string integrante in integrantes)
            {
                Label lblIntegrante = new Label();
                lblIntegrante.Text = integrante;
                lblIntegrante.Font = new Font("Segoe UI", 10);
                lblIntegrante.AutoSize = true;
                lblIntegrante.Margin = new Padding(20, 2, 0, 2);
                leftPanel.Controls.Add(lblIntegrante);
            }

            // === PAINEL DIREITO ===

            // Desenvolvimento
            Label lblDesenvolvimento = new Label();
            lblDesenvolvimento.Text = "💻 DESENVOLVIMENTO:";
            lblDesenvolvimento.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblDesenvolvimento.TextAlign = ContentAlignment.MiddleCenter;
            lblDesenvolvimento.AutoSize = true;
            lblDesenvolvimento.Margin = new Padding(0, 10, 0, 10);
            rightPanel.Controls.Add(lblDesenvolvimento);

            PictureBox picDesenvolvimento = new PictureBox();
            picDesenvolvimento.Image = Properties.Resources.Ciencia_da_Computacao;
            picDesenvolvimento.SizeMode = PictureBoxSizeMode.Zoom;
            picDesenvolvimento.Size = new Size(200, 70);
            picDesenvolvimento.Margin = new Padding(0, 0, 0, 30);
            rightPanel.Controls.Add(picDesenvolvimento);

            // Apoio
            Label lblApoio = new Label();
            lblApoio.Text = "🤝 APOIO:";
            lblApoio.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblApoio.TextAlign = ContentAlignment.MiddleCenter;
            lblApoio.AutoSize = true;
            lblApoio.Margin = new Padding(0, 10, 0, 10);
            rightPanel.Controls.Add(lblApoio);

            PictureBox picApoio = new PictureBox();
            picApoio.Image = Properties.Resources.extensão;
            picApoio.SizeMode = PictureBoxSizeMode.Zoom;
            picApoio.Size = new Size(200, 70);
            picApoio.Margin = new Padding(0, 0, 0, 30);
            rightPanel.Controls.Add(picApoio);

            // Versão
            Label lblVersao = new Label();
            lblVersao.Text = "Versão 1.0.0";
            lblVersao.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblVersao.TextAlign = ContentAlignment.MiddleCenter;
            lblVersao.AutoSize = true;
            lblVersao.ForeColor = Color.FromArgb(100, 100, 100);
            lblVersao.Margin = new Padding(0, 20, 0, 10);
            rightPanel.Controls.Add(lblVersao);

            // Botão Voltar (centralizado na parte inferior)
            TableLayoutPanel buttonPanel = new TableLayoutPanel();
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Height = 60;
            buttonPanel.ColumnCount = 1;
            buttonPanel.RowCount = 1;
            buttonPanel.BackColor = Color.Transparent;

            Button btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.BackColor = Color.FromArgb(220, 20, 60);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnVoltar.Size = new Size(120, 35);
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.Click += (s, e) => this.Close();

            buttonPanel.Controls.Add(btnVoltar, 0, 0);

            // Adicionar painéis ao layout principal
            mainTable.Controls.Add(leftPanel, 0, 0);
            mainTable.Controls.Add(rightPanel, 1, 0);

            // Adicionar tudo ao formulário
            Controls.Add(mainTable);
            Controls.Add(buttonPanel);

            ResumeLayout(false);
        }

        private void AddSection(FlowLayoutPanel panel, string titulo, string conteudo)
        {
            // Título da seção
            Label lblTituloSecao = new Label();
            lblTituloSecao.Text = titulo;
            lblTituloSecao.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTituloSecao.AutoSize = true;
            lblTituloSecao.Margin = new Padding(0, 10, 0, 5);
            panel.Controls.Add(lblTituloSecao);

            // Conteúdo da seção
            Label lblConteudo = new Label();
            lblConteudo.Text = conteudo;
            lblConteudo.Font = new Font("Segoe UI", 10);
            lblConteudo.AutoSize = true;
            lblConteudo.Margin = new Padding(15, 0, 0, 15);
            panel.Controls.Add(lblConteudo);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose dos recursos se necessário
            }
            base.Dispose(disposing);
        }
    }
}