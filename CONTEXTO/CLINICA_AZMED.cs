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

        public virtual DbSet<MODELO.USUARIO> USUARIOS { get; set; }

        public virtual DbSet<MODELO.OBRA_SOCIAL> OBRAS_SOCIALES { get; set; }

        public virtual DbSet<MODELO.PLAN> PLANES { get; set; }

        public virtual DbSet<MODELO.ATENCION> ATENCIONES { get; set; }

        public virtual DbSet<MODELO.TURNO> TURNOS { get; set; }

        public virtual DbSet<MODELO.FACTURACION> FACTURACION { get; set; }

        public virtual DbSet<MODELO.MATERIAL> MATERIALES { get; set; }

        public virtual DbSet<MODELO.PROVEEDOR> PROVEEDORES { get; set; }

        public virtual DbSet<MODELO.SOLICITUD_PEDIDO> SOLICITUDES_DE_PEDIDO { get; set; }

        public virtual DbSet<MODELO.LISTA_PEDIDO> LISTA_DE_PEDIDOS { get; set; }

        public virtual DbSet<MODELO.COTIZACION> COTIZACIONES { get; set; }

        public virtual DbSet<MODELO.ORDEN_COMPRA> ORDENES_DE_COMPRAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.ESPECIALIDAD>()
                .HasKey(c => c.ID_ESPECIALIDAD);
            modelBuilder.Entity<MODELO.USUARIO>()
                .HasKey(c => c.ID_USUARIO);
            modelBuilder.Entity<MODELO.OBRA_SOCIAL>()
                .HasKey(c => c.ID_OBRA_SOCIAL);
            modelBuilder.Entity<MODELO.PLAN>()
                .HasKey(c => c.ID_PLAN);
            modelBuilder.Entity<MODELO.ATENCION>()
                .HasKey(c => c.ID_ATENCION);
            modelBuilder.Entity<MODELO.TURNO>()
                .HasKey(c => c.ID_TURNO);
            modelBuilder.Entity<MODELO.FACTURACION>()
                .HasKey(c => c.NRO_LEGAJO);
            modelBuilder.Entity<MODELO.MATERIAL>()
                .HasKey(c => c.ID_MATERIAL);
            modelBuilder.Entity<MODELO.PROVEEDOR>()
                .HasKey(c => c.ID_PROVEEDOR);
            modelBuilder.Entity<MODELO.SOLICITUD_PEDIDO>()
                .HasKey(c => c.ID_SOLICITUD_PEDIDO);
            modelBuilder.Entity<MODELO.LISTA_PEDIDO>()
                .HasKey(c => c.ID_LISTA_PEDIDO);
            modelBuilder.Entity<MODELO.COTIZACION>()
                .HasKey(c => c.ID_COTIZACION);
            modelBuilder.Entity<MODELO.ORDEN_COMPRA>()
                .HasKey(c => c.ID_ORDEN_COMPRA);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}