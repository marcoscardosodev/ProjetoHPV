using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoHPV
{
    public partial class FormQuiz : Form
    {
        private int perguntaAtual = 0;
        private int pontuacao = 0;
        private Pergunta[] perguntas;
        private List<int> ordemRespostas = new List<int>();

        // Controles do quiz
        private Panel panelQuiz;
        private Panel panelResultado;
        private ProgressBar progressoQuiz;
        private Label lblExplicacao;
        private Button btnProxima;
        private Button btnOpcao1;
        private Button btnOpcao2;
        private Button btnOpcao3;
        private Button btnOpcao4;
        private Label lblPergunta;
        private Button btnReiniciar;
        private Label lblResultado;
        private Button btnVoltar;

        // Controles para design responsivo
        private Panel panelHeader;
        private Panel panelFooter;
        private Button btnFullScreen;
        private bool isFullScreen = false;
        private Size originalSize;
        private Point originalLocation;
        private FormWindowState originalWindowState;

        public FormQuiz()
        {
            InitializeComponent();
            InitializeImprovedDesign();
            InicializarPerguntas();
            MostrarPergunta();
            ApplyAnimations();
        }

        private void InitializeImprovedDesign()
        {
            // Configurações básicas do form
            this.Text = "Quiz Educativo - HPV 🧠";
            this.BackColor = Color.FromArgb(245, 245, 255);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(1100, 800);
            this.Size = new Size(1100, 800);
            this.Icon = SystemIcons.Shield;

            // Criar todos os controles programaticamente
            CreateQuizControls();
            SetupHeader();
            SetupQuizContent();
            SetupFooter();
        }

        private void CreateQuizControls()
        {
            // Painel do Quiz com sombra visual - MAIS ALTO
            panelQuiz = new Panel();
            panelQuiz.Location = new Point(80, 120);
            panelQuiz.Size = new Size(940, 600);
            panelQuiz.BackColor = Color.White;
            panelQuiz.BorderStyle = BorderStyle.None;
            panelQuiz.Visible = true;

            // Efeito de sombra
            panelQuiz.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panelQuiz.ClientRectangle,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.FromArgb(200, 200, 220), 2, ButtonBorderStyle.Solid);
            };

            // Painel de Resultado
            panelResultado = new Panel();
            panelResultado.Location = new Point(80, 120);
            panelResultado.Size = new Size(940, 600);
            panelResultado.BackColor = Color.White;
            panelResultado.Visible = false;
            panelResultado.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panelResultado.ClientRectangle,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.FromArgb(200, 200, 220), 2, ButtonBorderStyle.Solid);
            };

            // Label da Pergunta - MAIS CURTA
            lblPergunta = new Label();
            lblPergunta.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblPergunta.Location = new Point(30, 25);
            lblPergunta.Size = new Size(880, 60);
            lblPergunta.Text = "Pergunta 1/20: Carregando...";
            lblPergunta.ForeColor = Color.FromArgb(64, 64, 64);
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            panelQuiz.Controls.Add(lblPergunta);

            // Botões das Opções - MAIS COMPACTOS
            btnOpcao1 = CreateModernOptionButton("Opção A", 40, 95);
            btnOpcao2 = CreateModernOptionButton("Opção B", 40, 155);
            btnOpcao3 = CreateModernOptionButton("Opção C", 40, 215);
            btnOpcao4 = CreateModernOptionButton("Opção D", 40, 275);

            // Label de Explicação - MAIS COMPACTA
            lblExplicacao = new Label();
            lblExplicacao.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblExplicacao.Location = new Point(40, 345);
            lblExplicacao.Size = new Size(860, 80);
            lblExplicacao.Text = "Selecione uma resposta para ver a explicação...";
            lblExplicacao.ForeColor = Color.FromArgb(120, 120, 120);
            lblExplicacao.TextAlign = ContentAlignment.MiddleCenter;
            lblExplicacao.AutoSize = false;
            panelQuiz.Controls.Add(lblExplicacao);

            // BOTÃO PRÓXIMA - AGORA MAIS VISÍVEL
            btnProxima = new Button();
            btnProxima.Text = "Próxima Pergunta →";
            btnProxima.BackColor = Color.FromArgb(106, 27, 154);
            btnProxima.FlatStyle = FlatStyle.Flat;
            btnProxima.FlatAppearance.BorderSize = 0;
            btnProxima.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnProxima.ForeColor = Color.White;
            btnProxima.Location = new Point(370, 440);
            btnProxima.Size = new Size(200, 45);
            btnProxima.Enabled = false;
            btnProxima.Click += btnProxima_Click;

            // Efeitos hover do botão próxima
            btnProxima.MouseEnter += (s, e) => btnProxima.BackColor = Color.FromArgb(86, 7, 134);
            btnProxima.MouseLeave += (s, e) => btnProxima.BackColor = Color.FromArgb(106, 27, 154);

            panelQuiz.Controls.Add(btnProxima);

            // Barra de Progresso - MAIS PARA BAIXO
            progressoQuiz = new ProgressBar();
            progressoQuiz.Location = new Point(40, 500);
            progressoQuiz.Size = new Size(860, 15);
            progressoQuiz.Style = ProgressBarStyle.Continuous;
            progressoQuiz.ForeColor = Color.FromArgb(106, 27, 154);
            panelQuiz.Controls.Add(progressoQuiz);

            // Painel de Resultado
            lblResultado = new Label();
            lblResultado.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblResultado.Location = new Point(40, 50);
            lblResultado.Size = new Size(860, 400);
            lblResultado.Text = "Resultado";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.AutoSize = false;
            panelResultado.Controls.Add(lblResultado);

            btnReiniciar = new Button();
            btnReiniciar.Text = "🔄 Reiniciar Quiz";
            btnReiniciar.BackColor = Color.FromArgb(106, 27, 154);
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(370, 470);
            btnReiniciar.Size = new Size(200, 45);
            btnReiniciar.Click += btnReiniciar_Click;

            btnReiniciar.MouseEnter += (s, e) => btnReiniciar.BackColor = Color.FromArgb(86, 7, 134);
            btnReiniciar.MouseLeave += (s, e) => btnReiniciar.BackColor = Color.FromArgb(106, 27, 154);

            panelResultado.Controls.Add(btnReiniciar);

            // Botão Voltar
            btnVoltar = new Button();
            btnVoltar.Text = "← Voltar ao Menu";
            btnVoltar.BackColor = Color.FromArgb(194, 24, 91);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(900, 750);
            btnVoltar.Size = new Size(160, 40);
            btnVoltar.Click += btnVoltar_Click;

            btnVoltar.MouseEnter += (s, e) => btnVoltar.BackColor = Color.FromArgb(174, 4, 71);
            btnVoltar.MouseLeave += (s, e) => btnVoltar.BackColor = Color.FromArgb(194, 24, 91);

            // Adicionar controles na ORDEM CORRETA
            this.Controls.Add(panelQuiz);
            this.Controls.Add(panelResultado);
            this.Controls.Add(btnVoltar);

            // GARANTIR que os botões estão na frente
            btnProxima.BringToFront();
            btnVoltar.BringToFront();
        }

        private Button CreateModernOptionButton(string text, int x, int y)
        {
            var button = new Button();
            button.Text = text;
            button.BackColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 220);
            button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button.ForeColor = Color.FromArgb(64, 64, 64);
            button.Location = new Point(x, y);
            button.Size = new Size(860, 50);
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(20, 0, 0, 0);

            // Efeitos hover
            button.MouseEnter += (s, e) =>
            {
                button.BackColor = Color.FromArgb(245, 245, 255);
                button.FlatAppearance.BorderColor = Color.FromArgb(106, 27, 154);
            };

            button.MouseLeave += (s, e) =>
            {
                if (!button.Tag?.Equals("correct") == true && !button.Tag?.Equals("wrong") == true)
                {
                    button.BackColor = Color.White;
                    button.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 220);
                }
            };

            // Atribuir eventos de clique
            if (text.Contains("A")) button.Click += (s, e) => VerificarResposta(0);
            else if (text.Contains("B")) button.Click += (s, e) => VerificarResposta(1);
            else if (text.Contains("C")) button.Click += (s, e) => VerificarResposta(2);
            else if (text.Contains("D")) button.Click += (s, e) => VerificarResposta(3);

            panelQuiz.Controls.Add(button);
            return button;
        }

        private void SetupHeader()
        {
            panelHeader = new Panel
            {
                Size = new Size(1100, 100),
                Location = new Point(0, 0)
            };

            panelHeader.Paint += (s, e) =>
            {
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    panelHeader.ClientRectangle,
                    Color.FromArgb(156, 39, 176),
                    Color.FromArgb(106, 27, 154),
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panelHeader.ClientRectangle);
                }
            };

            this.Controls.Add(panelHeader);

            var lblTitulo = new Label
            {
                Text = "🧠 Quiz Educativo - HPV",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 25),
                BackColor = Color.Transparent
            };
            panelHeader.Controls.Add(lblTitulo);

            var lblSubtitulo = new Label
            {
                Text = "Teste seus conhecimentos sobre prevenção e cuidados",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Lavender,
                AutoSize = true,
                Location = new Point(42, 60),
                BackColor = Color.Transparent
            };
            panelHeader.Controls.Add(lblSubtitulo);

            btnFullScreen = new Button
            {
                Text = "⛶",
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(40, 30),
                Location = new Point(panelHeader.Width - 50, 15),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnFullScreen.Click += BtnFullScreen_Click;

            btnFullScreen.MouseEnter += (s, e) => btnFullScreen.BackColor = Color.FromArgb(255, 255, 255, 30);
            btnFullScreen.MouseLeave += (s, e) => btnFullScreen.BackColor = Color.Transparent;

            panelHeader.Controls.Add(btnFullScreen);
        }

        private void SetupQuizContent()
        {
            // Conteúdo já configurado
        }

        private void SetupFooter()
        {
            panelFooter = new Panel
            {
                BackColor = Color.FromArgb(250, 250, 255),
                Size = new Size(1100, 40),
                Location = new Point(0, 760)
            };
            this.Controls.Add(panelFooter);

            var lblVersao = new Label
            {
                Text = "Quiz educativo • Teste seus conhecimentos sobre HPV • Desenvolvido para educação em saúde",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.FromArgb(120, 120, 120),
                AutoSize = true,
                Location = new Point(20, 12)
            };
            panelFooter.Controls.Add(lblVersao);
        }

        private void InicializarPerguntas()
        {
            perguntas = new Pergunta[]
            {
                new Pergunta("O que significa a sigla HPV?", new string[] {"Human Papillomavirus", "Human Pulmonary Virus", "Hematological Pathogen Virus", "Hormonal Protection Vaccine"}, 0, "HPV significa Human Papillomavirus (Papilomavírus Humano), um vírus que infecta pele e mucosas."),
                new Pergunta("Qual é a principal forma de transmissão do HPV?", new string[] {"Relações sexuais desprotegidas", "Compartilhamento de talheres", "Beijo na boca", "Ar contaminado"}, 0, "A principal forma de transmissão é através de relações sexuais desprotegidas (oral, vaginal ou anal)."),
                new Pergunta("O HPV pode causar quais tipos de câncer?", new string[] {"Câncer do colo do útero, ânus e orofaringe", "Câncer de pulmão e fígado", "Câncer de mama e próstata", "Câncer de pele e ossos"}, 0, "HPV está associado ao câncer do colo do útero, ânus, pênis, vulva, vagina e orofaringe."),
                new Pergunta("A vacina contra HPV é recomendada para:", new string[] {"Meninas e meninos na adolescência", "Apenas mulheres adultas", "Apenas homens acima de 40 anos", "Apenas pessoas já infectadas"}, 0, "A vacina é recomendada para meninas e meninos entre 9-14 anos, antes do início da vida sexual."),
                new Pergunta("Qual é o método mais eficaz para prevenir o HPV?", new string[] {"Vacinação + uso de preservativo", "Apenas uso de preservativo", "Antibióticos preventivos", "Lavar as mãos frequentemente"}, 0, "A combinação da vacinação com o uso consistente de preservativos oferece a melhor proteção."),
                new Pergunta("O exame Papanicolau detecta:", new string[] {"Alterações pré-cancerosas no colo do útero", "A presença do vírus HPV no sangue", "Anticorpos contra HPV", "Todos os tipos de HPV"}, 0, "O Papanicolau detecta alterações celulares no colo do útero que podem evoluir para câncer."),
                new Pergunta("Quantas doses da vacina contra HPV são recomendadas?", new string[] {"2 doses para adolescentes", "1 dose para todas as idades", "3 doses independente da idade", "4 doses anuais"}, 0, "Para adolescentes até 14 anos, são recomendadas 2 doses com intervalo de 6 meses."),
                new Pergunta("Os preservativos protegem 100% contra HPV?", new string[] {"Não, mas reduzem significativamente o risco", "Sim, protegem completamente", "Não oferecem nenhuma proteção", "Apenas protegem mulheres"}, 0, "Preservativos reduzem o risco, mas não protegem 100% pois o vírus pode estar em áreas não cobertas."),
                new Pergunta("Qual porcentagem da população sexualmente ativa entra em contato com HPV?", new string[] {"Cerca de 80% em algum momento da vida", "Menos de 10%", "Apenas 25%", "Praticamente 100%"}, 0, "Estima-se que 80% da população sexualmente ativa terá contato com HPV em algum momento."),
                new Pergunta("O HPV pode ser transmitido da mãe para o bebê?", new string[] {"Sim, durante o parto normal", "Não, é impossível", "Apenas durante a amamentação", "Apenas por herança genética"}, 0, "Pode ocorrer transmissão vertical durante o parto, podendo causar papilomatose respiratória no bebê."),
                new Pergunta("Qual é o período de incubação do HPV?", new string[] {"Variável, de semanas a anos", "Sempre 2 semanas exatas", "No máximo 1 mês", "Apenas 3 dias"}, 0, "O período de incubação é bastante variável, podendo ser de semanas até anos após o contato."),
                new Pergunta("As verrugas genitais são causadas por:", new string[] {"Tipos de HPV de baixo risco", "Bactérias específicas", "Fungos genitais", "Alergias a preservativos"}, 0, "As verrugas genitais são causadas principalmente pelos tipos 6 e 11 do HPV (baixo risco)."),
                new Pergunta("O que significa resultado positivo no teste de HPV?", new string[] {"Detecção do vírus, mas não necessariamente doença", "Diagnóstico de câncer confirmado", "Infertilidade irreversível", "Imunidade permanente adquirida"}, 0, "Resultado positivo significa detecção do vírus, mas a maioria das infecções é transitória e cura espontaneamente."),
                new Pergunta("Homens podem ser vacinados contra HPV?", new string[] {"Sim, e é recomendado", "Não, a vacina é só para mulheres", "Apenas homens acima de 50 anos", "Apenas se já tiverem verrugas"}, 0, "Homens também devem ser vacinados, pois previne verrugas genitais e cânceres de ânus, pênis e orofaringe."),
                new Pergunta("Qual a faixa etária ideal para vacinação contra HPV?", new string[] {"9 a 14 anos", "25 a 30 anos", "40 a 50 anos", "Acima de 60 anos"}, 0, "A faixa etária ideal é 9-14 anos, quando a resposta imunológica é melhor e antes da exposição ao vírus."),
                new Pergunta("O HPV tem cura?", new string[] {"Não há cura para o vírus, mas o corpo pode eliminá-lo", "Sim, com antibióticos específicos", "Sim, com uma única dose de vacina", "Não, é sempre permanente"}, 0, "Não existe medicamento que cure o HPV, mas o sistema imunológico pode eliminar o vírus espontaneamente em 80-90% dos casos."),
                new Pergunta("Quais fatores aumentam o risco de persistência do HPV?", new string[] {"Tabagismo e imunossupressão", "Consumo de café e chocolate", "Exercícios físicos intensos", "Dieta vegetariana"}, 0, "Tabagismo, imunossupressão, múltiplos parceiros sexuais e outras ISTs aumentam o risco de persistência."),
                new Pergunta("O exame de HPV substitui o Papanicolau?", new string[] {"Não, são exames complementares", "Sim, completamente", "Apenas para mulheres virgens", "Apenas para homens"}, 0, "São exames complementares: o Papanicolau detecta alterações celulares, o teste de HPV detecta o vírus."),
                new Pergunta("Qual órgão oficial recomenda a vacinação contra HPV no Brasil?", new string[] {"Ministério da Saúde", "Conselho Federal de Educação", "Ministério do Esporte", "Agência Nacional de Aviação"}, 0, "O Ministério da Saúde recomenda e oferece gratuitamente a vacina para meninas de 9-14 anos e meninos de 11-14 anos."),
                new Pergunta("Qual a chance de cura das lesões pré-cancerosas?", new string[] {"Quase 100% quando detectadas precocemente", "Cerca de 50%", "Cerca de 25%", "Não tem cura"}, 0, "Lesões pré-cancerosas detectadas precocemente têm quase 100% de cura com tratamento adequado!")
            };
        }

        private void EmbaralharRespostas()
        {
            ordemRespostas = new List<int> { 0, 1, 2, 3 };
            var rnd = new Random();
            ordemRespostas = ordemRespostas.OrderBy(x => rnd.Next()).ToList();
        }

        private void MostrarPergunta()
        {
            if (perguntaAtual < perguntas.Length)
            {
                var pergunta = perguntas[perguntaAtual];
                EmbaralharRespostas();

                lblPergunta.Text = $"❓ Pergunta {perguntaAtual + 1}/{perguntas.Length}:\n{pergunta.Texto}";

                btnOpcao1.Text = $"A) {pergunta.Opcoes[ordemRespostas[0]]}";
                btnOpcao2.Text = $"B) {pergunta.Opcoes[ordemRespostas[1]]}";
                btnOpcao3.Text = $"C) {pergunta.Opcoes[ordemRespostas[2]]}";
                btnOpcao4.Text = $"D) {pergunta.Opcoes[ordemRespostas[3]]}";

                ResetButtonColors();

                lblExplicacao.Text = "Selecione uma resposta para ver a explicação...";
                lblExplicacao.ForeColor = Color.FromArgb(120, 120, 120);
                progressoQuiz.Value = (perguntaAtual * 100) / perguntas.Length;

                btnOpcao1.Enabled = btnOpcao2.Enabled = btnOpcao3.Enabled = btnOpcao4.Enabled = true;

                // GARANTIR que o botão está visível
                btnProxima.Visible = true;
                btnProxima.BringToFront();
            }
        }

        private void ResetButtonColors()
        {
            var buttons = new[] { btnOpcao1, btnOpcao2, btnOpcao3, btnOpcao4 };
            foreach (var button in buttons)
            {
                button.BackColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 220);
                button.ForeColor = Color.FromArgb(64, 64, 64);
                button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                button.Tag = null;
            }
        }

        private void VerificarResposta(int opcaoSelecionada)
        {
            var pergunta = perguntas[perguntaAtual];
            int respostaCorretaIndex = ordemRespostas.IndexOf(pergunta.RespostaCorreta);
            var buttons = new[] { btnOpcao1, btnOpcao2, btnOpcao3, btnOpcao4 };

            // Destacar a resposta correta em verde
            buttons[respostaCorretaIndex].BackColor = Color.FromArgb(232, 245, 233);
            buttons[respostaCorretaIndex].FlatAppearance.BorderColor = Color.FromArgb(76, 175, 80);
            buttons[respostaCorretaIndex].ForeColor = Color.FromArgb(56, 142, 60);
            buttons[respostaCorretaIndex].Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttons[respostaCorretaIndex].Tag = "correct";

            if (opcaoSelecionada == respostaCorretaIndex)
            {
                pontuacao++;
                lblExplicacao.Text = $"✅ CORRETO!\n\n{pergunta.Explicacao}";
                lblExplicacao.ForeColor = Color.FromArgb(56, 142, 60);
            }
            else
            {
                buttons[opcaoSelecionada].BackColor = Color.FromArgb(255, 235, 238);
                buttons[opcaoSelecionada].FlatAppearance.BorderColor = Color.FromArgb(244, 67, 54);
                buttons[opcaoSelecionada].ForeColor = Color.FromArgb(198, 40, 40);
                buttons[opcaoSelecionada].Font = new Font("Segoe UI", 10, FontStyle.Bold);
                buttons[opcaoSelecionada].Tag = "wrong";

                string respostaCorretaTexto = buttons[respostaCorretaIndex].Text.Substring(3);
                lblExplicacao.Text = $"❌ INCORRETO!\n\nResposta correta: {respostaCorretaTexto}\n\n{pergunta.Explicacao}";
                lblExplicacao.ForeColor = Color.FromArgb(198, 40, 40);
            }

            lblExplicacao.AutoSize = false;
            lblExplicacao.Height = 80;
            lblExplicacao.TextAlign = ContentAlignment.TopCenter;

            perguntaAtual++;
            btnProxima.Enabled = true;
            btnProxima.BringToFront();

            if (perguntaAtual < perguntas.Length)
            {
                btnProxima.Text = "Próxima Pergunta →";
            }
            else
            {
                btnProxima.Text = "Ver Resultado Final 🎯";
            }

            btnOpcao1.Enabled = btnOpcao2.Enabled = btnOpcao3.Enabled = btnOpcao4.Enabled = false;
        }

        private void MostrarResultado()
        {
            double percentual = (pontuacao * 100.0) / perguntas.Length;
            string mensagem = "";
            Color cor = Color.Black;

            if (percentual >= 90) mensagem = "🎉 EXCELENTE! Você é um expert em HPV!";
            else if (percentual >= 70) mensagem = "👍 MUITO BOM! Você conhece bem o assunto!";
            else if (percentual >= 50) mensagem = "💡 BOM! Mas pode aprender mais!";
            else mensagem = "📚 ESTUDE MAIS! Revise as informações sobre HPV!";

            panelQuiz.Visible = false;
            panelResultado.Visible = true;

            lblResultado.Text = $"🎊 RESULTADO FINAL 🎊\n\n📊 {pontuacao}/{perguntas.Length} acertos\n📈 {percentual:F1}% de aproveitamento\n\n{mensagem}\n\n💡 Continue aprendendo sobre prevenção!";
            lblResultado.ForeColor = cor;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            btnProxima.Enabled = false;
            if (perguntaAtual < perguntas.Length)
            {
                btnOpcao1.Enabled = btnOpcao2.Enabled = btnOpcao3.Enabled = btnOpcao4.Enabled = true;
                MostrarPergunta();
            }
            else
            {
                MostrarResultado();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            perguntaAtual = 0;
            pontuacao = 0;
            panelQuiz.Visible = true;
            panelResultado.Visible = false;
            MostrarPergunta();
            btnProxima.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity > 0) this.Opacity -= 0.05;
                else { fadeTimer.Stop(); VoltarParaMenu(); }
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
                panelHeader.Width = this.ClientSize.Width;
                panelFooter.Width = this.ClientSize.Width;
                panelFooter.Location = new Point(0, this.ClientSize.Height - panelFooter.Height);

                int panelWidth = Math.Min(1000, this.ClientSize.Width - 100);
                int panelHeight = Math.Min(600, this.ClientSize.Height - 200);

                panelQuiz.Size = new Size(panelWidth, panelHeight);
                panelResultado.Size = new Size(panelWidth, panelHeight);

                panelQuiz.Location = new Point((this.ClientSize.Width - panelWidth) / 2, 120);
                panelResultado.Location = new Point((this.ClientSize.Width - panelWidth) / 2, 120);

                // POSIÇÃO FIXA para o botão próxima - SEMPRE VISÍVEL
                btnProxima.Location = new Point(
                    (panelQuiz.Width - btnProxima.Width) / 2,
                    panelQuiz.Height - 100
                );
                btnProxima.BringToFront();

                progressoQuiz.Location = new Point(40, panelQuiz.Height - 50);
                progressoQuiz.Width = panelQuiz.Width - 80;

                lblExplicacao.Location = new Point(40, 345);
                lblExplicacao.Width = panelQuiz.Width - 80;

                btnOpcao1.Width = btnOpcao2.Width = btnOpcao3.Width = btnOpcao4.Width = panelQuiz.Width - 80;
                lblPergunta.Width = panelQuiz.Width - 60;

                btnVoltar.Location = new Point(this.ClientSize.Width - 180, this.ClientSize.Height - 70);
                btnFullScreen.Location = new Point(panelHeader.Width - 50, 15);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no UpdateLayout: " + ex.Message);
            }
        }

        private void ApplyAnimations()
        {
            this.Opacity = 0;
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1) this.Opacity += 0.05;
                else fadeTimer.Stop();
            };
            fadeTimer.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F11) { ToggleFullScreen(); return true; }
            if (keyData == Keys.Escape && isFullScreen) { ToggleFullScreen(); return true; }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormQuiz_Load(object sender, EventArgs e) => UpdateLayout();
        private void FormQuiz_SizeChanged(object sender, EventArgs e) => UpdateLayout();
    }

    public class Pergunta
    {
        public string Texto { get; set; }
        public string[] Opcoes { get; set; }
        public int RespostaCorreta { get; set; }
        public string Explicacao { get; set; }

        public Pergunta(string texto, string[] opcoes, int respostaCorreta, string explicacao)
        {
            Texto = texto;
            Opcoes = opcoes;
            RespostaCorreta = respostaCorreta;
            Explicacao = explicacao;
        }
    }
}