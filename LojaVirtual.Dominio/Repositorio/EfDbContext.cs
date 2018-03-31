using LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext :DbContext
    {
        public EfDbContext() : base("Loja")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
