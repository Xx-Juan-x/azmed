using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class GRUPOS
    {
        // PATRON SINGLETON
        private static GRUPOS instancia;

        public static GRUPOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new GRUPOS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private GRUPOS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_GRUPO(MODELO.GRUPO GRUPO)
        {
            CASOS_DE_USO.GRUPO.OPERACIONES_GRUPOS.AGREGAR_GRUPO(oCONTEXTO, GRUPO);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_GRUPO(MODELO.GRUPO GRUPO)
        {
            CASOS_DE_USO.GRUPO.OPERACIONES_GRUPOS.MODIFICAR_GRUPO(oCONTEXTO, GRUPO);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_GRUPO(MODELO.GRUPO GRUPO)
        {
            CASOS_DE_USO.GRUPO.OPERACIONES_GRUPOS.ELIMINAR_GRUPO(oCONTEXTO, GRUPO);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.GRUPO OBTENER_GRUPO(int CODIGO)
        {
            return CASOS_DE_USO.GRUPO.GESTION_GRUPOS.OBTENER_GRUPO(CODIGO, oCONTEXTO);
        }

        public List<MODELO.GRUPO> OBTENER_GRUPOS()
        {
            return CASOS_DE_USO.GRUPO.GESTION_GRUPOS.OBTENER_GRUPOS(oCONTEXTO);
        }
    }
}
