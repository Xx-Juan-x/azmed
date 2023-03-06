using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ACCIONES
{
    public class GESTION_ACCIONES
    {
        public static MODELO.ACCIONES OBTENER_ACCION(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ACCIONES.FirstOrDefault(_ => _.ID_ACCIONES == CODIGO);
        }

        public static List<MODELO.ACCIONES> OBTENER_ACCIONES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ACCIONES.ToList();
        }
    }
}
