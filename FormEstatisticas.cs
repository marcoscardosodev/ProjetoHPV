using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormEstatisticas : Form
    {
        private bool _isInitialized = false;
        private Panel panelHeader;
        private Panel panelFooter;
        private TabControl tabControlEstatisticas;
        private Button btnVoltar;
        private Button btnFullScreen;
        private bool isFullScreen = false;
        private Size originalSize;
        private Point originalLocation;
        private FormWindowState originalWindowState;

        public FormEstatisticas()
        {
            InitializeComponent();
            InitializeImprovedDesign();
            CarregarDadosEstatisticos();
            ApplyAnimations();
        }

        private void InitializeImprovedDesign()
        {
            // Configurações básicas do form 
            this.Text = "Estatísticas e Dados - HPV 📊";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(1000, 700);
            this.Size = new Size(1000, 700);

            SetupHeader();
            SetupTabControl();
            SetupFooter();
            _isInitialized = true;
        }

        private void SetupHeader()
        {
            // Painel do cabeçalho 
            panelHeader = new Panel
            {
                BackColor = Color.FromArgb(63, 81, 181), // Azul para estatísticas 
                Size = new Size(1000, 120),
                Location = new Point(0, 0),
                Dock = DockStyle.Top
            };
            this.Controls.Add(panelHeader);

            // Título principal 
            var lblTitulo = new Label
            {
                Text = "📊 Estatísticas e Dados",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(50, 30)
            };
            panelHeader.Controls.Add(lblTitulo);

            // Subtítulo 
            var lblSubtitulo = new Label
            {
                Text = "Dados atualizados sobre prevalência, prevenção e tipos de HPV",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.Lavender,
                AutoSize = true,
                Location = new Point(52, 70)
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
                Size = new Size(40, 30),
                Location = new Point(panelHeader.Width - 50, 15)
            };
            btnFullScreen.Click += BtnFullScreen_Click;
            panelHeader.Controls.Add(btnFullScreen);
        }

        private void SetupTabControl()
        {
            // TabControl principal 
            tabControlEstatisticas = new TabControl
            {
                Location = new Point(50, 140),
                Size = new Size(900, 450),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ItemSize = new Size(180, 30),
                Appearance = TabAppearance.FlatButtons
            };
            this.Controls.Add(tabControlEstatisticas);

            // Aba 1: Dados Estatísticos 
            var tabPageDados = new TabPage("📊 Dados Estatísticos");
            tabPageDados.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabPageDados, CreateDadosContent());
            tabControlEstatisticas.Controls.Add(tabPageDados);

            // Aba 2: Prevenção e Impacto 
            var tabPagePrevencao = new TabPage("🛡️ Prevenção e Impacto");
            tabPagePrevencao.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabPagePrevencao, CreatePrevencaoContent());
            tabControlEstatisticas.Controls.Add(tabPagePrevencao);

            // Aba 3: Tipos de HPV 
            var tabPageTipos = new TabPage("🔬 Tipos de HPV");
            tabPageTipos.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabPageTipos, CreateTiposContent());
            tabControlEstatisticas.Controls.Add(tabPageTipos);
        }

        private void SetupTabContent(TabPage tabPage, Control content)
        {
            var scrollPanel = new Panel
            {
                Size = new Size(880, 420),
                Location = new Point(10, 10),
                AutoScroll = true,
                BackColor = Color.Transparent
            };
            scrollPanel.Controls.Add(content);
            tabPage.Controls.Add(scrollPanel);
        }

        private RichTextBox CreateDadosContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(850, 800),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };
            rtb.Text = @"📊 DADOS ESTATÍSTICOS SOBRE HPV 

🌍 PREVALÊNCIA MUNDIAL:
• 80% da população sexualmente ativa terá contato com HPV
• 630 milhões de pessoas infectadas atualmente
• 29 milhões de novos casos por ano no mundo
• 311.000 mortes por câncer cervical anualmente
• 570.000 novos casos de câncer cervical por ano

