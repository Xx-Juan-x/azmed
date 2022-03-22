using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.PROVEEDORES
{
    public class GESTION_PROVEEDORES
    {
        public static MODELO.PROVEEDOR OBTENER_PROVEEDOR(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PROVEEDORES.FirstOrDefault(_ => _.ID_PROVEEDOR == CODIGO);
        }

        public static List<MODELO.PROVEEDOR> OBTENER_PROVEEDORES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.PROVEEDORES.ToList();
        }

    }
}
