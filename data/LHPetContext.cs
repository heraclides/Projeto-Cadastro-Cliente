using Microsoft.EntityFrameworkCore;
using LHPet.Models;

namespace LHPet.Data
{
    public class LHPetContext : DbContext
    {
        public LHPetContext(DbContextOptions<LHPetContext> options) : base(options) { }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}