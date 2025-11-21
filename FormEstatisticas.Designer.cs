namespace ProjetoHPV
{
    partial class FormEstatisticas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
        /// Método necessário para compatibilidade com o Windows Forms Designer.
        /// Ele não cria controles, pois eles são montados dinamicamente no FormEstatisticas.cs
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // 
            // FormEstatisticas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Name = "FormEstatisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatísticas e Dados - HPV";

            // Eventos principais
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.SizeChanged += new System.EventHandler(this.FormEstatisticas_SizeChanged);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
