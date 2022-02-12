using System;
using System.Data.Entity;
using System.Linq;

namespace CONTEXTO
{
    public class CLINICA_AZMED : DbContext
    {
        // PATRON SINGLETON
        public static CLINICA_AZMED instancia;

        public static CLINICA_AZMED OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new CLINICA_AZMED();
            }
            return instancia;
        }
        // El contexto se ha configurado para usar una cadena de conexión 'CLINICA_AZMED' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CONTEXTO.CLINICA_AZMED' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'CLINICA_AZMED'  en el archivo de configuración de la aplicación.
        public CLINICA_AZMED()
            : base("name=CLINICA_AZMED")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<MODELO.ESPECIALIDAD> ESPECIALIDADES { get; set; }

        public virtual DbSet<MODELO.ROL> ROLES { get; set; }

        public virtual DbSet<MODELO.USUARIO> USUARIOS { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.ESPECIALIDAD>()
                .HasKey(c => c.ID_ESPECIALIDAD);
            modelBuilder.Entity<MODELO.ROL>()
                .HasKey(c => c.ID_ROL);
            modelBuilder.Entity<MODELO.USUARIO>()
                .HasKey(c => c.ID_USUARIO);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}