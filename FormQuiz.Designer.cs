namespace ProjetoHPV
{
    partial class FormQuiz
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
           
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormQuiz";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.SizeChanged += new System.EventHandler(this.FormQuiz_SizeChanged);
            this.ResumeLayout(false);
        }
    }
}