﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VISTA
{
    public partial class frmCLINICA : Form
    {      
        private CONTROLADORA.USUARIOS cUSUARIOS;

        //public static frmCLINICA MDI_CLINICA;

        //PATRON SINGLETON
        private static frmCLINICA instancia;

        public static frmCLINICA OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmCLINICA();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmCLINICA();
            }
            return instancia;
        }

        public frmCLINICA()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
        }

        private void registrarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LLAMO A MI FORMULARIO ESPECIALIDAD A PARTIR DEL PATRON SINGLETON
            frmESPECIALIDAD FORMULARIO_ESPECIALIDAD = frmESPECIALIDAD.OBTENER_INSTANCIA();
            // FUNCION PARA MOSTRAR EL FORMULARIO
            FORMULARIO_ESPECIALIDAD.Show();
        }

        private void registrarObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmOBRA_SOCIAL FORMULARIO_OBRA_SOCIAL = frmOBRA_SOCIAL.OBTENER_INSTANCIA();
            FORMULARIO_OBRA_SOCIAL.Show();
        }

        private void registrarPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPLAN FORMULARIO_PLAN = frmPLAN.OBTENER_INSTANCIA();
            FORMULARIO_PLAN.Show();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUSUARIOS FORMULARIO_USUARIO = frmUSUARIOS.OBTENER_INSTANCIA();
            FORMULARIO_USUARIO.Show();
        }

        private void frmCLINICA_Load(object sender, EventArgs e)
        {
            lblTIPO_USUARIO.Text = frmLOGIN.TIPO_USUARIO;
            switch (frmLOGIN.TIPO_USUARIO)
            {
                case "ADMINISTRADOR":
                    uSUARIOSToolStripMenuItem.Visible = true;
                    pACIENTESToolStripMenuItem.Visible = true;
                    pROFESIONALESToolStripMenuItem.Visible = true;
                    tURNOSToolStripMenuItem.Visible = true;
                    facturarPacienteToolStripMenuItem.Visible = true;
                    rEPORTESToolStripMenuItem.Visible = true;
                    break;
                case "PACIENTE":
                    uSUARIOSToolStripMenuItem.Visible = false;
                    pACIENTESToolStripMenuItem.Visible = false;
                    pROFESIONALESToolStripMenuItem.Visible = false;
                    tURNOSToolStripMenuItem.Visible = true;
                    facturarPacienteToolStripMenuItem.Visible = false;
                    cOMPRASToolStripMenuItem.Visible = false;
                    rEPORTESToolStripMenuItem.Visible = false;
                    break;
                case "PROFESIONAL":
                    uSUARIOSToolStripMenuItem.Visible = false;
                    pACIENTESToolStripMenuItem.Visible = false;
                    pROFESIONALESToolStripMenuItem.Visible = true;
                    registrarEspecialidadesToolStripMenuItem.Visible = false;
                    asignarProfesionalToolStripMenuItem.Visible = false;
                    tURNOSToolStripMenuItem.Visible = false;
                    cOMPRASToolStripMenuItem.Visible = false;
                    rEPORTESToolStripMenuItem.Visible = false;
                    break;
                case "JEFE DE COMPRAS":
                    uSUARIOSToolStripMenuItem.Visible = false;
                    pACIENTESToolStripMenuItem.Visible = false;
                    pROFESIONALESToolStripMenuItem.Visible = false;
                    tURNOSToolStripMenuItem.Visible = false;
                    cOMPRASToolStripMenuItem.Visible = true;
                    crearSolicitudDePedidoToolStripMenuItem.Visible = false;
                    rEPORTESToolStripMenuItem.Visible = false;
                    break;
                default:
                    MessageBox.Show("ROL no encontrado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }          
        }

        
    }
}