🇧🇷 REALIDADE BRASILEIRA:
• 700.000 novos casos de HPV por ano
• 16.590 novos casos de câncer cervical anualmente
• 6.500 mortes por câncer cervical por ano
• 2º câncer mais comum em mulheres brasileiras
• 4ª causa de morte por câncer em mulheres

💉 SITUAÇÃO DA VACINAÇÃO:
• Cobertura vacinal no Brasil: 54% (meta: 80%)
• Austrália: 85% de cobertura (caminho para eliminação)
• Meninas 9-14 anos: público-alvo principal
• Meninos 11-14 anos: incluídos desde 2017
• SUS: vacina quadrivalente gratuita

📈 TENDÊNCIAS:
• Redução de 90% em verrugas genitais em países com alta vacinação
• Queda de 50% em lesões pré-cancerosas em mulheres vacinadas
• Austrália projeta eliminação do câncer cervical até 2035";
            return rtb;
        }

        private RichTextBox CreatePrevencaoContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(850, 800),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };
            rtb.Text = @"🛡️ IMPACTO DA PREVENÇÃO 

🎯 EFICÁCIA DA VACINAÇÃO:
• Reduz 90% das verrugas genitais
• Previne 70% dos cânceres cervicais
• Quase 100% eficaz antes da exposição ao vírus
• Proteção dura pelo menos 10 anos
• Eficaz em 97% dos casos para tipos cobertos

📋 DIAGNÓSTICO PRECOCE:
• Papanicolau reduz mortalidade em 80%
• Lesões pré-cancerosas têm 100% de cura
• Câncer cervical inicial: 92% de sobrevivência em 5 anos
• Teste de HPV aumenta detecção em 30%
• Rastreamento salva 22.000 vidas/ano no Brasil

💰 ANÁLISE DE CUSTOS:
• Tratamento completo: R$ 5.000 - R$ 50.000
• Vacina particular: R$ 400 - R$ 800 por dose
• SUS oferece vacina e tratamento gratuitos
• Custo-benefício: R$ 1 em prevenção = R$ 10 em tratamento
• Produtividade: cada caso evitado = 20 dias de trabalho preservados

✅ IMPACTO SOCIAL:
• Redução da desigualdade no acesso à saúde
• Empoderamento feminino através da informação
• Quebra de tabus sobre saúde sexual
• Educação como principal ferramenta de prevenção
• Diagnóstico precoce preserva fertilidade

💡 MENSAGEM ESTRATÉGICA:
• Prevenção é 10x mais eficaz que tratamento
• Vacinação + exames = combinação perfeita
• Conhecimento salva vidas - compartilhe informações
• Saúde é direito de todos - exija seus direitos
• Jovens informados = adultos saudáveis";
            return rtb;
        }

        private RichTextBox CreateTiposContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(850, 800),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };
            rtb.Text = @"🔬 TIPOS DE HPV E SUAS CARACTERÍSTICAS 

📈 DISTRIBUIÇÃO DOS PRINCIPAIS TIPOS:
• HPV-16: 35% dos casos (alto risco oncogênico)
• HPV-18: 20% dos casos (alto risco oncogênico)
• HPV-6: 8% dos casos (baixo risco - verrugas)
• HPV-11: 4% dos casos (baixo risco - verrugas)
• Outros tipos: 33% dos casos

🎯 TIPOS DE ALTO RISCO (ONCOGÊNICOS):
• Principais: 16, 18, 31, 33, 35, 39, 45, 51, 52, 56, 58, 59, 68
• Causam lesões pré-cancerosas e cancerosas
• Responsáveis por 90% dos cânceres cervicais
• HPV-16 sozinho causa 50% dos cânceres cervicais
• Também associados a câncer de pênis, ânus e orofaringe

🟢 TIPOS DE BAIXO RISCO (NÃO-ONCOGÊNICOS):
• Principais: 6, 11, 40, 42, 43, 44, 54, 61, 72
• Causam verrugas genitais e papilomas
• Raramente evoluem para câncer
• HPV-6 e 11 causam 90% das verrugas genitais
• Podem causar desconforto, mas não risco vital

