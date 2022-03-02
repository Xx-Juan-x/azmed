using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.FACTURACION
{
    public class GESTION_FACTURACION
    {
        public static MODELO.FACTURACION OBTENER_FACTURACION(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.FACTURACION.Include("PACIENTE").Include("TIPO").Include("OBRA_SOCIAL").Include("PLAN").Include("ESPECIALIDAD").Include("PROFESIONAL").FirstOrDefault(_ => _.NRO_LEGAJO == CODIGO);
        }

        public static List<MODELO.FACTURACION> OBTENER_FACTURACIONES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.FACTURACION.Include("PACIENTE").Include("TIPO").Include("OBRA_SOCIAL").Include("PLAN").Include("ESPECIALIDAD").Include("PROFESIONAL").ToList();
        }
    }
}
