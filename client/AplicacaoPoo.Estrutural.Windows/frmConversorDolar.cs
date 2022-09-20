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
        private bool cotacaoEhValido;
        private bool ValorEmDolarEhvalido;
        private object btnConverterDolarEmReal;

        public frmConversorDolar()
        {
            InitializeComponent();
            txtCotacaodolar.Enabled = false;
        }

        private void btnConverterDolarEmReal_Click(object sender, EventArgs e)
        {
            var cotacaoDolar = decimal.Parse(txtCotacaoDolar.Text);
            var valorEmdolar = decimal.Parse(txtCotacaoDolar.Text);
            var valorconvertido = cotacaoDolar * valorEmdolar;

            MessageBox.Show(valorconvertido.ToString(), "deu certo");                                                                    

        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse (txtCotacaoDolar.Text);
                cotacaoEhValido = true;
                if (ValorEmDolarEhvalido && cotacaoEhValido) 
                {
                    txtCotacaodolar.Enabled = true;  
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um Valor Número");
                txtCotacaoDolar.Focus();
                cotacaoEhValido = false;
                btnConverterDolarEmReal = false;
            }
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var resultado = decimal.Parse(txtCotacaoDolar.Text);
                ValorEmDolarEhvalido = true;
                if (ValorEmDolarEhvalido && cotacaoEhValido)
                {
                    txtCotacaodolar.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um Valor Número");
                txtValorEmDolar.Focus();
                ValorEmDolarEhvalido = false;
                btnConverterDolarEmReal = false;


            }


        }
    }
}
