using CRUD_Cadastro_Clientes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CRUD_Cadastro_Clientes.DAL
{
    public class ClienteContexto : DbContext
    {
        public ClienteContexto() : base("ClienteContexto")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}