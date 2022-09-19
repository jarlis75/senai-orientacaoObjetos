namespace AplicacaoPoo.Windows
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.txtNome = "jarlis Santos";
            txtNome.Text = cliente.txtNome;
            txtCpf.Text = "12365498545";
        }
    }
}

