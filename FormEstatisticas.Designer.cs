namespace ProjetoHPV
{
    partial class FormEstatisticas
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormEstatisticas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.SizeChanged += new System.EventHandler(this.FormEstatisticas_SizeChanged);
            this.ResumeLayout(false);
        }


    }
}