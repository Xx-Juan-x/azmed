using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.USUARIOS
{
    public class OPERACIONES_USUARIOS
    {
        public static void AGREGAR_USUARIOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.USUARIO USUARIO)
        {
            AZMED_CLINICA.USUARIOS.Add(USUARIO);
        }

        public static void MODIFICAR_USUARIOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.USUARIO USUARIO)
        {
            AZMED_CLINICA.Entry(USUARIO).State = System.Data.Entity.EntityState.Modified;
        }

        public static void ELIMINAR_USUARIOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA, MODELO.USUARIO USUARIO)
        {
            AZMED_CLINICA.USUARIOS.Remove(USUARIO);
        }


    }
}
