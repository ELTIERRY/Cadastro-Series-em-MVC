using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroSeriesMVC.Models;

namespace CadastroSeriesMVC.Data
{
    public class CadastroSeriesMVCContext : DbContext
    {
        public CadastroSeriesMVCContext (DbContextOptions<CadastroSeriesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroSeriesMVC.Models.Serie> Serie { get; set; }
    }
}
