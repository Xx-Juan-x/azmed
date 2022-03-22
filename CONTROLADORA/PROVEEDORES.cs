using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class PROVEEDORES
    {
        // PATRON SINGLETON
        private static PROVEEDORES instancia;

        public static PROVEEDORES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new PROVEEDORES();
            }
            return instancia;
        }

        //Creo mi objeto contexto
        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private PROVEEDORES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_PROVEEDOR(MODELO.PROVEEDOR PROVEEDOR)
        {
            CASOS_DE_USO.PROVEEDORES.OPERACIONES_PROVEEDORES.AGREGAR_PROVEEDOR(oCONTEXTO, PROVEEDOR);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_PROVEEDOR(MODELO.PROVEEDOR PROVEEDOR)
        {
            CASOS_DE_USO.PROVEEDORES.OPERACIONES_PROVEEDORES.MODIFICAR_PROVEEDOR(oCONTEXTO, PROVEEDOR);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_PROVEEDOR(MODELO.PROVEEDOR PROVEEDOR)
        {
            CASOS_DE_USO.PROVEEDORES.OPERACIONES_PROVEEDORES.ELIMINAR_PROVEEDOR(oCONTEXTO, PROVEEDOR);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.PROVEEDOR OBTENER_PROVEEDOR(int CODIGO)
        {
            return CASOS_DE_USO.PROVEEDORES.GESTION_PROVEEDORES.OBTENER_PROVEEDOR(CODIGO, oCONTEXTO);
        }

        public List<MODELO.PROVEEDOR> OBTENER_PROVEEDORES()
        {
            return CASOS_DE_USO.PROVEEDORES.GESTION_PROVEEDORES.OBTENER_PROVEEDORES(oCONTEXTO);
        }
    }
}
