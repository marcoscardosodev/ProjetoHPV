using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormPrevencao : Form
    {
        private Panel panelHeader;
        private Panel panelFooter;
        private TabControl tabControlPrevencao;
        private Button btnVoltar;
        private Button btnFullScreen;
        private bool isFullScreen = false;
        private Size originalSize;
        private Point originalLocation;
        private FormWindowState originalWindowState;

        public FormPrevencao()
        {
            InitializeComponent();
            InitializeImprovedDesign();
            CarregarConteudoPrevencao();
            ApplyAnimations();
        }

        private void InitializeImprovedDesign()
        {
            // Configurações básicas do form
            this.Text = "Prevenção e Vacina - HPV 🛡️";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(1000, 750); // Aumentado para dar mais espaço
            this.Size = new Size(1000, 750);

            SetupHeader();
            SetupTabControl();
            SetupFooter();
        }

        private void SetupHeader()
        {
            // Painel do cabeçalho - MAIS ALTO para evitar sobreposição
            panelHeader = new Panel
            {
                BackColor = Color.FromArgb(0, 150, 136),
                Size = new Size(1000, 110), // Altura aumentada
                Location = new Point(0, 0),
                Dock = DockStyle.Top
            };
            this.Controls.Add(panelHeader);

            // Título principal - POSICIONADO MAIS BAIXO
            var lblTitulo = new Label
            {
                Text = "🛡️ Prevenção e Vacina",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 30) // Posição mais baixa
            };
            panelHeader.Controls.Add(lblTitulo);

            // Subtítulo - POSICIONADO MAIS BAIXO
            var lblSubtitulo = new Label
            {
                Text = "Métodos preventivos, vacinação e proteção contra o HPV",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Lavender,
                AutoSize = true,
                Location = new Point(32, 60) // Posição mais baixa
            };
            panelHeader.Controls.Add(lblSubtitulo);

            // Botão Tela Cheia - POSICIONADO MAIS BAIXO
            btnFullScreen = new Button
            {
                Text = "⛶",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(35, 25),
                Location = new Point(panelHeader.Width - 45, 35) // Posição mais baixa
            };
            btnFullScreen.Click += BtnFullScreen_Click;
            panelHeader.Controls.Add(btnFullScreen);
        }

        private void SetupTabControl()
        {
            // TabControl principal - MAIS BAIXO para não sobrepor header
            tabControlPrevencao = new TabControl
            {
                Location = new Point(30, 120), // Mais baixo para dar espaço ao header
                Size = new Size(940, 480), // Altura ajustada
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ItemSize = new Size(160, 28), // Largura reduzida para caber 4 abas
                Appearance = TabAppearance.FlatButtons
            };
            this.Controls.Add(tabControlPrevencao);

            // Aba 1: Métodos de Prevenção
            var tabPrevencao = new TabPage("🛡️ Prevenção");
            tabPrevencao.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabPrevencao, CreatePrevencaoContent());
            tabControlPrevencao.Controls.Add(tabPrevencao);

            // Aba 2: Vacinação
            var tabVacina = new TabPage("💉 Vacinas");
            tabVacina.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabVacina, CreateVacinaContent());
            tabControlPrevencao.Controls.Add(tabVacina);

            // Aba 3: Público-Alvo
            var tabPublicoAlvo = new TabPage("🎯 Público");
            tabPublicoAlvo.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabPublicoAlvo, CreatePublicoAlvoContent());
            tabControlPrevencao.Controls.Add(tabPublicoAlvo);

            // Aba 4: Eficácia
            var tabEficacia = new TabPage("📊 Eficácia");
            tabEficacia.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabEficacia, CreateEficaciaContent());
            tabControlPrevencao.Controls.Add(tabEficacia);
        }

        private void SetupTabContent(TabPage tabPage, Control content)
        {
            var scrollPanel = new Panel
            {
                Size = new Size(920, 440), // Altura ajustada
                Location = new Point(10, 10),
                AutoScroll = true,
                BackColor = Color.Transparent
            };
            scrollPanel.Controls.Add(content);
            tabPage.Controls.Add(scrollPanel);
        }

        private RichTextBox CreatePrevencaoContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(890, 600),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };

            rtb.Text = @"🛡️ MÉTODOS DE PREVENÇÃO CONTRA HPV

