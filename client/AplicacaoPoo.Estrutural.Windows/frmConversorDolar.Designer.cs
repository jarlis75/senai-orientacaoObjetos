namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorDolar
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
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.btnConverterDolarEmReal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Location = new System.Drawing.Point(80, 56);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.PlaceholderText = "cotação dolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(229, 23);
            this.txtCotacaoDolar.TabIndex = 0;
            this.txtCotacaoDolar.TextChanged += new System.EventHandler(this.txtCotacaoDolar_TextChanged);
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.Location = new System.Drawing.Point(80, 116);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "valor em dolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(222, 23);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // btnConverterDolarEmReal
            // 
            this.btnConverterDolarEmReal.Location = new System.Drawing.Point(97, 234);
            this.btnConverterDolarEmReal.Name = "btnConverterDolarEmReal";
            this.btnConverterDolarEmReal.Size = new System.Drawing.Size(147, 23);
            this.btnConverterDolarEmReal.TabIndex = 2;
            this.btnConverterDolarEmReal.Text = "Converter Em reais";
            this.btnConverterDolarEmReal.UseVisualStyleBackColor = true;
            this.btnConverterDolarEmReal.Click += new System.EventHandler(this.btnConverterDolarEmReal_Click);
            // 
            // frmConversorDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConverterDolarEmReal);
            this.Controls.Add(this.txtValorEmDolar);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Name = "frmConversorDolar";
            this.Text = "frmConversorDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCotacaoDolar;
        private TextBox txtValorEmDolar;
        private Button btnConverterDolarEmReal;
    }
}