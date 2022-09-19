namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            this.btnAbrirFormConversaoMoeda = new System.Windows.Forms.Button();
            this.btnAbrirFormComissionamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormConversaoMoeda
            // 
            this.btnAbrirFormConversaoMoeda.Location = new System.Drawing.Point(39, 46);
            this.btnAbrirFormConversaoMoeda.Name = "btnAbrirFormConversaoMoeda";
            this.btnAbrirFormConversaoMoeda.Size = new System.Drawing.Size(149, 77);
            this.btnAbrirFormConversaoMoeda.TabIndex = 0;
            this.btnAbrirFormConversaoMoeda.Text = "CONVERSOR DE MOEDA";
            this.btnAbrirFormConversaoMoeda.UseVisualStyleBackColor = true;
            // 
            // btnAbrirFormComissionamento
            // 
            this.btnAbrirFormComissionamento.Location = new System.Drawing.Point(280, 46);
            this.btnAbrirFormComissionamento.Name = "btnAbrirFormComissionamento";
            this.btnAbrirFormComissionamento.Size = new System.Drawing.Size(167, 77);
            this.btnAbrirFormComissionamento.TabIndex = 1;
            this.btnAbrirFormComissionamento.Text = "COMISSIONAMENTO";
            this.btnAbrirFormComissionamento.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 156);
            this.Controls.Add(this.btnAbrirFormComissionamento);
            this.Controls.Add(this.btnAbrirFormConversaoMoeda);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormConversaoMoeda;
        private Button btnAbrirFormComissionamento;
    }
}