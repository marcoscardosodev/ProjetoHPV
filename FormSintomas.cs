using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormSintomas : Form
    {
        private ToolTip _toolTip;
        private Form _formAnterior; // Armazena o formulário anterior

        // Construtor modificado para receber o formulário anterior
        public FormSintomas(Form formAnterior = null)
        {
            InitializeComponent();
            _formAnterior = formAnterior;
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            try
            {
                SuspendLayout();

                // 🎯 CONFIGURAÇÕES DE ESPAÇAMENTO
                int paddingVertical = 30;
                int paddingHorizontal = 50;
                int espacamentoEntreSecoes = 25;
                int alturaBotao = 45;

                // 📏 POSICIONAMENTO DO TÍTULO
                lblTitulo.Location = new Point(paddingHorizontal, paddingVertical);
                lblTitulo.Size = new Size(ClientSize.Width - (2 * paddingHorizontal), 40);

                // 📏 POSICIONAMENTO DA INTRODUÇÃO
                lblIntroducao.Location = new Point(paddingHorizontal, lblTitulo.Bottom + 15);
                lblIntroducao.Size = new Size(ClientSize.Width - (2 * paddingHorizontal), 50);

                // 📏 POSICIONAMENTO DO PAINEL DE CONTEÚDO
                panelConteudo.Location = new Point(paddingHorizontal, lblIntroducao.Bottom + espacamentoEntreSecoes);
                panelConteudo.Size = new Size(ClientSize.Width - (2 * paddingHorizontal),
                                            ClientSize.Height - lblIntroducao.Bottom - espacamentoEntreSecoes - alturaBotao - 60);

                // 🎯 CONFIGURAÇÃO INTERNA DO PAINEL
                ConfigurarLayoutInternoPanel();

                // 📏 POSICIONAMENTO FIXO DO BOTÃO VOLTAR
                btnVoltar.Location = new Point(
                    (ClientSize.Width - btnVoltar.Width) / 2,
                    ClientSize.Height - alturaBotao - 20
                );
                btnVoltar.Size = new Size(160, alturaBotao);

                // 🏗️ VERIFICAÇÃO FINAL DE SOBREPOSIÇÃO
                VerificarSobreposicao();

                ResumeLayout();

                // 🎯 CARREGAR CONTEÚDO APÓS LAYOUT DEFINIDO
                CarregarConteudoSintomas();
                AplicarTooltips();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar layout: {ex.Message}",
                              "Erro de Layout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarLayoutInternoPanel()
        {
            try
            {
                panelConteudo.SuspendLayout();

                int paddingInterno = 25;
                int larguraConteudo = panelConteudo.Width - (2 * paddingInterno);
                int alturaSecao = (panelConteudo.Height - 100) / 3;

                // 🔍 SINTOMAS EM MULHERES
                lblMulheres.Location = new Point(paddingInterno, paddingInterno);
                lblMulheres.Size = new Size(larguraConteudo, 25);

                rtbMulheres.Location = new Point(paddingInterno, lblMulheres.Bottom + 8);
                rtbMulheres.Size = new Size(larguraConteudo, alturaSecao - 40);

                // 🔍 SINTOMAS EM HOMENS
                lblHomens.Location = new Point(paddingInterno, rtbMulheres.Bottom + 20);
                lblHomens.Size = new Size(larguraConteudo, 25);

                rtbHomens.Location = new Point(paddingInterno, lblHomens.Bottom + 8);
                rtbHomens.Size = new Size(larguraConteudo, alturaSecao - 40);

                // ⚠️ QUANDO PROCURAR MÉDICO
                lblQuandoMedico.Location = new Point(paddingInterno, rtbHomens.Bottom + 20);
                lblQuandoMedico.Size = new Size(larguraConteudo, 25);

                rtbRecomendacoes.Location = new Point(paddingInterno, lblQuandoMedico.Bottom + 8);
                rtbRecomendacoes.Size = new Size(larguraConteudo, alturaSecao - 40);

                panelConteudo.ResumeLayout();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na configuração interna do painel: {ex.Message}");
            }
        }

        private void VerificarSobreposicao()
        {
            // 🏗️ VERIFICAÇÃO DE SOBREPOSIÇÃO ENTRE ELEMENTOS
            var elementos = new Control[] { lblTitulo, lblIntroducao, panelConteudo, btnVoltar };

            for (int i = 0; i < elementos.Length; i++)
            {
                for (int j = i + 1; j < elementos.Length; j++)
                {
                    if (elementos[i].Bounds.IntersectsWith(elementos[j].Bounds))
                    {
                        throw new InvalidOperationException(
                            $"Sobreposição detectada entre {elementos[i].Name} e {elementos[j].Name}");
                    }
                }
            }

            // ✅ VERIFICAÇÃO DE VISIBILIDADE DO BOTÃO
            if (btnVoltar.Top < panelConteudo.Bottom + 10)
            {
                int novaAlturaPanel = btnVoltar.Top - panelConteudo.Top - 20;
                if (novaAlturaPanel > 200) // Altura mínima
                {
                    panelConteudo.Height = novaAlturaPanel;
                    ConfigurarLayoutInternoPanel();
                }
            }
        }

        private void CarregarConteudoSintomas()
        {
            try
            {
                // Sintomas em Mulheres
                rtbMulheres.Text = "• Verrugas genitais (condilomas) na vulva, vagina, colo do útero\n" +
                                 "• Coceira, ardência ou desconforto na região genital\n" +
                                 "• Sangramento após relação sexual\n" +
                                 "• Corrimento vaginal anormal\n" +
                                 "• Lesões pré-cancerosas (detectadas apenas no exame Papanicolau)\n" +
                                 "• ⚠️ Na maioria dos casos: NENHUM sintoma aparente";

                // Sintomas em Homens
                rtbHomens.Text = "• Verrugas genitais no pênis, bolsa escrotal, virilha ou ânus\n" +
                               "• Coceira ou irritação na região genital\n" +
                               "• Verrugas na boca ou garganta (menos comum)\n" +
                               "• Dificuldade para urinar (casos raros de verrugas na uretra)\n" +
                               "• ⚠️ Na maioria dos casos: NENHUM sintoma aparente";

                // Recomendações - Quando procurar médico
                rtbRecomendacoes.Text = "• Ao notar QUALQUER verruga, lesão ou caroço na região genital\n" +
                                      "• Em caso de coceira, ardência ou irritação persistente\n" +
                                      "• Se houver sangramento fora do período menstrual\n" +
                                      "• Após relação sexual desprotegida com parceiro novo\n" +
                                      "• Para exames de rotina: Papanicolau anualmente para mulheres\n" +
                                      "• Homens também devem fazer check-ups regulares\n" +
                                      "• ✅ LEMBRE-SE: Muitas pessoas com HPV não têm sintomas!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar conteúdo: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AplicarTooltips()
        {
            try
            {
                _toolTip = new ToolTip();

                // 🎯 TOOLTIPS INFORMATIVOS
                _toolTip.SetToolTip(rtbMulheres, "Sintomas específicos para mulheres - muitos casos são assintomáticos");
                _toolTip.SetToolTip(rtbHomens, "Sintomas específicos para homens - a maioria não apresenta sintomas");
                _toolTip.SetToolTip(rtbRecomendacoes, "Importante: Procure um médico mesmo sem sintomas para exames preventivos");
                _toolTip.SetToolTip(btnVoltar, "Voltar para o menu principal");

                // ⚙️ CONFIGURAÇÕES DO TOOLTIP
                _toolTip.AutoPopDelay = 5000;
                _toolTip.InitialDelay = 1000;
                _toolTip.ReshowDelay = 500;
                _toolTip.ShowAlways = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao aplicar tooltips: {ex.Message}");
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (WindowState != FormWindowState.Minimized)
            {
                UpdateLayout();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarParaMenu();
        }

        private void VoltarParaMenu()
        {
            try
            {
                
                if (_formAnterior != null)
                {
                    _formAnterior.Show();
                    this.Hide();
                }
                else
                {
                    
                    Form menuPrincipal = Application.OpenForms["FormMenuPrincipal"];

                    if (menuPrincipal != null)
                    {
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        
                        CriarNovoMenu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao voltar para o menu: {ex.Message}\nTentando abrir novo menu...",
                              "Erro de Navegação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CriarNovoMenu();
            }
        }

        private void CriarNovoMenu()
        {
            try
            {
                
                Form menuPrincipal = new Form(); 
                menuPrincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível voltar ao menu. Erro: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            
            if (e.CloseReason == CloseReason.UserClosing && _formAnterior != null)
            {
                _formAnterior.Show();
            }
        }

        private void FormSintomas_Load(object sender, EventArgs e)
        {
            UpdateLayout();
        }
    }
}