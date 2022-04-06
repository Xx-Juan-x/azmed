using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.USUARIOS
{
    public class GESTION_USUARIOS
    {
        public static MODELO.USUARIO OBTENER_USUARIOS(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.USUARIOS.FirstOrDefault(_ => _.ID_USUARIO == CODIGO);
        }     

        public static List<MODELO.USUARIO> OBTENER_USUARIOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {          
            return AZMED_CLINICA.USUARIOS.ToList();
        }       

        public static List<MODELO.USUARIO> OBTENER_PROFESIONALES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            List<MODELO.USUARIO> RESPUESTA = (from PROFESIONALES in AZMED_CLINICA.USUARIOS.Include("ESPECIALIDADES")
                                              where PROFESIONALES.TIPO == "PROFESIONAL"
                                              select PROFESIONALES).ToList();
            return RESPUESTA;
        }

        public static List<MODELO.USUARIO> OBTENER_PACIENTES(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            List<MODELO.USUARIO> RESPUESTA = (from PACIENTES in AZMED_CLINICA.USUARIOS.Include("OBRA_SOCIAL").Include("PLAN")
                                              where PACIENTES.TIPO == "PACIENTE"
                                              select PACIENTES).ToList();
            return RESPUESTA;
        }

        /*public static int CANTIDAD_PROFESIONALES_ESPECIALIDAD(string ESP, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            // c => c.TIPO es una expresión lambda que representa cada titular de las cuentas del banco
            return AZMED_CLINICA.USUARIOS.Count(c => c.ESPECIALIDADES.NOMBRE == ESP);
        }*/

    }
}
