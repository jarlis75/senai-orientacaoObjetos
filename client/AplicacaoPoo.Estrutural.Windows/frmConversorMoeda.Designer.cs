namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.lblprimeiroValor = new System.Windows.Forms.Label();
            this.lblsegundoValor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.Gray;
            this.txtValorEmDolar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtValorEmDolar.Location = new System.Drawing.Point(69, 119);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(208, 23);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.Text = "informe o valor";
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // lblprimeiroValor
            // 
            this.lblprimeiroValor.AutoSize = true;
            this.lblprimeiroValor.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblprimeiroValor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblprimeiroValor.Location = new System.Drawing.Point(69, 9);
            this.lblprimeiroValor.Name = "lblprimeiroValor";
            this.lblprimeiroValor.Size = new System.Drawing.Size(0, 15);
            this.lblprimeiroValor.TabIndex = 3;
            // 
            // lblsegundoValor
            // 
            this.lblsegundoValor.AutoSize = true;
            this.lblsegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsegundoValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsegundoValor.Location = new System.Drawing.Point(69, 34);
            this.lblsegundoValor.Name = "lblsegundoValor";
            this.lblsegundoValor.Size = new System.Drawing.Size(0, 30);
            this.lblsegundoValor.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Libra Esterlina"});
            this.comboBox1.Location = new System.Drawing.Point(69, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(376, 178);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblsegundoValor);
            this.Controls.Add(this.lblprimeiroValor);
            this.Controls.Add(this.txtValorEmDolar);
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Label lblprimeiroValor;
        private Label lblsegundoValor;
        private ComboBox comboBox1;
    }
}