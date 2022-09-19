using AplicaçãoPooDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaçãoPoo.Dominio
{
    public class Debito
    {
        Pagamento Pagamento { get; set; } 
        
        double Desconto { get; set; }

        public double DebitarValor(double saldo, double desconto)
        { 
            var resultado = desconto;
            return resultado;   
        }

    }
}
