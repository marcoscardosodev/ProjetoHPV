using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormQuiz : Form
    {
        private int perguntaAtual = 0;
        private int pontuacao = 0;
        private Pergunta[] perguntas;

        // Controles do quiz (agora declarados como campos da classe)
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
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(1000, 700);
            this.Size = new Size(1000, 700);

            // Criar todos os controles programaticamente
            CreateQuizControls();
            SetupHeader();
            SetupQuizContent();
            SetupFooter();
        }

        private void CreateQuizControls()
        {
            // Painel do Quiz
            panelQuiz = new Panel();
            panelQuiz.Location = new Point(50, 110);
            panelQuiz.Size = new Size(900, 450);
            panelQuiz.BackColor = Color.FromArgb(248, 248, 255);
            panelQuiz.Visible = true;

            // Painel de Resultado
            panelResultado = new Panel();
            panelResultado.Location = new Point(50, 110);
            panelResultado.Size = new Size(900, 450);
            panelResultado.BackColor = Color.FromArgb(248, 248, 255);
            panelResultado.Visible = false;

            // Label da Pergunta
            lblPergunta = new Label();
            lblPergunta.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPergunta.Location = new Point(50, 30);
            lblPergunta.Size = new Size(800, 80);
            lblPergunta.Text = "Pergunta 1/20: Carregando...";
            panelQuiz.Controls.Add(lblPergunta);

            // Botões das Opções
            btnOpcao1 = CreateOptionButton("Opção A", 50, 150);
            btnOpcao2 = CreateOptionButton("Opção B", 50, 205);
            btnOpcao3 = CreateOptionButton("Opção C", 470, 150);
            btnOpcao4 = CreateOptionButton("Opção D", 470, 205);

            // Label de Explicação
            lblExplicacao = new Label();
            lblExplicacao.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblExplicacao.Location = new Point(50, 270);
            lblExplicacao.Size = new Size(800, 60);
            lblExplicacao.Text = "Selecione uma resposta para ver a explicação...";
            lblExplicacao.ForeColor = Color.FromArgb(100, 100, 100);
            panelQuiz.Controls.Add(lblExplicacao);

            // Botão Próxima
            btnProxima = new Button();
            btnProxima.Text = "Próxima Pergunta →";
            btnProxima.BackColor = Color.FromArgb(138, 43, 226);
            btnProxima.FlatStyle = FlatStyle.Flat;
            btnProxima.FlatAppearance.BorderSize = 0;
            btnProxima.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnProxima.ForeColor = Color.White;
            btnProxima.Location = new Point(350, 350);
            btnProxima.Size = new Size(200, 40);
            btnProxima.Enabled = false;
            btnProxima.Click += btnProxima_Click;
            panelQuiz.Controls.Add(btnProxima);

            // Barra de Progresso
            progressoQuiz = new ProgressBar();
            progressoQuiz.Location = new Point(50, 410);
            progressoQuiz.Size = new Size(800, 20);
            panelQuiz.Controls.Add(progressoQuiz);

            // Painel de Resultado - Conteúdo
            lblResultado = new Label();
            lblResultado.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblResultado.Location = new Point(50, 50);
            lblResultado.Size = new Size(800, 250);
            lblResultado.Text = "Resultado";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            panelResultado.Controls.Add(lblResultado);

            btnReiniciar = new Button();
            btnReiniciar.Text = "🔄 Reiniciar Quiz";
            btnReiniciar.BackColor = Color.FromArgb(138, 43, 226);
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(350, 350);
            btnReiniciar.Size = new Size(200, 40);
            btnReiniciar.Click += btnReiniciar_Click;
            panelResultado.Controls.Add(btnReiniciar);

            // Botão Voltar
            btnVoltar = new Button();
            btnVoltar.Text = "← Voltar ao Menu";
            btnVoltar.BackColor = Color.FromArgb(233, 30, 99);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(825, 615);
            btnVoltar.Size = new Size(140, 35);
            btnVoltar.Click += btnVoltar_Click;

            // Adicionar painéis ao form
            this.Controls.Add(panelQuiz);
            this.Controls.Add(panelResultado);
            this.Controls.Add(btnVoltar);
        }

        private Button CreateOptionButton(string text, int x, int y)
        {
            var button = new Button();
            button.Text = text;
            button.BackColor = Color.FromArgb(186, 85, 211);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(x, y);
            button.Size = new Size(400, 45);

            // Efeitos hover
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(166, 65, 191);
            button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(186, 85, 211);

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
            // Painel do cabeçalho
            panelHeader = new Panel
            {
                BackColor = Color.FromArgb(233, 30, 99),
                Size = new Size(1000, 100),
                Location = new Point(0, 0),
                Dock = DockStyle.Top
            };
            this.Controls.Add(panelHeader);

            // Título principal
            var lblTitulo = new Label
            {
                Text = "🧠 Quiz Educativo - HPV",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(30, 25)
            };
            panelHeader.Controls.Add(lblTitulo);

            // Subtítulo
            var lblSubtitulo = new Label
            {
                Text = "Teste seus conhecimentos sobre prevenção e cuidados",
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

        private void SetupQuizContent()
        {
            // Já configurado no CreateQuizControls()
        }

        private void SetupFooter()
        {
            // Painel do rodapé
            panelFooter = new Panel
            {
                BackColor = Color.FromArgb(250, 250, 250),
                Size = new Size(1000, 35),
                Location = new Point(0, 665),
                Dock = DockStyle.Bottom
            };
            this.Controls.Add(panelFooter);

            // Versão
            var lblVersao = new Label
            {
                Text = "Quiz educativo • Teste seus conhecimentos sobre HPV",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 10)
            };
            panelFooter.Controls.Add(lblVersao);

            // Efeitos hover
            btnVoltar.MouseEnter += (s, e) => btnVoltar.BackColor = Color.FromArgb(213, 10, 79);
            btnVoltar.MouseLeave += (s, e) => btnVoltar.BackColor = Color.FromArgb(233, 30, 99);
            btnFullScreen.MouseEnter += (s, e) => btnFullScreen.BackColor = Color.FromArgb(100, 100, 100, 100);
            btnFullScreen.MouseLeave += (s, e) => btnFullScreen.BackColor = Color.Transparent;
        }

        private void InicializarPerguntas()
        {
            perguntas = new Pergunta[]
            {
                new Pergunta(
                    "O que significa a sigla HPV?",
                    new string[] {
                        "Human Papillomavirus",
                        "Human Pulmonary Virus",
                        "Hematological Pathogen Virus",
                        "Hormonal Protection Vaccine"
                    },
                    0,
                    "HPV significa Human Papillomavirus (Papilomavírus Humano), um vírus que infecta pele e mucosas."
                ),
                new Pergunta(
                    "Qual é a principal forma de transmissão do HPV?",
                    new string[] {
                        "Relações sexuais desprotegidas",
                        "Compartilhamento de talheres",
                        "Beijo na boca",
                        "Ar contaminado"
                    },
                    0,
                    "A principal forma de transmissão é através de relações sexuais desprotegidas (oral, vaginal ou anal)."
                ),
                new Pergunta(
                    "O HPV pode causar quais tipos de câncer?",
                    new string[] {
                        "Câncer do colo do útero, ânus e orofaringe",
                        "Câncer de pulmão e fígado",
                        "Câncer de mama e próstata",
                        "Câncer de pele e ossos"
                    },
                    0,
                    "HPV está associado ao câncer do colo do útero, ânus, pênis, vulva, vagina e orofaringe."
                ),
                new Pergunta(
                    "A vacina contra HPV é recomendada para:",
                    new string[] {
                        "Meninas e meninos na adolescência",
                        "Apenas mulheres adultas",
                        "Apenas homens acima de 40 anos",
                        "Apenas pessoas já infectadas"
                    },
                    0,
                    "A vacina é recomendada para meninas e meninos entre 9-14 anos, antes do início da vida sexual."
                ),
                new Pergunta(
                    "Qual é o método mais eficaz para prevenir o HPV?",
                    new string[] {
                        "Vacinação + uso de preservativo",
                        "Apenas uso de preservativo",
                        "Antibióticos preventivos",
                        "Lavar as mãos frequentemente"
                    },
                    0,
                    "A combinação da vacinação com o uso consistente de preservativos oferece a melhor proteção."
                ),
                new Pergunta(
                    "O exame Papanicolau detecta:",
                    new string[] {
                        "Alterações pré-cancerosas no colo do útero",
                        "A presença do vírus HPV no sangue",
                        "Anticorpos contra HPV",
                        "Todos os tipos de HPV"
                    },
                    0,
                    "O Papanicolau detecta alterações celulares no colo do útero que podem evoluir para câncer."
                ),
                new Pergunta(
                    "Quantas doses da vacina contra HPV são recomendadas?",
                    new string[] {
                        "2 doses para adolescentes",
                        "1 dose para todas as idades",
                        "3 doses independente da idade",
                        "4 doses anuais"
                    },
                    0,
                    "Para adolescentes até 14 anos, são recomendadas 2 doses com intervalo de 6 meses."
                ),
                new Pergunta(
                    "Os preservativos protegem 100% contra HPV?",
                    new string[] {
                        "Não, mas reduzem significativamente o risco",
                        "Sim, protegem completamente",
                        "Não oferecem nenhuma proteção",
                        "Apenas protegem mulheres"
                    },
                    0,
                    "Preservativos reduzem o risco, mas não protegem 100% pois o vírus pode estar em áreas não cobertas."
                ),
                new Pergunta(
                    "Qual porcentagem da população sexualmente ativa entra em contato com HPV?",
                    new string[] {
                        "Cerca de 80% em algum momento da vida",
                        "Menos de 10%",
                        "Apenas 25%",
                        "Praticamente 100%"
                    },
                    0,
                    "Estima-se que 80% da população sexualmente ativa terá contato com HPV em algum momento."
                ),
                new Pergunta(
                    "O HPV pode ser transmitido da mãe para o bebê?",
                    new string[] {
                        "Sim, durante o parto normal",
                        "Não, é impossível",
                        "Apenas durante a amamentação",
                        "Apenas por herança genética"
                    },
                    0,
                    "Pode ocorrer transmissão vertical durante o parto, podendo causar papilomatose respiratória no bebê."
                ),
                new Pergunta(
                    "Qual é o período de incubação do HPV?",
                    new string[] {
                        "Variável, de semanas a anos",
                        "Sempre 2 semanas exatas",
                        "No máximo 1 mês",
                        "Apenas 3 dias"
                    },
                    0,
                    "O período de incubação é bastante variável, podendo ser de semanas até anos após o contato."
                ),
                new Pergunta(
                    "As verrugas genitais são causadas por:",
                    new string[] {
                        "Tipos de HPV de baixo risco",
                        "Bactérias específicas",
                        "Fungos genitais",
                        "Alergias a preservativos"
                    },
                    0,
                    "As verrugas genitais são causadas principalmente pelos tipos 6 e 11 do HPV (baixo risco)."
                ),
                new Pergunta(
                    "O que significa resultado positivo no teste de HPV?",
                    new string[] {
                        "Detecção do vírus, mas não necessariamente doença",
                        "Diagnóstico de câncer confirmado",
                        "Infertilidade irreversível",
                        "Imunidade permanente adquirida"
                    },
                    0,
                    "Resultado positivo significa detecção do vírus, mas a maioria das infecções é transitória e cura espontaneamente."
                ),
                new Pergunta(
                    "Homens podem ser vacinados contra HPV?",
                    new string[] {
                        "Sim, e é recomendado",
                        "Não, a vacina é só para mulheres",
                        "Apenas homens acima de 50 anos",
                        "Apenas se já tiverem verrugas"
                    },
                    0,
                    "Homens também devem ser vacinados, pois previne verrugas genitais e cânceres de ânus, pênis e orofaringe."
                ),
                new Pergunta(
                    "Qual a faixa etária ideal para vacinação contra HPV?",
                    new string[] {
                        "9 a 14 anos",
                        "25 a 30 anos",
                        "40 a 50 anos",
                        "Acima de 60 anos"
                    },
                    0,
                    "A faixa etária ideal é 9-14 anos, quando a resposta imunológica é melhor e antes da exposição ao vírus."
                ),
                new Pergunta(
                    "O HPV tem cura?",
                    new string[] {
                        "Não há cura para o vírus, mas o corpo pode eliminá-lo",
                        "Sim, com antibióticos específicos",
                        "Sim, com uma única dose de vacina",
                        "Não, é sempre permanente"
                    },
                    0,
                    "Não existe medicamento que cure o HPV, mas o sistema imunológico pode eliminar o vírus espontaneamente em 80-90% dos casos."
                ),
                new Pergunta(
                    "Quais fatores aumentam o risco de persistência do HPV?",
                    new string[] {
                        "Tabagismo e imunossupressão",
                        "Consumo de café e chocolate",
                        "Exercícios físicos intensos",
                        "Dieta vegetariana"
                    },
                    0,
                    "Tabagismo, imunossupressão, múltiplos parceiros sexuais e outras ISTs aumentam o risco de persistência."
                ),
                new Pergunta(
                    "O exame de HPV substitui o Papanicolau?",
                    new string[] {
                        "Não, são exames complementares",
                        "Sim, completamente",
                        "Apenas para mulheres virgens",
                        "Apenas para homens"
                    },
                    0,
                    "São exames complementares: o Papanicolau detecta alterações celulares, o teste de HPV detecta o vírus."
                ),
                new Pergunta(
                    "Qual órgão oficial recomenda a vacinação contra HPV no Brasil?",
                    new string[] {
                        "Ministério da Saúde",
                        "Conselho Federal de Educação",
                        "Ministério do Esporte",
                        "Agência Nacional de Aviação"
                    },
                    0,
                    "O Ministério da Saúde recomenda e oferece gratuitamente a vacina para meninas de 9-14 anos e meninos de 11-14 anos."
                ),
                new Pergunta(
                    "Qual a chance de cura das lesões pré-cancerosas?",
                    new string[] {
                        "Quase 100% quando detectadas precocemente",
                        "Cerca de 50%",
                        "Cerca de 25%",
                        "Não tem cura"
                    },
                    0,
                    "Lesões pré-cancerosas detectadas precocemente têm quase 100% de cura com tratamento adequado!"
                )
            };
        }

        private void MostrarPergunta()
        {
            if (perguntaAtual < perguntas.Length)
            {
                var pergunta = perguntas[perguntaAtual];

                lblPergunta.Text = $"❓ Pergunta {perguntaAtual + 1}/{perguntas.Length}:\n{pergunta.Texto}";
                btnOpcao1.Text = $"A) {pergunta.Opcoes[0]}";
                btnOpcao2.Text = $"B) {pergunta.Opcoes[1]}";
                btnOpcao3.Text = $"C) {pergunta.Opcoes[2]}";
                btnOpcao4.Text = $"D) {pergunta.Opcoes[3]}";

                lblExplicacao.Text = "Selecione uma resposta para ver a explicação...";
                lblExplicacao.ForeColor = Color.FromArgb(100, 100, 100);
                progressoQuiz.Value = (perguntaAtual * 100) / perguntas.Length;

                ResetButtonColors();
                btnOpcao1.Enabled = btnOpcao2.Enabled = btnOpcao3.Enabled = btnOpcao4.Enabled = true;
            }
        }

        private void ResetButtonColors()
        {
            btnOpcao1.BackColor = Color.FromArgb(186, 85, 211);
            btnOpcao2.BackColor = Color.FromArgb(186, 85, 211);
            btnOpcao3.BackColor = Color.FromArgb(186, 85, 211);
            btnOpcao4.BackColor = Color.FromArgb(186, 85, 211);
        }

        private void VerificarResposta(int opcaoSelecionada)
        {
            var pergunta = perguntas[perguntaAtual];

            // Destacar a resposta correta em verde
            btnOpcao1.BackColor = (0 == pergunta.RespostaCorreta) ? Color.FromArgb(76, 175, 80) : Color.FromArgb(186, 85, 211);
            btnOpcao2.BackColor = (1 == pergunta.RespostaCorreta) ? Color.FromArgb(76, 175, 80) : Color.FromArgb(186, 85, 211);
            btnOpcao3.BackColor = (2 == pergunta.RespostaCorreta) ? Color.FromArgb(76, 175, 80) : Color.FromArgb(186, 85, 211);
            btnOpcao4.BackColor = (3 == pergunta.RespostaCorreta) ? Color.FromArgb(76, 175, 80) : Color.FromArgb(186, 85, 211);

            if (opcaoSelecionada == pergunta.RespostaCorreta)
            {
                pontuacao++;
                lblExplicacao.Text = $"✅ CORRETO!\n\n{pergunta.Explicacao}";
                lblExplicacao.ForeColor = Color.FromArgb(46, 125, 50);
            }
            else
            {
                // Destacar a resposta errada em vermelho
                switch (opcaoSelecionada)
                {
                    case 0: btnOpcao1.BackColor = Color.FromArgb(244, 67, 54); break;
                    case 1: btnOpcao2.BackColor = Color.FromArgb(244, 67, 54); break;
                    case 2: btnOpcao3.BackColor = Color.FromArgb(244, 67, 54); break;
                    case 3: btnOpcao4.BackColor = Color.FromArgb(244, 67, 54); break;
                }

                lblExplicacao.Text = $"❌ INCORRETO!\n\nResposta correta: {pergunta.Opcoes[pergunta.RespostaCorreta]}\n\n{pergunta.Explicacao}";
                lblExplicacao.ForeColor = Color.FromArgb(198, 40, 40);
            }

            perguntaAtual++;
            btnProxima.Enabled = true;

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
            double percentual = (pontuacao * 100) / perguntas.Length;
            string mensagem = "";
            Color cor = Color.Black;

            if (percentual >= 90)
            {
                mensagem = "🎉 EXCELENTE! Você é um expert em HPV!";
                cor = Color.FromArgb(46, 125, 50);
            }
            else if (percentual >= 70)
            {
                mensagem = "👍 MUITO BOM! Você conhece bem o assunto!";
                cor = Color.FromArgb(30, 136, 229);
            }
            else if (percentual >= 50)
            {
                mensagem = "💡 BOM! Mas pode aprender mais!";
                cor = Color.FromArgb(255, 152, 0);
            }
            else
            {
                mensagem = "📚 ESTUDE MAIS! Revise as informações sobre HPV!";
                cor = Color.FromArgb(198, 40, 40);
            }

            panelQuiz.Visible = false;
            panelResultado.Visible = true;

            lblResultado.Text = $"🎊 RESULTADO FINAL 🎊\n\n" +
                              $"📊 {pontuacao}/{perguntas.Length} acertos\n" +
                              $"📈 {percentual}% de aproveitamento\n\n" +
                              $"{mensagem}\n\n" +
                              $"💡 Continue aprendendo sobre prevenção!";
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

                // Centraliza os painéis do quiz
                int panelWidth = Math.Min(900, this.ClientSize.Width - 100);
                int panelHeight = this.ClientSize.Height - 165;

                panelQuiz.Location = new Point(
                    (this.ClientSize.Width - panelWidth) / 2,
                    110
                );
                panelQuiz.Size = new Size(panelWidth, panelHeight);

                panelResultado.Location = new Point(
                    (this.ClientSize.Width - panelWidth) / 2,
                    110
                );
                panelResultado.Size = new Size(panelWidth, panelHeight);

                // Ajusta botão de tela cheia
                btnFullScreen.Location = new Point(panelHeader.Width - 45, 15);

                // Ajusta botão voltar
                btnVoltar.Location = new Point(
                    this.ClientSize.Width - 160,
                    this.ClientSize.Height - 50
                );
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
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();
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

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            // Configuração adicional
        }

        private void FormQuiz_SizeChanged(object sender, EventArgs e)
        {
            UpdateLayout();
        }
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