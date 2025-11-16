namespace ProjetoHPV
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnIniciar = new Button();
            btnSobre = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(147, 112, 219);
            lblTitulo.Location = new Point(142, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "HPV - Informação é Prevenção";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubtitulo.Location = new Point(220, 150);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(344, 18);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Projeto de conscientização sobre Papilomavírus humano";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top;
            btnIniciar.BackColor = Color.FromArgb(147, 112, 219);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(292, 250);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(200, 50);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSobre
            // 
            btnSobre.Anchor = AnchorStyles.Top;
            btnSobre.BackColor = Color.FromArgb(186, 85, 211);
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSobre.ForeColor = Color.White;
            btnSobre.Location = new Point(242, 320);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(150, 40);
            btnSobre.TabIndex = 3;
            btnSobre.Text = "Créditos";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top;
            btnSair.BackColor = Color.FromArgb(220, 20, 60);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(392, 320);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(150, 40);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(btnSair);
            Controls.Add(btnSobre);
            Controls.Add(btnIniciar);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HPV - Informação é Prevenção";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnIniciar;
        private Button btnSobre;
        private Button btnSair;
    }
}