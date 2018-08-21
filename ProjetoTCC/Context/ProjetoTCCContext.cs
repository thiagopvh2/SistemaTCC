using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjetoTCC.Models;

namespace ProjetoTCC.Context
{
    public class ProjetoTccContext : DbContext

    {
        public ProjetoTccContext()
        : base("ProjetoTccContext")
        {

        }
        public DbSet<Lancamento> Lancamentos { get; set; }
    }
}