✅ USO CORRETO DE PRESERVATIVOS
• Reduz o risco de transmissão em 70-80%
• Deve ser usado em TODAS as relações sexuais
• Colocar antes de qualquer contato genital
• Usar do início ao fim da relação sexual

🎯 LIMITAÇÃO DE PARCEIROS SEXUAIS
• Reduz significativamente a exposição ao vírus
• Conhecer o histórico sexual dos parceiros
• Comunicação aberta sobre saúde sexual

🧼 HIGIENE PESSOAL ADEQUADA
• Manter a região genital sempre limpa e seca
• Trocar roupas íntimas diariamente
• Não compartilhar roupas íntimas ou toalhas

🏥 ACOMPANHAMENTO MÉDICO REGULAR
• Papanicolau anual para mulheres sexualmente ativas
• Consultas regulares com ginecologista/urologista
• Exames de rotina conforme recomendação médica

💪 FORTALECIMENTO DO SISTEMA IMUNOLÓGICO
• Alimentação balanceada e nutritiva
• Prática regular de exercícios físicos
• Sono adequado e qualidade de vida

🎓 EDUCAÇÃO SEXUAL
• Conhecer os riscos e formas de transmissão
• Saber identificar possíveis sintomas
• Compreender a importância da prevenção";

            return rtb;
        }

        private RichTextBox CreateVacinaContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(890, 700),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };

            rtb.Text = @"💉 VACINAÇÃO CONTRA HPV

🎯 VACINA QUADRIVALENTE (GARDASIL 4)
• Protege contra 4 tipos de HPV: 6, 11, 16 e 18
• Previne 70% dos cânceres do colo do útero
• Previne 90% das verrugas genitais
• Disponível no SUS desde 2014

🎯 VACINA NONAVALENTE (GARDASIL 9)
• Protege contra 9 tipos de HPV
• Previne 90% dos cânceres relacionados ao HPV
• Cobertura mais ampla contra tipos oncogênicos
• Disponível no SUS desde 2023

📅 ESQUEMAS VACINAIS

PARA MENORES DE 15 ANOS:
• 2 doses com intervalo de 6 meses
• Eficácia comprovada com 2 doses

PARA MAIORES DE 15 ANOS:
• 3 doses no esquema 0-2-6 meses
• 1ª dose: data escolhida
• 2ª dose: 2 meses após a primeira
• 3ª dose: 6 meses após a primeira

🏥 ONDE ENCONTRAR
• Postos de saúde do SUS (gratuito)
• Clínicas particulares de vacinação
• Centros de referência em imunização

💡 EFICÁCIA COMPROVADA
• Quase 100% de proteção contra os tipos vacinados
• Eficácia máxima quando aplicada antes da exposição
• Proteção dura pelo menos 10 anos";

            return rtb;
        }

        private RichTextBox CreatePublicoAlvoContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(890, 600),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };

            rtb.Text = @"🎯 PÚBLICO-ALVO DA VACINAÇÃO

🇧🇷 NO SISTEMA PÚBLICO (SUS)

PRIORITÁRIOS:
• Meninas de 9 a 14 anos
• Meninos de 11 a 14 anos
• Pessoas vivendo com HIV (9 a 45 anos)
• Transplantados (9 a 45 anos)

GRUPOS ESPECIAIS:
• Indivíduos imunossuprimidos
• Pacientes oncológicos
• Portadores de doenças autoimunes

🏥 NA REDE PRIVADA

MULHERES:
• Recomendado até 45 anos
• Ideal: antes do início da vida sexual
• Mesmo quem já teve HPV pode se beneficiar

HOMENS:
• Recomendado até 26 anos
• Pode ser aplicada até 45 anos com avaliação

💡 RECOMENDAÇÕES IMPORTANTES

IDADE IDEAL:
• 9 a 14 anos para máxima eficácia
• Antes do início da atividade sexual
• Período de maior resposta imunológica

