using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class AUDITORIAS
    {
        // PATRON SINGLETON
        private static AUDITORIAS instancia;

        public static AUDITORIAS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new AUDITORIAS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private AUDITORIAS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_AUDITORIA(MODELO.AUDITORIA AUDITORIA)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.AGREGAR_AUDITORIA(oCONTEXTO, AUDITORIA);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_AUDITORIA(MODELO.AUDITORIA AUDITORIA)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.MODIFICAR_AUDITORIA(oCONTEXTO, AUDITORIA);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_AUDITORIA(MODELO.AUDITORIA AUDITORIA)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.ELIMINAR_AUDITORIA(oCONTEXTO, AUDITORIA);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.AUDITORIA OBTENER_AUDITORIA(int CODIGO)
        {
            return CASOS_DE_USO.AUDITORIA.GESTION_AUDITORIA.OBTENER_AUDITORIA(CODIGO, oCONTEXTO);
        }

        public List<MODELO.AUDITORIA> OBTENER_AUDITORIAS()
        {
            return CASOS_DE_USO.AUDITORIA.GESTION_AUDITORIA.OBTENER_AUDITORIAS(oCONTEXTO);
        }

    }
}
