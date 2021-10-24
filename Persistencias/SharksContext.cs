using Microsoft.EntityFrameworkCore;
using Sharks.Sprint04.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sharks.Sprint04.Web.Persistencias
{
    public class SharksContext : DbContext
    {
        // Construtor que recebe as DbContextOptions (string de conexão)
        public SharksContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
