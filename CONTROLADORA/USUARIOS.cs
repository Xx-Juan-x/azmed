using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class USUARIOS
    {
        private static USUARIOS instancia;

        public static USUARIOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new USUARIOS();
            }
            return instancia;
        }

        CONTEXTO.CLINICA_AZMED oCONTEXTO;

        private USUARIOS()
        {
            oCONTEXTO = CONTEXTO.CLINICA_AZMED.OBTENER_INSTANCIA();
        }

        public void AGREGAR_USUARIO(MODELO.USUARIO USUARIO)
        {
            CASOS_DE_USO.USUARIOS.OPERACIONES_USUARIOS.AGREGAR_USUARIOS(oCONTEXTO, USUARIO);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_USUARIO(MODELO.USUARIO USUARIO)
        {
            CASOS_DE_USO.USUARIOS.OPERACIONES_USUARIOS.MODIFICAR_USUARIOS(oCONTEXTO, USUARIO);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_USUARIO(MODELO.USUARIO USUARIO)
        {
            CASOS_DE_USO.USUARIOS.OPERACIONES_USUARIOS.ELIMINAR_USUARIOS(oCONTEXTO, USUARIO);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.USUARIO OBTENER_USUARIO(int CODIGO)
        {
            return CASOS_DE_USO.USUARIOS.GESTION_USUARIOS.OBTENER_USUARIOS(CODIGO, oCONTEXTO);
        }   

        public List<MODELO.USUARIO> OBTENER_USUARIOS()
        {
            return CASOS_DE_USO.USUARIOS.GESTION_USUARIOS.OBTENER_USUARIOS(oCONTEXTO);
        }

        public List<MODELO.USUARIO> OBTENER_USUARIOS_TODOS()
        {
            return CASOS_DE_USO.USUARIOS.GESTION_USUARIOS.OBTENER_USUARIOS_TODOS(oCONTEXTO);
        }

        /*public List<MODELO.USUARIO> OBTENER_PROFESIONALES()
        {
            return CASOS_DE_USO.USUARIOS.GESTION_USUARIOS.OBTENER_PROFESIONALES(oCONTEXTO);
        }

        public List<MODELO.USUARIO> OBTENER_PACIENTES()
        {
            return CASOS_DE_USO.USUARIOS.GESTION_USUARIOS.OBTENER_PACIENTES(oCONTEXTO);
        }*/

        /*public int CANTIDAD_ESPECIALIDAD_PROFESIONAL(string ESP)
        {
            return CASOS_DE_USO.USUARIOS.GESTION_USUARIOS.CANTIDAD_PROFESIONALES_ESPECIALIDAD(ESP, oCONTEXTO);
        }*/
    }
}
