using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class PLANES
    {
        // PATRON SINGLETON
        private static PLANES instancia;

        public static PLANES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new PLANES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private PLANES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_OBRA_SOCIAL(MODELO.OBRA_SOCIAL OBRA_SOCIAL)
        {
            CASOS_DE_USO.OBRAS_SOCIALES.OPERACIONES_OBRAS_SOCIALES.AGREGAR_OBRA_SOCIAL(oCONTEXTO, OBRA_SOCIAL);
            oCONTEXTO.SaveChanges();
        }

        public void AGREGAR_PLAN(MODELO.PLAN PLAN)
        {
            CASOS_DE_USO.PLANES.OPERACIONES_PLANES.AGREGAR_PLAN(oCONTEXTO, PLAN);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_PLAN(MODELO.PLAN PLAN)
        {
            CASOS_DE_USO.PLANES.OPERACIONES_PLANES.MODIFICAR_PLAN(oCONTEXTO, PLAN);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_PLAN(MODELO.PLAN PLAN)
        {
            CASOS_DE_USO.PLANES.OPERACIONES_PLANES.ELIMINAR_PLAN(oCONTEXTO, PLAN);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.PLAN OBTENER_PLAN(int CODIGO)
        {
            return CASOS_DE_USO.PLANES.GESTION_PLANES.OBTENER_PLAN(CODIGO, oCONTEXTO);
        }

        public List<MODELO.PLAN> OBTENER_PLANES()
        {
            return CASOS_DE_USO.PLANES.GESTION_PLANES.OBTENER_PLANES(oCONTEXTO);
        }
    }
}
