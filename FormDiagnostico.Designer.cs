using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHPV
{
    partial class FormDiagnostico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        // Declarações dos controles usados pelo FormDiagnostico
        private Panel panelHeader;
        private Panel panelMain;
        private TabControl tabControlDiagnostico;
        private Button btnVoltar;

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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();

            // Instanciar controles
            this.panelHeader = new Panel();
            this.panelMain = new Panel();
            this.tabControlDiagnostico = new TabControl();
            this.btnVoltar = new Button();

            // 
            // FormDiagnostico
            // 
            this.SuspendLayout();
            this.ClientSize = new Size(1000, 700);
            this.Name = "FormDiagnostico";
            this.Text = "Diagnóstico e Tratamento - HPV";
            this.Load += new EventHandler(this.FormDiagnostico_Load);
            
            this.panelHeader.BackColor = Color.FromArgb(147, 112, 219);
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(this.ClientSize.Width, 100);
            this.panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(this.panelHeader);

            // (Adiciona labels temporários no header para evitar NullReference ao usar UpdateLayout)
            var lblTitulo = new Label
            {
                Name = "lblTituloHeader",
                Text = "🔬 Diagnóstico e Tratamento",
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 20),
                Font = new Font("Segoe UI", 22, FontStyle.Bold)
            };
            this.panelHeader.Controls.Add(lblTitulo);

            var lblSubtitulo = new Label
            {
                Name = "lblSubtituloHeader",
                Text = "Conheça os exames, tratamentos e importância do diagnóstico precoce",
                ForeColor = Color.Lavender,
                AutoSize = true,
                Location = new Point(20, 55),
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.panelHeader.Controls.Add(lblSubtitulo);

            // 
            // tabControlDiagnostico
            //
            this.tabControlDiagnostico.Name = "tabControlDiagnostico";
            this.tabControlDiagnostico.Location = new Point(50, 120);
            this.tabControlDiagnostico.Size = new Size(900, 450);
            this.tabControlDiagnostico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(this.tabControlDiagnostico);

            // 
            // panelMain
            // 
            this.panelMain.Name = "panelMain";
            this.panelMain.Location = new Point(0, 0);
            this.panelMain.Size = new Size(1000, 700);
            this.panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
             
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Text = "← Voltar ao Menu Principal";
            this.btnVoltar.Size = new Size(180, 40);
            this.btnVoltar.Location = new Point((this.ClientSize.Width - this.btnVoltar.Width) / 2, this.ClientSize.Height - 80);
            this.btnVoltar.Anchor = AnchorStyles.Bottom;
            this.btnVoltar.FlatStyle = FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.BackColor = Color.FromArgb(158, 158, 158);
            this.btnVoltar.ForeColor = Color.White;
            this.btnVoltar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnVoltar.Click += new EventHandler(this.btnVoltar_Click);
            this.Controls.Add(this.btnVoltar);

            // Finalização do InitializeComponent
            this.ResumeLayout(false);
        }

        #endregion
    }
}
