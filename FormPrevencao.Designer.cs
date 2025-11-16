namespace ProjetoHPV
{
    partial class FormPrevencao
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
            // FormPrevencao
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormPrevencao";
            this.Load += new System.EventHandler(this.FormPrevencao_Load);
            this.SizeChanged += new System.EventHandler(this.FormPrevencao_SizeChanged);
            this.ResumeLayout(false);
        }

    }
}