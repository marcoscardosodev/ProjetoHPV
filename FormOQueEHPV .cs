using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormOQueEHPV : Form
    {
        private Panel panelHeader;
        private Panel panelFooter;
        private Panel panelConteudo;
        private Button btnVoltar;
        private Button btnFullScreen;
        private bool isFullScreen = false;
        private Size originalSize;
        private Point originalLocation;
        private FormWindowState originalWindowState;

        // Controles para acesso externo
        private Label lblTextoPrincipal;
        private RichTextBox rtbTipos;
        private RichTextBox rtbTransmissao;
        private RichTextBox rtbImportancia;

        public FormOQueEHPV()
        {
            InitializeComponent();
            InitializeImprovedDesign();
            CarregarConteudo();
            ApplyAnimations();
        }

        private void InitializeImprovedDesign()
        {
            // Configurações básicas do form
            this.Text = "O que é HPV? 🧬";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(1000, 750); 
            this.Size = new Size(1000, 750);

            SetupHeader();
            SetupContent();
            SetupFooter();
        }

        private void SetupHeader()
        {
            // Painel do cabeçalho
            panelHeader = new Panel
            {
                BackColor = Color.FromArgb(103, 58, 183),
                Size = new Size(1000, 100), 
                Location = new Point(0, 0),
                Dock = DockStyle.Top
            };
            this.Controls.Add(panelHeader);

            // Título principal
            var lblTitulo = new Label
            {
                Text = "🧬 O que é HPV?",
                Font = new Font("Segoe UI", 20, FontStyle.Bold), 
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 25)
            };
            panelHeader.Controls.Add(lblTitulo);

            // Subtítulo
            var lblSubtitulo = new Label
            {
                Text = "Conheça o Papilomavírus Humano - tipos, transmissão e importância",
                Font = new Font("Segoe UI", 9, FontStyle.Regular), 
                ForeColor = Color.Lavender,
                AutoSize = true,
                Location = new Point(32, 55)
            };
            panelHeader.Controls.Add(lblSubtitulo);

            // Botão Tela Cheia
            btnFullScreen = new Button
            {
                Text = "⛶",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(35, 25),
                Location = new Point(panelHeader.Width - 45, 15)
            };
            btnFullScreen.Click += BtnFullScreen_Click;
            panelHeader.Controls.Add(btnFullScreen);
        }

        private void SetupContent()
        {
            // Painel de conteúdo com scroll 
            panelConteudo = new Panel
            {
                Location = new Point(30, 110),
                Size = new Size(940, 500),
                AutoScroll = true,
                BackColor = Color.Transparent,
                AutoScrollMinSize = new Size(920, 1600) 
            };
            this.Controls.Add(panelConteudo);

            int yPos = 20;

            // Texto principal
            lblTextoPrincipal = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 10, FontStyle.Regular), 
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(20, yPos),
                Size = new Size(880, 120), 
                TextAlign = ContentAlignment.TopLeft
            };
            panelConteudo.Controls.Add(lblTextoPrincipal);
            yPos += 130;

            // Seção: Tipos de HPV
            var lblTiposTitulo = new Label
            {
                Text = "📋 TIPOS DE HPV",
                Font = new Font("Segoe UI", 13, FontStyle.Bold), 
                ForeColor = Color.FromArgb(156, 39, 176),
                Location = new Point(20, yPos),
                AutoSize = true
            };
            panelConteudo.Controls.Add(lblTiposTitulo);
            yPos += 30;

            rtbTipos = new RichTextBox
            {
                Location = new Point(40, yPos),
                Size = new Size(860, 180), 
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular), 
                ReadOnly = true,
                ScrollBars = RichTextBoxScrollBars.Vertical
            };
            panelConteudo.Controls.Add(rtbTipos);
            yPos += 200;

            // Seção: Transmissão
            var lblTransmissaoTitulo = new Label
            {
                Text = "🔄 FORMAS DE TRANSMISSÃO",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 150, 243),
                Location = new Point(20, yPos),
                AutoSize = true
            };
            panelConteudo.Controls.Add(lblTransmissaoTitulo);
            yPos += 30;

            rtbTransmissao = new RichTextBox
            {
                Location = new Point(40, yPos),
                Size = new Size(860, 220), 
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ReadOnly = true,
                ScrollBars = RichTextBoxScrollBars.Vertical
            };
            panelConteudo.Controls.Add(rtbTransmissao);
            yPos += 240;

            // Seção: Importância
            var lblImportanciaTitulo = new Label
            {
                Text = "🎯 POR QUE É IMPORTANTE?",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 87, 34),
                Location = new Point(20, yPos),
                AutoSize = true
            };
            panelConteudo.Controls.Add(lblImportanciaTitulo);
            yPos += 30;

            rtbImportancia = new RichTextBox
            {
                Location = new Point(40, yPos),
                Size = new Size(860, 250), 
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ReadOnly = true,
                ScrollBars = RichTextBoxScrollBars.Vertical
            };
            panelConteudo.Controls.Add(rtbImportancia);
        }

        private void SetupFooter()
        {
            // Painel do rodapé
            panelFooter = new Panel
            {
                BackColor = Color.FromArgb(250, 250, 250),
                Size = new Size(1000, 35),
                Location = new Point(0, 715),
                Dock = DockStyle.Bottom
            };
            this.Controls.Add(panelFooter);

            // Versão
            var lblVersao = new Label
            {
                Text = "Informações baseadas em dados da OMS e Ministério da Saúde",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 10)
            };
            panelFooter.Controls.Add(lblVersao);

            // Botão Voltar 
            btnVoltar = new Button
            {
                Text = "← Voltar ao Menu",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(103, 58, 183), 
                ForeColor = Color.White,
                Size = new Size(140, 35),
                Location = new Point(830, 625), 
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Click += btnVoltar_Click;
            this.Controls.Add(btnVoltar);

            // Efeitos hover
            btnVoltar.MouseEnter += (s, e) => btnVoltar.BackColor = Color.FromArgb(83, 38, 163);
            btnVoltar.MouseLeave += (s, e) => btnVoltar.BackColor = Color.FromArgb(103, 58, 183);
            btnFullScreen.MouseEnter += (s, e) => btnFullScreen.BackColor = Color.FromArgb(100, 100, 100, 100);
            btnFullScreen.MouseLeave += (s, e) => btnFullScreen.BackColor = Color.Transparent;
        }

        private void CarregarConteudo()
        {
            // Texto principal 
            lblTextoPrincipal.Text = @"O HPV (Papilomavírus Humano) é um grupo de mais de 200 tipos de vírus que infectam a pele e mucosas. É uma das Infecções Sexualmente Transmissíveis (ISTs) mais comuns no mundo.

📈 PREVALÊNCIA:
• 80% das pessoas sexualmente ativas terão contato com o vírus
• 630 milhões de pessoas infectadas mundialmente
• 29 milhões de novos casos por ano

🔬 CARACTERÍSTICAS:
• Infecta exclusivamente seres humanos
• Pode permanecer latente por anos
• 90% das infecções são eliminadas naturalmente";

            // Tipos de HPV - conteúdo otimizado
            rtbTipos.Text = @"🟢 HPV DE BAIXO RISCO:
• Tipos: 6, 11, 40, 42, 43, 44, 54
• Causam verrugas genitais (condilomas)
• Raramente evoluem para câncer
• HPV-6 e 11: 90% das verrugas genitais

🔴 HPV DE ALTO RISCO:
• Tipos: 16, 18, 31, 33, 35, 39, 45, 51, 52, 56, 58, 59, 68
• Podem causar lesões pré-cancerosas
• Associados a vários tipos de câncer
• HPV-16 e 18: 70% dos cânceres cervicais

💡 DISTRIBUIÇÃO:
• HPV-16: 35% dos casos
• HPV-18: 20% dos casos  
• Outros tipos: 45% dos casos";

            // Transmissão - conteúdo otimizado
            rtbTransmissao.Text = @"🔀 PRINCIPAIS FORMAS:

🎯 TRANSMISSÃO SEXUAL:
• Relações sexuais vaginais, anais e orais
• Contato pele a pele na região genital
• Pode ocorrer sem penetração
• Preservativo reduz risco em 70%

👥 OUTRAS FORMAS:
• Mãe para bebê durante parto
• Compartilhamento roupas íntimas (raro)
• Instrumentos médicos não esterilizados

⚠️ FATORES DE RISCO:
• Início precoce da vida sexual
• Múltiplos parceiros sexuais
• Sistema imunológico comprometido
• Tabagismo
• Não uso de preservativos

✅ PREVENÇÃO:
• Vacinação antes da vida sexual
• Uso correto de preservativos
• Exames ginecológicos regulares
• Sistema imunológico forte";

            // Importância - conteúdo otimizado
            rtbImportancia.Text = @"🎯 IMPACTO NA SAÚDE:

🦠 RELAÇÃO COM CÂNCER:
• HPV causa 100% dos cânceres do colo do útero
• 90% dos cânceres anais
• 70% dos cânceres de vagina
• 50% dos cânceres de pênis
• 70% dos cânceres de orofaringe

💡 POR QUE SE PREOCUPAR?
• Pode ficar anos sem sintomas
• Diagnóstico tardio reduz cura
• Tratamento complexo em estágios avançados
• Pode afetar fertilidade
• Custo emocional significativo

🎊 BOAS NOTÍCIAS:
• Lesões pré-cancerosas: 100% curáveis
• Vacina é altamente eficaz
• Exames permitem diagnóstico precoce
• Sistema imunológico elimina 90% das infecções

🌟 MENSAGEM FINAL:
Conhecer o HPV é o primeiro passo para se proteger. 
Vacine-se, faça exames regularmente e compartilhe 
esse conhecimento!";
        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            ToggleFullScreen();
        }

        private void ToggleFullScreen()
        {
            if (!isFullScreen)
            {
                originalSize = this.Size;
                originalLocation = this.Location;
                originalWindowState = this.WindowState;

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                isFullScreen = true;
                btnFullScreen.Text = "⛷";
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = originalWindowState;
                this.Size = originalSize;
                this.Location = originalLocation;
                isFullScreen = false;
                btnFullScreen.Text = "⛶";
            }
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            if (panelHeader == null || panelFooter == null || panelConteudo == null)
                return;

            panelHeader.Width = this.ClientSize.Width;
            panelFooter.Width = this.ClientSize.Width;
            panelFooter.Location = new Point(0, this.ClientSize.Height - panelFooter.Height);

            panelConteudo.Location = new Point(
                (this.ClientSize.Width - panelConteudo.Width) / 2,
                140
            );
            panelConteudo.Height = this.ClientSize.Height - 220;

            if (btnFullScreen != null)
                btnFullScreen.Location = new Point(panelHeader.Width - 50, 15);

            if (btnVoltar != null)
                btnVoltar.Location = new Point(
                    this.ClientSize.Width - 170,
                    this.ClientSize.Height - 60
                );
        }


        private void ApplyAnimations()
        {
            this.Opacity = 0;
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity > 0)
                    this.Opacity -= 0.05;
                else
                {
                    fadeTimer.Stop();
                    VoltarParaMenu();
                }
            };
            fadeTimer.Start();
        }

        private void VoltarParaMenu()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormMenuPrincipal)
                {
                    form.Show();
                    break;
                }
            }
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F11)
            {
                ToggleFullScreen();
                return true;
            }
            if (keyData == Keys.Escape && isFullScreen)
            {
                ToggleFullScreen();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormOQueEHPV_Load(object sender, EventArgs e)
        {
            
        }

        private void FormOQueEHPV_SizeChanged(object sender, EventArgs e)
        {
            UpdateLayout();
        }

        private void lblTextoPrincipal_Click(object sender, EventArgs e)
        {
            
        }
    }
}