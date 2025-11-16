using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormDiagnostico : Form
    {
        private Panel panelHeader;
        private Panel panelMain;
        private TabControl tabControlDiagnostico;
        private Button btnVoltar;

        public FormDiagnostico()
        {
            InitializeComponent();
            InitializeImprovedDesign();
            CarregarConteudoDiagnostico();
            AplicarTooltips();
            ApplyAnimations();
        }

        private void InitializeImprovedDesign()
        {
            // Configurações básicas do form
            this.Text = "Diagnóstico e Tratamento - HPV 💜";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Size = new Size(1000, 700);

            SetupHeader();
            SetupTabControl();
            SetupFooter();
        }

        private void SetupHeader()
        {
            // Painel do cabeçalho
            panelHeader = new Panel
            {
                BackColor = Color.FromArgb(147, 112, 219),
                Size = new Size(1000, 100),
                Location = new Point(0, 0),
                Dock = DockStyle.Top
            };
            this.Controls.Add(panelHeader);

            // Título principal
            var lblTitulo = new Label
            {
                Text = "🔬 Diagnóstico e Tratamento",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(50, 30)
            };
            panelHeader.Controls.Add(lblTitulo);

            // Subtítulo
            var lblSubtitulo = new Label
            {
                Text = "Conheça os exames, tratamentos e importância do diagnóstico precoce",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Lavender,
                AutoSize = true,
                Location = new Point(52, 65)
            };
            panelHeader.Controls.Add(lblSubtitulo);
        }

        private void SetupTabControl()
        {
            // TabControl principal
            tabControlDiagnostico = new TabControl
            {
                Size = new Size(900, 450),
                Location = new Point(50, 120),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ItemSize = new Size(180, 30),
                Appearance = TabAppearance.FlatButtons
            };
            this.Controls.Add(tabControlDiagnostico);

            // Aba 1: Exames de Diagnóstico
            var tabExames = new TabPage("🔬 Exames");
            tabExames.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabExames, CreateExamesContent());
            tabControlDiagnostico.Controls.Add(tabExames);

            // Aba 2: Tratamentos
            var tabTratamentos = new TabPage("💊 Tratamentos");
            tabTratamentos.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabTratamentos, CreateTratamentosContent());
            tabControlDiagnostico.Controls.Add(tabTratamentos);

            // Aba 3: Acompanhamento
            var tabAcompanhamento = new TabPage("📅 Acompanhamento");
            tabAcompanhamento.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabAcompanhamento, CreateAcompanhamentoContent());
            tabControlDiagnostico.Controls.Add(tabAcompanhamento);

            // Aba 4: Importância
            var tabImportancia = new TabPage("🎯 Importância");
            tabImportancia.BackColor = Color.FromArgb(248, 248, 255);
            SetupTabContent(tabImportancia, CreateImportanciaContent());
            tabControlDiagnostico.Controls.Add(tabImportancia);
        }

        private void SetupTabContent(TabPage tabPage, Control content)
        {
            var scrollPanel = new Panel
            {
                Size = new Size(880, 390),
                Location = new Point(10, 10),
                AutoScroll = true,
                BackColor = Color.Transparent
            };
            scrollPanel.Controls.Add(content);
            tabPage.Controls.Add(scrollPanel);
        }

        private RichTextBox CreateExamesContent()
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

            rtb.Text = @"🔬 EXAMES DE DIAGNÓSTICO DO HPV

📋 PAPANICOLAU (PREVENTIVO)
• Coleta células do colo do útero para análise
• Detecta alterações celulares pré-cancerosas
• Recomendado anualmente após início da vida sexual
• Mulheres de 25 a 64 anos: a cada 3 anos após 2 exames normais consecutivos

🧬 TESTE DE HPV (CAPTURA HÍBRIDA)
• Identifica a presença do vírus HPV no organismo
• Detecta DNA dos tipos de alto risco (oncogênicos)
• Mais sensível que o Papanicolau para detecção precoce
• Recomendado para rastreamento a partir dos 30 anos

🔍 COLPOSCOPIA
• Exame de ampliação da região genital feminina
• Realizado quando há alteração no Papanicolau
• Permite visualizar lesões não visíveis a olho nu
• Pode incluir biópsia se necessário para confirmação

🧫 BIOPSIA
• Retirada de pequeno fragmento de tecido para análise
• Confirma diagnóstico de lesões pré-cancerosas
• Define a gravidade das alterações celulares (CIN 1, 2, 3)
• Procedimento rápido realizado sob anestesia local

👨‍⚕️ PARA HOMENS
• Inspeção visual da região genital
• Biópsia de lesões suspeitas
• Teste de HPV em casos específicos
• Acompanhamento com urologista";

            return rtb;
        }

        private RichTextBox CreateTratamentosContent()
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

            rtb.Text = @"💊 TRATAMENTOS DISPONÍVEIS

🩹 TRATAMENTO PARA VERRUGAS GENITAIS
• Pomadas tópicas (Imiquimod, Podofilox)
• Crioterapia (congelamento com nitrogênio líquido)
• Eletrocauterização (queima com corrente elétrica)
• Laser ou cirurgia para casos extensos
• ⚠️ Verrugas podem recorrer após tratamento

🎯 TRATAMENTO PARA LESÕES PRÉ-CANCEROSAS
• Conização (retirada de parte do colo do útero)
• LEEP/LLETZ (excisão com alça diatérmica)
• Crioterapia para lesões menores
• Acompanhamento rigoroso após tratamento
• Preservação da fertilidade quando possível

