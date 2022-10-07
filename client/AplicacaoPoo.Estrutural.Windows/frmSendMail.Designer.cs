namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmSendMail
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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtMensagem = new System.Windows.Forms.Label();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(92, 37);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(301, 23);
            this.txtNomeCompleto.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome completo";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(92, 136);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(301, 23);
            this.txtAssunto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Assunto";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(92, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // txtMensagem
            // 
            this.txtMensagem.AutoSize = true;
            this.txtMensagem.Location = new System.Drawing.Point(92, 172);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(66, 15);
            this.txtMensagem.TabIndex = 9;
            this.txtMensagem.Text = "Mensagem";
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Location = new System.Drawing.Point(177, 312);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(110, 23);
            this.btnEnviarMensagem.TabIndex = 10;
            this.btnEnviarMensagem.Text = "Enviar mensagem";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNomeCompleto);
            this.Name = "frmSendMail";
            this.Text = "frmSendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtAssunto;
        private Label label1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label txtMensagem;
        private Button btnEnviarMensagem;
    }
}