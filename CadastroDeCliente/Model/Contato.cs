using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCliente.Model
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public String Nome { get; set; }
        public String Endereço { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

    }
}
