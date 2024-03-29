﻿using System;
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

        // AUDITORIA DE LOGIN/LOGOUT
        public void AGREGAR_AUDITORIA(MODELO.AUDITORIA_LOGIN_LOGOUT AUDITORIA)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.AGREGAR_AUDITORIA(oCONTEXTO, AUDITORIA);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_AUDITORIA(MODELO.AUDITORIA_LOGIN_LOGOUT AUDITORIA)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.MODIFICAR_AUDITORIA(oCONTEXTO, AUDITORIA);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_AUDITORIA(MODELO.AUDITORIA_LOGIN_LOGOUT AUDITORIA)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.ELIMINAR_AUDITORIA(oCONTEXTO, AUDITORIA);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.AUDITORIA_LOGIN_LOGOUT OBTENER_AUDITORIA(int CODIGO)
        {
            return CASOS_DE_USO.AUDITORIA.GESTION_AUDITORIA.OBTENER_AUDITORIA(CODIGO, oCONTEXTO);
        }

        public List<MODELO.AUDITORIA_LOGIN_LOGOUT> OBTENER_AUDITORIAS()
        {
            return CASOS_DE_USO.AUDITORIA.GESTION_AUDITORIA.OBTENER_AUDITORIAS(oCONTEXTO);
        }

        // AUDITORIA DE USUARIO
        public void AGREGAR_AUDITORIA_USUARIO(MODELO.AUDITORIA_USUARIO AUDITORIA_USUARIO)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.AGREGAR_AUDITORIA_USUARIO(oCONTEXTO, AUDITORIA_USUARIO);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_AUDITORIA_USUARIO(MODELO.AUDITORIA_USUARIO AUDITORIA_USUARIO)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.MODIFICAR_AUDITORIA_USUARIO(oCONTEXTO, AUDITORIA_USUARIO);
            oCONTEXTO.SaveChanges();
        }

        public void ELIMINAR_AUDITORIA_USUARIO(MODELO.AUDITORIA_USUARIO AUDITORIA_USUARIO)
        {
            CASOS_DE_USO.AUDITORIA.OPERACIONES_AUDITORIA.ELIMINAR_AUDITORIA_USUARIO(oCONTEXTO, AUDITORIA_USUARIO);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.AUDITORIA_USUARIO OBTENER_AUDITORIA_USUARIO(int CODIGO)
        {
            return CASOS_DE_USO.AUDITORIA.GESTION_AUDITORIA.OBTENER_AUDITORIA_USUARIO(CODIGO, oCONTEXTO);
        }

        public List<MODELO.AUDITORIA_USUARIO> OBTENER_AUDITORIA_USUARIOS()
        {
            return CASOS_DE_USO.AUDITORIA.GESTION_AUDITORIA.OBTENER_AUDITORIA_USUARIOS(oCONTEXTO);
        }


    }
}
