using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.AUDITORIA
{
    public class GESTION_AUDITORIA
    {
        public static MODELO.AUDITORIA_LOGIN_LOGOUT OBTENER_AUDITORIA(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.AUDITORIA.FirstOrDefault(_ => _.ID_AUDITORIA == CODIGO);
        }

        public static List<MODELO.AUDITORIA_LOGIN_LOGOUT> OBTENER_AUDITORIAS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.AUDITORIA.ToList();
        }

        public static MODELO.AUDITORIA_USUARIO OBTENER_AUDITORIA_USUARIO(int CODIGO, CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.AUDITORIA_USUARIO.FirstOrDefault(_ => _.ID_AUDITORIA == CODIGO);
        }

        public static List<MODELO.AUDITORIA_USUARIO> OBTENER_AUDITORIA_USUARIOS(CONTEXTO.CLINICA_AZMED AZMED_CLINICA)
        {
            return AZMED_CLINICA.AUDITORIA_USUARIO.ToList();
        }

    }
}
