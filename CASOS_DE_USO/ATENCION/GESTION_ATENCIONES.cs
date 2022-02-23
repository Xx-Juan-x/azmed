using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ATENCION
{
    public class GESTION_ATENCIONES
    {
        public static MODELO.ATENCION OBTENER_ATENCION(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ATENCIONES.Include("PROFESIONAL").Include("ESPECIALIDAD").FirstOrDefault(_ => _.ID_ATENCION == CODIGO);
        }

        public static List<MODELO.ATENCION> OBTENER_ATENCIONES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.ATENCIONES.Include("PROFESIONAL").Include("ESPECIALIDAD").ToList();
        }
    }
}
