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
    public partial class frmConversorDolar : Form
    {
        public frmConversorDolar()
        {
            InitializeComponent();
            btnConverterDolarEmReal.Enabled = false;
        }

        private void btnConverterDolarEmReal_Click(object sender, EventArgs e)
        {
            var cotacaoDolar = decimal.Parse(btnConverterDolarEmReal.Text);
            var valorEmdolar = decimal.Parse(btnConverterDolarEmReal.Text);
            var valorconvertido = cotacaoDolar * valorEmdolar;

            MessageBox.Show(valorconvertido.ToString(), "deu certo");                                                                    

        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse (txtCotacaoDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um Valor Número");
                txtCotacaoDolar.Focus();
                throw;
            }
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            
                try
                {
                    var resultado = decimal.Parse(txtCotacaoDolar.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite um Valor Número");
                    txtValorEmDolar.Focus();
                    throw;
                }
            

        }
    }
}
