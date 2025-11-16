using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    public partial class FormMenuPrincipal : Form
    {
        private bool isFullScreen = false;
        private Size originalSize;
        private Point originalLocation;
        private FormWindowState originalWindowState;
        private Button btnFullScreen;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            ApplyButtonAnimations();
            SetupResponsiveDesign();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Configurações adicionais quando o form carrega
            this.Opacity = 0;
            FadeIn();

            // Salva estado original para restaurar depois
            originalSize = this.Size;
            originalLocation = this.Location;
            originalWindowState = this.WindowState;
        }

        private void SetupResponsiveDesign()
        {
            // Configura o form para ser redimensionável
            this.MinimumSize = new Size(1000, 700);
            this.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
            this.SizeChanged += FormMenuPrincipal_SizeChanged;

            // Adiciona botão de tela cheia
            AddFullScreenButton();
        }

        private void AddFullScreenButton()
        {
            btnFullScreen = new Button();
            btnFullScreen.Text = "⛶"; // Ícone de tela cheia
            btnFullScreen.BackColor = Color.Transparent;
            btnFullScreen.ForeColor = Color.White;
            btnFullScreen.FlatStyle = FlatStyle.Flat;
            btnFullScreen.FlatAppearance.BorderSize = 0;
            btnFullScreen.Size = new Size(40, 30);
            btnFullScreen.Location = new Point(panelHeader.Width - 50, 10);
            btnFullScreen.Click += BtnFullScreen_Click;
            panelHeader.Controls.Add(btnFullScreen);
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

                // Atualiza ícone
                btnFullScreen.Text = "⛷"; // Ícone de sair da tela cheia
            }
            else
            {
                // Sai da tela cheia
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = originalWindowState;
                this.Size = originalSize;
                this.Location = originalLocation;
                isFullScreen = false;

                // Atualiza ícone
                btnFullScreen.Text = "⛶"; // Ícone de tela cheia
            }

            UpdateLayout(); // Atualiza o layout após mudança de tamanho
        }

        private void FormMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
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

                // Centraliza o panel de botões
                panelBotoes.Location = new Point(
                    (this.ClientSize.Width - panelBotoes.Width) / 2,
                    panelHeader.Height + 20
                );

                // Ajusta botão de tela cheia
                if (btnFullScreen != null)
                {
                    btnFullScreen.Location = new Point(panelHeader.Width - 50, 10);
                }

                // Ajusta posição do subtítulo no header
                lblSubtitulo.Location = new Point(
                    lblTituloMenu.Left,
                    lblTituloMenu.Bottom + 5
                );

                // Ajusta versão no footer
                lblVersao.Location = new Point(20, (panelFooter.Height - lblVersao.Height) / 2);
            }
            catch (Exception ex)
            {
                // Ignora erros durante o redimensionamento
                Console.WriteLine("Erro no UpdateLayout: " + ex.Message);
            }
        }

        private void FadeIn()
        {
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

        private void ApplyButtonAnimations()
        {
            // Aplica efeitos hover a todos os botões
            Button[] buttons = { btnOQueEHPV, btnSintomas, btnPrevencao,
                               btnDiagnostico, btnEstatisticas, btnQuiz, btnVoltar };

            foreach (var button in buttons)
            {
                button.MouseEnter += (s, e) =>
                {
                    button.BackColor = ControlPaint.Light(button.BackColor, 0.2f);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                };

                button.MouseLeave += (s, e) =>
                {
                    button.BackColor = GetOriginalButtonColor(button);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                };

                button.MouseDown += (s, e) =>
                {
                    button.BackColor = ControlPaint.Dark(button.BackColor, 0.3f);
                };

                button.MouseUp += (s, e) =>
                {
                    button.BackColor = ControlPaint.Light(button.BackColor, 0.2f);
                };
            }
        }

        private Color GetOriginalButtonColor(Button button)
        {
            return button.Text switch
            {
                string t when t.Contains("O que é HPV") => Color.FromArgb(103, 58, 183),
                string t when t.Contains("Sintomas") => Color.FromArgb(156, 39, 176),
                string t when t.Contains("Prevenção") => Color.FromArgb(0, 150, 136),
                string t when t.Contains("Diagnóstico") => Color.FromArgb(255, 87, 34),
                string t when t.Contains("Estatísticas") => Color.FromArgb(63, 81, 181),
                string t when t.Contains("Quiz") => Color.FromArgb(233, 30, 99),
                string t when t.Contains("Voltar") => Color.FromArgb(158, 158, 158),
                _ => Color.Gray
            };
        }

        // Atalho de teclado para F11 (tela cheia)
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

        private void btnOQueEHPV_Click(object sender, EventArgs e)
        {
            AnimateButtonClick(btnOQueEHPV, () =>
            {
                FormOQueEHPV form = new FormOQueEHPV();
                form.Show();
                this.Hide();
            });
        }

        private void btnSintomas_Click(object sender, EventArgs e)
        {
            FormSintomas formSintomas = new FormSintomas(this); // Passa 'this' como formulário anterior
            formSintomas.Show();
            this.Hide(); // Esconde o menu principal
        }
        private void btnPrevencao_Click(object sender, EventArgs e)
        {
            AnimateButtonClick(btnPrevencao, () =>
            {
                FormPrevencao form = new FormPrevencao();
                form.Show();
                this.Hide();
            });
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            AnimateButtonClick(btnDiagnostico, () =>
            {
                FormDiagnostico form = new FormDiagnostico();
                form.Show();
                this.Hide();
            });
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            AnimateButtonClick(btnEstatisticas, () =>
            {
                FormEstatisticas form = new FormEstatisticas();
                form.Show();
                this.Hide();
            });
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            AnimateButtonClick(btnQuiz, () =>
            {
                FormQuiz form = new FormQuiz();
                form.Show();
                this.Hide();
            });
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AnimateButtonClick(btnVoltar, () =>
            {
                FormMain main = new FormMain();
                main.Show();
                this.Hide();
            });
        }

        private void AnimateButtonClick(Button button, Action action)
        {
            button.Enabled = false;

            // Efeito de clique
            Color originalColor = button.BackColor;
            button.BackColor = ControlPaint.Dark(originalColor);

            System.Windows.Forms.Timer clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Interval = 150;
            clickTimer.Tick += (s, e) =>
            {
                clickTimer.Stop();
                button.BackColor = originalColor;
                action.Invoke();
                button.Enabled = true;
            };
            clickTimer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                btnVoltar_Click(null, EventArgs.Empty);
            }
            base.OnFormClosing(e);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}