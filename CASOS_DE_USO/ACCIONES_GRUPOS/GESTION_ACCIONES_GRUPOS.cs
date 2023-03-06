using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.ACCIONES_GRUPOS
{
    public class GESTION_ACCIONES_GRUPOS
    {
            public static MODELO.ACCIONES_GRUPOS OBTENER_ACCION_GRUPO(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
            {
                return AZMED_CLINICA.ACCIONES_GRUPOS.Include("ACCION").FirstOrDefault(_ => _.ID_ACCION_GRUPO == CODIGO);
            }

            public static List<MODELO.ACCIONES_GRUPOS> OBTENER_ACCIONES_GRUPOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
            {
                return AZMED_CLINICA.ACCIONES_GRUPOS.Include("ACCION").ToList();
            }
    }
}