QUEM JÁ TEVE HPV:
• Pode e deve se vacinar
• Vacina protege contra outros tipos não adquiridos
• Não trata infecção existente, mas previne novas";

            return rtb;
        }

        private RichTextBox CreateEficaciaContent()
        {
            var rtb = new RichTextBox
            {
                Size = new Size(890, 650),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(248, 248, 255),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true
            };

            rtb.Text = @"📊 EFICÁCIA E IMPACTO DA VACINAÇÃO

🎯 RESULTADOS COMPROVADOS

PROTEÇÃO CONTRA CÂNCER:
• 70-90% dos cânceres do colo do útero prevenidos
• 85-95% dos cânceres de ânus prevenidos
• 90% dos cânceres de vagina prevenidos
• 85% dos cânceres de vulva prevenidos

PROTEÇÃO CONTRA VERRUGAS:
• 90-100% das verrugas genitais prevenidas
• Redução drástica de papilomatose respiratória
• Melhora significativa na qualidade de vida

🌎 IMPACTO MUNDIAL

CASOS DE SUCESSO:
• Austrália: projeção de eliminar câncer cervical até 2035
• Reino Unido: redução de 87% em tipos de HPV 16/18
• Estados Unidos: queda de 40% em infecções por HPV
• Países nórdicos: cobertura acima de 80%

BRASIL:
• Meta de 80% de cobertura vacinal
• Redução de verrugas genitais em jovens
• Aumento da conscientização sobre prevenção

📈 DADOS ESTATÍSTICOS

EFICÁCIA POR IDADE:
• 9-14 anos: 98-100% de eficácia
• 15-26 anos: 95-98% de eficácia
• 27-45 anos: 85-90% de eficácia

REDUÇÃO DE LESÕES:
• 55% de redução em lesões pré-cancerosas
• 65% de redução em tratamentos cirúrgicos
• 75% de redução em procedimentos de alta complexidade

💰 IMPACTO ECONÔMICO
• Cada R$1 investido em vacinação economiza R$10 em tratamento
• Redução de custos com procedimentos médicos
• Aumento da produtividade pela prevenção de doenças";

            return rtb;
        }

        private void SetupFooter()
        {
            // Painel do rodapé
            panelFooter = new Panel
            {
                BackColor = Color.FromArgb(250, 250, 250),
                Size = new Size(1000, 35),
                Location = new Point(0, 715), // Posição ajustada
                Dock = DockStyle.Bottom
            };
            this.Controls.Add(panelFooter);

            // Versão
            var lblVersao = new Label
            {
                Text = "Programa Nacional de Imunizações • Dados atualizados 2024",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 10)
            };
            panelFooter.Controls.Add(lblVersao);

            // Botão Voltar - POSICIONADO CORRETAMENTE (fora do footer)
            btnVoltar = new Button
            {
                Text = "← Voltar ao Menu",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 150, 136),
                ForeColor = Color.White,
                Size = new Size(140, 35),
                Location = new Point(830, 625), // Posição FIXA acima do footer
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Click += btnVoltar_Click;
            this.Controls.Add(btnVoltar); // Adiciona ao FORM, não ao footer

            // Efeitos hover
            btnVoltar.MouseEnter += (s, e) => btnVoltar.BackColor = Color.FromArgb(0, 130, 116);
            btnVoltar.MouseLeave += (s, e) => btnVoltar.BackColor = Color.FromArgb(0, 150, 136);
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
            try
            {
                // Atualiza tamanho do header
                panelHeader.Width = this.ClientSize.Width;

                // Atualiza tamanho do footer
                panelFooter.Width = this.ClientSize.Width;
                panelFooter.Location = new Point(0, this.ClientSize.Height - panelFooter.Height);

                // Centraliza o tab control
                tabControlPrevencao.Location = new Point(
                    (this.ClientSize.Width - tabControlPrevencao.Width) / 2,
                    120 // Posição fixa abaixo do header
                );
                tabControlPrevencao.Height = this.ClientSize.Height - 175; // Altura ajustada

                // Ajusta botão de tela cheia - SEMPRE NO HEADER
                btnFullScreen.Location = new Point(panelHeader.Width - 45, 35);

                // Ajusta botão voltar - SEMPRE VISÍVEL E ACESSÍVEL
                btnVoltar.Location = new Point(
                    this.ClientSize.Width - 160,
                    this.ClientSize.Height - 50 // Sempre acima do footer
                );

                // Garante que o botão não fique sobreposto
                btnVoltar.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no UpdateLayout: " + ex.Message);
            }
        }

        private void CarregarConteudoPrevencao()
        {
            // Conteúdo já carregado nos métodos Create...Content()
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

        private void FormPrevencao_Load(object sender, EventArgs e)
        {
            // Configuração adicional
        }

        private void FormPrevencao_SizeChanged(object sender, EventArgs e)
        {
            UpdateLayout();
        }

        private void AplicarTooltips()
        {
            // Tooltips não são mais necessários com design de abas
        }
    }
}