💊 PROTEÇÃO DA VACINA:
• Vacina Quadrivalente: protege contra 6, 11, 16, 18
• Vacina Nonavalente: protege contra 7 tipos de alto risco + 2 de baixo
• Cobertura: 90% dos casos de câncer cervical
• Eficácia: 97% para os tipos cobertos
• Importante: não protege contra todos os 200+ tipos

🔬 CURIOSIDADES CIENTÍFICAS:
• 90% das infecções são eliminadas naturalmente em 2 anos
• Sistema imunológico é capaz de controlar a maioria das infecções
• Fumo e imunossupressão aumentam persistência do vírus
• Mais de 200 tipos de HPV identificados
• Apenas 14 tipos são considerados de alto risco

⚠️ FATORES DE RISCO:
• Início precoce da vida sexual
• Múltiplos parceiros sexuais
• Tabagismo
• Imunossupressão
• Não uso de preservativos";
            return rtb;
        }

        private void SetupFooter()
        {
            // Painel do rodapé 
            panelFooter = new Panel
            {
                BackColor = Color.FromArgb(250, 250, 250),
                Size = new Size(1000, 40),
                Location = new Point(0, 660),
                Dock = DockStyle.Bottom
            };
            this.Controls.Add(panelFooter);

            // Versão 
            var lblVersao = new Label
            {
                Text = "Dados atualizados 2024 • Fonte: OMS, INCA, Ministério da Saúde",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 12)
            };
            panelFooter.Controls.Add(lblVersao);

            // Botão Voltar - AGORA NO RODAPÉ
            btnVoltar = new Button
            {
                Text = "← Voltar ao Menu",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(63, 81, 181),
                ForeColor = Color.White,
                Size = new Size(120, 30),
                Location = new Point(panelFooter.Width - 140, 5),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Click += btnVoltar_Click;

            // Efeitos hover melhorados
            btnVoltar.MouseEnter += (s, e) =>
            {
                btnVoltar.BackColor = Color.FromArgb(48, 63, 159);
                btnVoltar.ForeColor = Color.White;
            };
            btnVoltar.MouseLeave += (s, e) =>
            {
                btnVoltar.BackColor = Color.FromArgb(63, 81, 181);
                btnVoltar.ForeColor = Color.White;
            };

            panelFooter.Controls.Add(btnVoltar);

            // Efeitos hover para botão fullscreen
            btnFullScreen.MouseEnter += (s, e) => btnFullScreen.BackColor = Color.FromArgb(100, 100, 100, 100);
            btnFullScreen.MouseLeave += (s, e) => btnFullScreen.BackColor = Color.Transparent;
        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            ToggleFullScreen();
        }

        private void ToggleFullScreen()
        {
            if (!isFullScreen)
            {
                // Entra em tela cheia 
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
                // Sai da tela cheia 
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
            if (!_isInitialized) return;

            panelHeader.Width = this.ClientSize.Width;
            panelFooter.Width = this.ClientSize.Width;
            panelFooter.Location = new Point(0, this.ClientSize.Height - panelFooter.Height);

            tabControlEstatisticas.Location = new Point(
                (this.ClientSize.Width - tabControlEstatisticas.Width) / 2,
                140
            );
            tabControlEstatisticas.Height = this.ClientSize.Height - 220;

            btnFullScreen.Location = new Point(panelHeader.Width - 50, 15);

            // Atualiza posição do botão voltar no rodapé
            btnVoltar.Location = new Point(
                panelFooter.Width - 130,
                5
            );
        }

        private void CarregarDadosEstatisticos()
        {
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
            // Animação de saída 
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

        // Atalhos de teclado 
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
            if (keyData == Keys.Escape)
            {
                btnVoltar_Click(null, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            if (!_isInitialized) return;
        }

        private void FormEstatisticas_SizeChanged(object sender, EventArgs e)
        {
            UpdateLayout();
        }
    }
}