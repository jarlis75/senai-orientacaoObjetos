﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    //static class c#
    //partial class c#
    //abstract  class c#
    public class ConverterMoedaServices
    {
        decimal CotacaoDolar = 5.25m;
        decimal CotacaoLibra = 6.15m;
        decimal CotacaoEuro = 6.0m;

        public decimal ConverterDolarEmReal(decimal valor)
        {

            return valor * CotacaoDolar;
        }

        public decimal CotacaoLibraEmReal(decimal valor)
        {
            return valor * CotacaoLibra; 
        }

        public decimal CotacaoEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;   
        }

    }
}