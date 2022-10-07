using MimeKit;
using System.Text;

namespace AplicacaoPoo.Estrutural.Windows
{
    internal class MailBoxAddress : InternetAddress
    {
        private string text1;
        private string text2;

        public MailBoxAddress(Encoding encoding, string name) : base(encoding, name)
        {
        }

        public MailBoxAddress(string text1, string text2)
        {
            this.text1 = text1;
            this.text2 = text2;
        }
    }
}