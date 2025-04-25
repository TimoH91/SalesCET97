using Microsoft.EntityFrameworkCore;
using SalesCET97.Web.Data.Entities;

namespace SalesCET97.Web.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        
        }

        //esta propriedade cria a tabela
        public DbSet<Country> Countries { get; set; }

    }
}
