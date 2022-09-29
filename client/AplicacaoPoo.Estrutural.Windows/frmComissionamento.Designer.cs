namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissionamento
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
            this.cmbComissionado = new System.Windows.Forms.ComboBox();
            this.txtPrecoUnitarioDaPeca = new System.Windows.Forms.TextBox();
            this.txtQuantidadevendida = new System.Windows.Forms.TextBox();
            this.txtCodigoDaPeca = new System.Windows.Forms.TextBox();
            this.lblIdentificadorDoVendedor = new System.Windows.Forms.Label();
            this.lblCodigoDaPeca = new System.Windows.Forms.Label();
            this.lblPrecoUnitarioDaPeca = new System.Windows.Forms.Label();
            this.lblQuantidadeVendida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbComissionado
            // 
            this.cmbComissionado.FormattingEnabled = true;
            this.cmbComissionado.Items.AddRange(new object[] {
            "jarlis",
            "jaen",
            "samira",
            "henrique",
            "caca",
            "didi",
            "dodo"});
            this.cmbComissionado.Location = new System.Drawing.Point(249, 12);
            this.cmbComissionado.Name = "cmbComissionado";
            this.cmbComissionado.Size = new System.Drawing.Size(298, 23);
            this.cmbComissionado.TabIndex = 0;
            // 
            // txtPrecoUnitarioDaPeca
            // 
            this.txtPrecoUnitarioDaPeca.Location = new System.Drawing.Point(249, 122);
            this.txtPrecoUnitarioDaPeca.Name = "txtPrecoUnitarioDaPeca";
            this.txtPrecoUnitarioDaPeca.Size = new System.Drawing.Size(298, 23);
            this.txtPrecoUnitarioDaPeca.TabIndex = 2;
            // 
            // txtQuantidadevendida
            // 
            this.txtQuantidadevendida.Location = new System.Drawing.Point(249, 168);
            this.txtQuantidadevendida.Name = "txtQuantidadevendida";
            this.txtQuantidadevendida.Size = new System.Drawing.Size(298, 23);
            this.txtQuantidadevendida.TabIndex = 3;
            // 
            // txtCodigoDaPeca
            // 
            this.txtCodigoDaPeca.Location = new System.Drawing.Point(249, 70);
            this.txtCodigoDaPeca.Name = "txtCodigoDaPeca";
            this.txtCodigoDaPeca.Size = new System.Drawing.Size(298, 23);
            this.txtCodigoDaPeca.TabIndex = 4;
            this.txtCodigoDaPeca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdentificadorDoVendedor
            // 
            this.lblIdentificadorDoVendedor.AutoSize = true;
            this.lblIdentificadorDoVendedor.Location = new System.Drawing.Point(54, 15);
            this.lblIdentificadorDoVendedor.Name = "lblIdentificadorDoVendedor";
            this.lblIdentificadorDoVendedor.Size = new System.Drawing.Size(144, 15);
            this.lblIdentificadorDoVendedor.TabIndex = 5;
            this.lblIdentificadorDoVendedor.Text = "Identificador do Vendedor";
            // 
            // lblCodigoDaPeca
            // 
            this.lblCodigoDaPeca.AutoSize = true;
            this.lblCodigoDaPeca.Location = new System.Drawing.Point(54, 73);
            this.lblCodigoDaPeca.Name = "lblCodigoDaPeca";
            this.lblCodigoDaPeca.Size = new System.Drawing.Size(90, 15);
            this.lblCodigoDaPeca.TabIndex = 6;
            this.lblCodigoDaPeca.Text = "Código da peça";
            // 
            // lblPrecoUnitarioDaPeca
            // 
            this.lblPrecoUnitarioDaPeca.AutoSize = true;
            this.lblPrecoUnitarioDaPeca.Location = new System.Drawing.Point(54, 130);
            this.lblPrecoUnitarioDaPeca.Name = "lblPrecoUnitarioDaPeca";
            this.lblPrecoUnitarioDaPeca.Size = new System.Drawing.Size(128, 15);
            this.lblPrecoUnitarioDaPeca.TabIndex = 7;
            this.lblPrecoUnitarioDaPeca.Text = "Preço unitário da peça ";
            // 
            // lblQuantidadeVendida
            // 
            this.lblQuantidadeVendida.AutoSize = true;
            this.lblQuantidadeVendida.Location = new System.Drawing.Point(54, 176);
            this.lblQuantidadeVendida.Name = "lblQuantidadeVendida";
            this.lblQuantidadeVendida.Size = new System.Drawing.Size(114, 15);
            this.lblQuantidadeVendida.TabIndex = 8;
            this.lblQuantidadeVendida.Text = "Quantidade vendida";
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 338);
            this.Controls.Add(this.lblQuantidadeVendida);
            this.Controls.Add(this.lblPrecoUnitarioDaPeca);
            this.Controls.Add(this.lblCodigoDaPeca);
            this.Controls.Add(this.lblIdentificadorDoVendedor);
            this.Controls.Add(this.txtCodigoDaPeca);
            this.Controls.Add(this.txtQuantidadevendida);
            this.Controls.Add(this.txtPrecoUnitarioDaPeca);
            this.Controls.Add(this.cmbComissionado);
            this.Name = "frmComissionamento";
            this.Text = "frmComissionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbComissionado;
        private TextBox textBox2;
        private TextBox txtQuantidadevendida;
        private TextBox textBox1;
        private Label lblIdentificadorDoVendedor;
        private Label lblCodigoDaPeca;
        private Label lblPrecoUnitarioDaPeca;
        private Label lblQuantidadeVendida;
        private TextBox txtPrecoUnitarioDaPeca;
        private TextBox txtCodigoDaPeca;
    }
}