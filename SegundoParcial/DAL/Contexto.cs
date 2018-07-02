using SegundoParcial.Entidades;
using System.Collections.Generic;
using System.Data.Entity;

namespace RegistroDetalle2.DAL
{
    
    public class Contexto : DbContext
    {

        public DbSet<Vehiculos> Vehiculos{ get; set; }



        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
