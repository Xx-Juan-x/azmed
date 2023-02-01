using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class PACIENTES
    {
        // PATRON SINGLETON
        private static PACIENTES instancia;

        public static PACIENTES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new PACIENTES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private PACIENTES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_PACIENTE(MODELO.PACIENTE PACIENTE)
        {
            CASOS_DE_USO.PACIENTES.OPERACIONES_PACIENTES.AGREGAR_PACIENTE(oCONTEXTO, PACIENTE);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_PACIENTE(MODELO.PACIENTE PACIENTE)
        {
            CASOS_DE_USO.PACIENTES.OPERACIONES_PACIENTES.MODIFICAR_PACIENTE(oCONTEXTO, PACIENTE);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_PACIENTE(MODELO.PACIENTE PACIENTE)
        {
            CASOS_DE_USO.PACIENTES.OPERACIONES_PACIENTES.ELIMINAR_PACIENTE(oCONTEXTO, PACIENTE);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.PACIENTE OBTENER_PACIENTE(int CODIGO)
        {
            return CASOS_DE_USO.PACIENTES.GESTION_PACIENTES.OBTENER_PACIENTE(CODIGO, oCONTEXTO);
        }

        public List<MODELO.PACIENTE> OBTENER_PACIENTES()
        {
            return CASOS_DE_USO.PACIENTES.GESTION_PACIENTES.OBTENER_PACIENTES(oCONTEXTO);
        }
    }
}