💡 INFORMAÇÕES IMPORTANTES
• Não existe tratamento específico para eliminar o VÍRUS HPV
• Tratamos as lesões e sintomas que o vírus causa
• O sistema imunológico pode eliminar o vírus naturalmente
• 90% das infecções são eliminadas espontaneamente em 2 anos
• Manter sistema imunológico forte é fundamental

✅ EFICÁCIA DOS TRATAMENTOS
• Taxa de sucesso: 85-90% na primeira tentativa
• Lesões pré-cancerosas: 95-100% de cura
• Seguimento adequado reduz risco de recorrência
• Tratamento precoce evita complicações futuras";

            return rtb;
        }

        private RichTextBox CreateAcompanhamentoContent()
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

            rtb.Text = @"📅 ACOMPANHAMENTO MÉDICO

🔄 FREQUÊNCIA DE ACOMPANHAMENTO
• HPV sem lesões: repetir exames em 1 ano
• Lesões de baixo grau: acompanhamento a cada 6 meses
• Lesões de alto grau: tratamento imediato + acompanhamento rigoroso
• Após tratamento: controle a cada 4-6 meses por 2 anos

👨‍⚕️ ESPECIALISTAS ENVOLVIDOS
• Ginecologista: acompanhamento principal para mulheres
• Urologista: avaliação e acompanhamento para homens
• Proctologista: lesões anais em ambos os sexos
• Dermatologista: verrugas cutâneas e genitais
• Infectologista: casos complexos ou imunossuprimidos

💪 CUIDADOS PESSOAIS
• Manter exames em dia conforme recomendação médica
• Seguir tratamento prescrito rigorosamente
• Adotar hábitos saudáveis para fortalecer imunidade
• Uso de preservativos para prevenir reinfecção
• Comunicação com parceiros sobre diagnóstico

🚨 SINAIS DE ALERTA
• Surgimento de novas verrugas ou lesões
• Sangramento anormal entre menstruações
• Dor durante relações sexuais
• Coceira ou irritação persistente
• Qualquer mudança no aspecto das lesões";

            return rtb;
        }

        private RichTextBox CreateImportanciaContent()
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

            rtb.Text = @"🎯 IMPORTÂNCIA DO DIAGNÓSTICO PRECOCE

💡 POR QUE É VITAL
• Lesões pré-cancerosas são 100% curáveis quando detectadas cedo
• Câncer do colo do útero tem evolução lenta (10-20 anos)
• Detecção precoce evita tratamentos mais agressivos
• Preserva fertilidade e qualidade de vida da mulher
• Reduz significativamente a mortalidade

📊 DADOS E ESTATÍSTICAS
• 85% dos casos de câncer cervical ocorrem em países sem rastreamento adequado
• Mortalidade por câncer cervical caiu 80% com exames preventivos regulares
• Brasil registra aproximadamente 16.000 novos casos de câncer cervical por ano
• 90% desses casos seriam evitáveis com diagnóstico precoce e tratamento adequado

🏆 BENEFÍCIOS DO DIAGNÓSTICO PRECOCE
• Tratamentos menos invasivos
• Menor custo para o sistema de saúde
• Preservação da saúde reprodutiva
• Redução da ansiedade e preocupação
• Maior chance de cura completa

💌 MENSAGEM FINAL
• Não tenha medo ou vergonha de fazer os exames
• HPV é uma condição comum e tratável
• Prevenção e diagnóstico precoce salvam vidas
• Compartilhe informações com familiares e amigos
• A saúde é seu bem mais precioso - cuide dela!

📞 PROCURE AJUDA MÉDICA
• Postos de saúde oferecem exames gratuitos
• SUS disponibiliza tratamento completo
• Não espere aparecerem sintomas
• Prevenção é sempre a melhor escolha";

            return rtb;
        }

        private void SetupFooter()
        {
            // Botão Voltar
            btnVoltar = new Button
            {
                Text = "← Voltar ao Menu Principal",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(158, 158, 158),
                ForeColor = Color.White,
                Size = new Size(180, 40),
                Location = new Point(410, 590),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Click += btnVoltar_Click;

            // Efeitos hover
            btnVoltar.MouseEnter += (s, e) =>
                btnVoltar.BackColor = Color.FromArgb(120, 120, 120);
            btnVoltar.MouseLeave += (s, e) =>
                btnVoltar.BackColor = Color.FromArgb(158, 158, 158);

            this.Controls.Add(btnVoltar);
        }

        private void CarregarConteudoDiagnostico()
        {
            // Conteúdo já carregado nos RichTextBox individuais
        }

        private void AplicarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnVoltar, "Retornar ao menu principal");
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
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
            // Procura o FormMenuPrincipal aberto
            FormMenuPrincipal menuForm = FindMenuForm();

            if (menuForm != null)
            {
                menuForm.Show();
                this.Close(); // Fecha o form atual
            }
            else
            {
                // Se não encontrar, volta para o main
                FormMain main = new FormMain();
                main.Show();
                this.Close();
            }
        }

        private FormMenuPrincipal FindMenuForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormMenuPrincipal && form != this)
                {
                    return (FormMenuPrincipal)form;
                }
            }
            return null;
        }

        private void FormDiagnostico_Load(object sender, EventArgs e)
        {
            // Configuração adicional se necessário
        }

        private void FormDiagnostico_Load_1(object sender, EventArgs e)
        {

        }
    }
}