using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CalculadoraRest.Model.Context
{
    public class MySqlContext:DbContext
    {
        public MySqlContext(){}
        public MySqlContext(DbContextOptions<MySqlContext> options) :base(options){}

        public DbSet<Person> Person { get; set; }
    }
}
