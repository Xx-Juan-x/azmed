using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class OBRAS_SOCIALES
    {
        // PATRON SINGLETON
        private static OBRAS_SOCIALES instancia;

        public static OBRAS_SOCIALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new OBRAS_SOCIALES();
            }
            return instancia;
        }

        //Creo mi objeto contexto
        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private OBRAS_SOCIALES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_OBRA_SOCIAL(MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            CASOS_DE_USO.OBRAS_SOCIALES.OPERACIONES_OBRAS_SOCIALES.AGREGAR_OBRA_SOCIAL(oCONTEXTO, OBRA_SOCIAL);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_OBRA_SOCIAL(MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            CASOS_DE_USO.OBRAS_SOCIALES.OPERACIONES_OBRAS_SOCIALES.MODIFICAR_OBRA_SOCIAL(oCONTEXTO, OBRA_SOCIAL);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_OBRA_SOCIAL(MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            CASOS_DE_USO.OBRAS_SOCIALES.OPERACIONES_OBRAS_SOCIALES.ELIMINAR_OBRA_SOCIAL(oCONTEXTO, OBRA_SOCIAL);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.OBRA_SOCIAL OBTENER_OBRA_SOCIAL(int CODIGO)
        {
            return CASOS_DE_USO.OBRAS_SOCIALES.GESTION_OBRAS_SOCIALES.OBTENER_OBRA_SOCIAL(CODIGO, oCONTEXTO);
        }

        public List<MODELO.OBRA_SOCIAL> OBTENER_OBRAS_SOCIALES()
        {
            return CASOS_DE_USO.OBRAS_SOCIALES.GESTION_OBRAS_SOCIALES.OBTENER_OBRAS_SOCIALES(oCONTEXTO);
        }


    }
}
