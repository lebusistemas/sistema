using Microsoft.EntityFrameworkCore;
using sistema.Models;

namespace sistema.Datos
{
    public class contectoBD:DbContext
    {
        public contectoBD(DbContextOptions<contectoBD> options) : base(options)
        {

        }

        public DbSet<Cita> Citas { get; set; }

    }
}
