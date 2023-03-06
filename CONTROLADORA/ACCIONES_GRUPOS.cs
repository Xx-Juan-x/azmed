using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ACCIONES_GRUPOS
    {
        // PATRON SINGLETON
        private static ACCIONES_GRUPOS instancia;

        public static ACCIONES_GRUPOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new ACCIONES_GRUPOS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private ACCIONES_GRUPOS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_ACCIONES_GRUPOS(MODELO.ACCIONES_GRUPOS ACCIONES_GRUPOS)
        {
            CASOS_DE_USO.ACCIONES_GRUPOS.OPERACIONES_ACCIONES_GRUPOS.AGREGAR_ACCIONES_GRUPOS(oCONTEXTO, ACCIONES_GRUPOS);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_ACCIONES_GRUPOS(MODELO.ACCIONES_GRUPOS ACCIONES_GRUPOS)
        {
            CASOS_DE_USO.ACCIONES_GRUPOS.OPERACIONES_ACCIONES_GRUPOS.MODIFICAR_ACCIONES_GRUPOS(oCONTEXTO, ACCIONES_GRUPOS);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_ACCIONES_GRUPOS(MODELO.ACCIONES_GRUPOS ACCIONES_GRUPOS)
        {
            CASOS_DE_USO.ACCIONES_GRUPOS.OPERACIONES_ACCIONES_GRUPOS.ELIMINAR_ACCIONES_GRUPOS(oCONTEXTO, ACCIONES_GRUPOS);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.ACCIONES_GRUPOS OBTENER_ACCION_GRUPO(int CODIGO)
        {
            return CASOS_DE_USO.ACCIONES_GRUPOS.GESTION_ACCIONES_GRUPOS.OBTENER_ACCION_GRUPO(CODIGO, oCONTEXTO);
        }

        public List<MODELO.ACCIONES_GRUPOS> OBTENER_ACCIONES_GRUPOS()
        {
            return CASOS_DE_USO.ACCIONES_GRUPOS.GESTION_ACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS(oCONTEXTO);
        }
    }
}
