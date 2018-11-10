using CadastroDeCliente.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCliente.Contextos
{
    public class AgendaContexto : DbContext
    {
        public AgendaContexto() : base(nameOrConnectionString: "agenda")
        {
            Database.SetInitializer<AgendaContexto>(new AgendaContextoInitializer());
        }
        public DbSet<Contato> Client { get; set; }
    }


    public class AgendaContextoInitializer : DropCreateDatabaseAlways<AgendaContexto>
    {

    }
}
