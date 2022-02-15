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

        public static MODELO.USUARIO OBTENER_EMAIL(string EMAIL, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.USUARIOS.FirstOrDefault(_ => _.EMAIL == EMAIL);
  
        }

        public static MODELO.USUARIO OBTENER_CLAVE(string CLAVE, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.USUARIOS.FirstOrDefault(_ => _.CLAVE == CLAVE);
        }

        public static List<MODELO.USUARIO> OBTENER_USUARIOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.USUARIOS.ToList();
        }
    }
}
