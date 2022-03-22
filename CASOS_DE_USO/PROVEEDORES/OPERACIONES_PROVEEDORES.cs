using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PROVEEDORES
{
    public class OPERACIONES_PROVEEDORES
    {
        public static void AGREGAR_PROVEEDOR(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PROVEEDOR PROVEEDOR)
        {
            AZMED_CLINICA.PROVEEDORES.Add(PROVEEDOR);
        }

        public static void MODIFICAR_PROVEEDOR(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PROVEEDOR PROVEEDOR)
        {
            AZMED_CLINICA.Entry(PROVEEDOR).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_PROVEEDOR(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.PROVEEDOR PROVEEDOR)
        {
            AZMED_CLINICA.PROVEEDORES.Remove(PROVEEDOR);
        }

    }
}
