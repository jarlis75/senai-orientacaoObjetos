using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
        }

        public object Mensagem { get; private set; }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailBoxAddress(txtNomeCompleto.Text, txtEmail.Text));

            mensagem.To.Add(new MailboxAddress("jarlis", "jharlis(@gmail.com"));

            mensagem.Subject = txtAssunto.Text;

            mensagem.Body = new TextPart("plain")
            {
                Text = txtMensagem.Text
            };

            using (var cliet = new SmtpClient())
            {
                cliet.Connect("smtp.gmail.com", 587, false);

                //Note ; 
                cliet.Authenticate("jharlis9@gmail.com", "senha");

                cliet.Send(mensagem);   
                cliet.Disconnect(true);
            }
        }
    }
}
