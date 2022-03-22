using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class MATERIALES
    {
        // PATRON SINGLETON
        private static MATERIALES instancia;

        public static MATERIALES OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new MATERIALES();
            }
            return instancia;
        }

        //Creo mi objeto contexto
        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private MATERIALES()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_MATERIAL(MODELO.MATERIAL MATERIAL)
        {
            CASOS_DE_USO.MATERIALES.OPERACIONES_MATERIALES.AGREGAR_MATERIAL(oCONTEXTO, MATERIAL);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_MATERIAL(MODELO.MATERIAL MATERIAL)
        {
            CASOS_DE_USO.MATERIALES.OPERACIONES_MATERIALES.MODIFICAR_MATERIAL(oCONTEXTO, MATERIAL);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_MATERIAL(MODELO.MATERIAL MATERIAL)
        {
            CASOS_DE_USO.MATERIALES.OPERACIONES_MATERIALES.ELIMINAR_MATERIAL(oCONTEXTO, MATERIAL);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.MATERIAL OBTENER_MATERIAL(int CODIGO)
        {
            return CASOS_DE_USO.MATERIALES.GESTION_MATERIALES.OBTENER_MATERIAL(CODIGO, oCONTEXTO);
        }

        public List<MODELO.MATERIAL> OBTENER_MATERIALES()
        {
            return CASOS_DE_USO.MATERIALES.GESTION_MATERIALES.OBTENER_MATERIALES(oCONTEXTO);
        }
    }
}
