using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ESPECIALIDADES
    {
        // PATRON SINGLETON
        private static ESPECIALIDADES instancia;

        public static ESPECIALIDADES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new ESPECIALIDADES();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private ESPECIALIDADES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();         
        }

        public void AGREGAR_ESPECIALIDAD(MODELO.ESPECIALIDAD ESPECIALIDAD)
        {
            CASOS_DE_USO.ESPECIALIDADES.OPERACIONES_ESPECIALIDADES.AGREGAR_ESPECIALIDAD(oCONTEXTO, ESPECIALIDAD);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_ESPECIALIDAD(MODELO.ESPECIALIDAD ESPECIALIDAD)
        {
            CASOS_DE_USO.ESPECIALIDADES.OPERACIONES_ESPECIALIDADES.MODIFICAR_ESPECIALIDAD(oCONTEXTO, ESPECIALIDAD);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_ESPECIALIDAD(MODELO.ESPECIALIDAD ESPECIALIDAD)
        {
            CASOS_DE_USO.ESPECIALIDADES.OPERACIONES_ESPECIALIDADES.ELIMINAR_ESPECIALIDAD(oCONTEXTO, ESPECIALIDAD);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.ESPECIALIDAD OBTENER_ESPECIALIDAD(int CODIGO)
        {
            return CASOS_DE_USO.ESPECIALIDADES.GESTION_ESPECIALIDADES.OBTENER_ESPECIALIDAD(CODIGO, oCONTEXTO);
        }

        public List<MODELO.ESPECIALIDAD> OBTENER_ESPECIALIDADES()
        {
            return CASOS_DE_USO.ESPECIALIDADES.GESTION_ESPECIALIDADES.OBTENER_ESPECIALIDADES(oCONTEXTO);
        }


    }
}
