using AplicacaoPoo.Dominio.Helpers;
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
    public partial class frmComissionamento : Form
    {
       

        public frmComissionamento()
        {
            InitializeComponent();
        }
        private void cmbComissionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbComissionado.DataSource = list;
            cmbComissionado.SelectedIndex = 0;

        }
        private void txtCodigoDaPeca_TextChanged(object sender, EventArgs e)
        {
            var codigoDaPeca = txtCodigoDaPeca.Text;        

        }



        private void txtPrecoUnitarioDaPeca_TextChanged(object sender, EventArgs e)
        {
            var precoUnitarioDaPeca = txtPrecoUnitarioDaPeca.Text;  

        }

       
        private void txtQuantidadevendida_TextChanged(object sender, EventArgs e)
        {
            var quantidadevendida = txtQuantidadevendida.Text;  

        }

       
    }
}
