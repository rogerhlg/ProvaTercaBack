using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Tabela de sintomas cadastrados
        public DbSet<Automovel> AutomovelTable { get; set; }

    }
}