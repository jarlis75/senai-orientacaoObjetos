﻿using AplicacaoPoo.Dominio.helpers;
using AplicacaoPoo.Dominio.services;
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
    public partial class frmConversorMoeda : Form
    {
       
        public frmConversorMoeda()
        {
            InitializeComponent();
            
            lblprimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblsegundoValor.Text = $"5,12 {MoedaHelper.Real}";

        }


        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtValorEmDolar.Text == "")
                {
                    return; 
                }
                
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var Moeda = new ConverterMoedaServices();
                var resultado = Moeda.ConverterDolarEmReal(valorEmDolar);
                lblprimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                lblsegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            }


            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorEmDolar.Focus();

              

            }
        }

      
    }    
}

        
    
