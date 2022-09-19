using AplicaçãoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaçãoPoo.Dominio
{
   //Criar um novo formulario frmCliente
   //Adicionar 4 texBox e 4 Label para
   //Nome, cpf, Valor de debito, Valor de credito
    public class Cliente
    {
        public string? Nome { get; set;}

        public double SaldoInicial { get; set;}
        public string txtcpf { get; set;}
        public Debito Debito { get; set;}
        public  Credito Credito { get; set;}

    }
}
