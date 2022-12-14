using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_dominando_ecossistema_dotnet.Entites;
using Microsoft.EntityFrameworkCore;

namespace dio_dominando_ecossistema_dotnet.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        { 

        }

        public DbSet<Contato> Contatos{ get; set; }
    }
}