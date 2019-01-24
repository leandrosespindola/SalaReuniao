using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SalaReuniao.Infra.Repositorio.Mappings;
using SalaReuniao.Dominio.Entities;
using System.Configuration;

namespace SalaReuniao.Infra.Repositorio.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["banco"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new SalaMap());
            modelBuilder.Configurations.Add(new AgendaMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new EstadoMap());

        }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estado> Estados { get; set; }

    }
}
