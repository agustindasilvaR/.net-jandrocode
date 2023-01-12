
using ejercicio_01.net.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ejercicio_01.net.Config
{
    public class DBEmpresaContext : DbContext
    {
        public DBEmpresaContext(DbContextOptions<DBEmpresaContext> options) : base(options)
        {

        }
        public DbSet<Empleado> Empresa { get; set; }
    }
}
