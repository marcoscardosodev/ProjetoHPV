namespace ProjetoHPV
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnIniciar = new Button();
            btnSobre = new Button();
            btnSair = new Button();
            pictureBoxLogo = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();

            SuspendLayout();

            // tableLayoutPanel
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.BackColor = Color.White;

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // imagem
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // título
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F)); // subtítulo
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // iniciar
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F)); // botões


            // pictureBoxLogo
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.Image = Properties.Resources.icon;  
            pictureBoxLogo.Size = new Size(180, 180);

            tableLayoutPanel.Controls.Add(pictureBoxLogo, 0, 0);


            // lblTitulo
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(147, 112, 219);
            lblTitulo.Text = "HPV - Informação é Prevenção";

            tableLayoutPanel.Controls.Add(lblTitulo, 0, 1);


            // lblSubtitulo
            lblSubtitulo.Anchor = AnchorStyles.None;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Arial", 14F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(80, 80, 80);
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Text = "Projeto de conscientização sobre Papilomavírus humano";

            tableLayoutPanel.Controls.Add(lblSubtitulo, 0, 2);


            // btnIniciar
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.BackColor = Color.FromArgb(147, 112, 219);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.Font = new Font("Arial", 16F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Size = new Size(250, 60);
            btnIniciar.Text = "Iniciar";
            btnIniciar.Click += btnIniciar_Click;

            tableLayoutPanel.Controls.Add(btnIniciar, 0, 3);


            // FlowLayoutPanel para botões inferiores
            FlowLayoutPanel flowButtons = new FlowLayoutPanel();
            flowButtons.Anchor = AnchorStyles.None;
            flowButtons.AutoSize = true;
            flowButtons.FlowDirection = FlowDirection.LeftToRight;
            flowButtons.Padding = new Padding(10);
            flowButtons.BackColor = Color.Transparent;


            // btnSobre
            btnSobre.BackColor = Color.FromArgb(186, 85, 211);
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.Font = new Font("Arial", 12F);
            btnSobre.ForeColor = Color.White;
            btnSobre.Size = new Size(150, 45);
            btnSobre.Text = "Créditos";
            btnSobre.Click += btnSobre_Click;

            // btnSair
            btnSair.BackColor = Color.FromArgb(220, 20, 60);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.Font = new Font("Arial", 12F);
            btnSair.ForeColor = Color.White;
            btnSair.Size = new Size(150, 45);
            btnSair.Text = "Sair";
            btnSair.Click += btnSair_Click;

            flowButtons.Controls.Add(btnSobre);
            flowButtons.Controls.Add(btnSair);

            tableLayoutPanel.Controls.Add(flowButtons, 0, 4);


            // FormMain
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HPV - Informação é Prevenção";
            Load += FormMain_Load;

            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnIniciar;
        private Button btnSobre;
        private Button btnSair;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tableLayoutPanel;
    }
}
