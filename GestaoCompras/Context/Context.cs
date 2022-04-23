using GestaoCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoCompras.Context
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public virtual DbSet<FornecedorFisico> FornecedorFisico { get; set; } = null!;
        public virtual DbSet<FornecedorJuridico> FornecedorJuridico { get; set; } = null!;

    }
}
