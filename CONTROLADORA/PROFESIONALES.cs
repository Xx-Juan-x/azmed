using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class PROFESIONALES
    {
        // PATRON SINGLETON
        private static PROFESIONALES instancia;

        public static PROFESIONALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new PROFESIONALES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private PROFESIONALES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_PROFESIONAL(MODELO.PROFESIONAL PROFESIONAL)
        {
            CASOS_DE_USO.PROFESIONALES.OPERACIONES_PROFESIONALES.AGREGAR_PROFESIONAL(oCONTEXTO, PROFESIONAL);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_PROFESIONAL(MODELO.PROFESIONAL PROFESIONAL)
        {
            CASOS_DE_USO.PROFESIONALES.OPERACIONES_PROFESIONALES.MODIFICAR_PROFESIONAL(oCONTEXTO, PROFESIONAL);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_PROFESIONAL(MODELO.PROFESIONAL PROFESIONAL)
        {
            CASOS_DE_USO.PROFESIONALES.OPERACIONES_PROFESIONALES.ELIMINAR_PROFESIONAL(oCONTEXTO, PROFESIONAL);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.PROFESIONAL OBTENER_PROFESIONAL(int CODIGO)
        {
            return CASOS_DE_USO.PROFESIONALES.GESTION_PROFESIONALES.OBTENER_PROFESIONAL(CODIGO, oCONTEXTO);
        }

        public List<MODELO.PROFESIONAL> OBTENER_PROFESIONALES()
        {
            return CASOS_DE_USO.PROFESIONALES.GESTION_PROFESIONALES.OBTENER_PROFESIONALES(oCONTEXTO);
        }
    }
}
