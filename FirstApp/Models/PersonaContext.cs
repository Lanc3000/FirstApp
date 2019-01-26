using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class PersonaContext: DbContext

    {
        public DbSet<Persona> Personas { get; set; }

        public PersonaContext(DbContextOptions<PersonaContext> options) : base(options) {
            Database.EnsureCreated(); //создаст БД если её нет
        }

    }
}
