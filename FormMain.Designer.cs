namespace ProjetoHPV
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnIniciar = new Button();
            btnSobre = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkBlue;
            lblTitulo.Location = new Point(150, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(401, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "HPV - Informação é Prevenção";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(200, 160);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(343, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Projeto de concientização sobre Papilomavírus humano";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.DodgerBlue;
            btnIniciar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(300, 300);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(200, 50);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSobre
            // 
            btnSobre.BackColor = Color.LightSkyBlue;
            btnSobre.Location = new Point(250, 370);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(150, 40);
            btnSobre.TabIndex = 3;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.LightCoral;
            btnSair.ForeColor = Color.DarkRed;
            btnSair.Location = new Point(420, 370);
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
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HPV - Informação é Prevenção";
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
