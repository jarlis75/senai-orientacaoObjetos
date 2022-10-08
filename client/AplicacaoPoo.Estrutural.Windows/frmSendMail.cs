using MailKit.Net.Smtp;
using MimeKit;

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
            try
            {
                btnEnviarMensagem.Enabled = false;
                var mensagem = new MimeMessage();
                mensagem.From.Add(new MailboxAddress(txtNomeCompleto.Text, txtEmail.Text));

                mensagem.To.Add(new MailboxAddress("jarlis", "jarlis.almeida@aluno.senai.br"));
                mensagem.ReplyTo.Add(new MailboxAddress(txtNomeCompleto.Text, txtEmail.Text));

                mensagem.Subject = txtAssunto.Text;

                mensagem.Body = new TextPart("plain")
                {
                    Text = txtMensagem.Text
                };

                using (var cliet = new SmtpClient())
                {
                    cliet.Connect("smtp.gmail.com", 587, false);

                    //Note ; 
                    cliet.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");

                    cliet.Send(mensagem);
                    cliet.Disconnect(true);

                    btnEnviarMensagem.Enabled = true;
                    MessageBox.Show("Mensagem enviada com socesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
                throw;
            }

            

        }
    }
}
