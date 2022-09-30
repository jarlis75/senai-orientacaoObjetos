using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class VendedorService
    {
        public string Nome { get; set; } 
        public List<VendedorService> ListaFakVendedor() {

            var lista = new List<VendedorService>();
            lista.Add(new VendedorService()
            {
                Nome = "Guilherme"   
            });
            lista.Add(new VendedorService()
            {
                Nome = "Vando"
            });
            lista.Add(new VendedorService()
            {
                Nome = "Band"
            });

        }
    }
}
