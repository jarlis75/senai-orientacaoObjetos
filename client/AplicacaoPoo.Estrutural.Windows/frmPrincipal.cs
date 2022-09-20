namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirFormConversaoMoeda_Click(object sender, EventArgs e)
        {
            var form = new frmConversorDolar();
            form.Show();
        }

        private void btnAbrirFormComissionamento_Click(object sender, EventArgs e)
        {
            var form = new frmComissionamento();
            form.Show();
        }
    }
}