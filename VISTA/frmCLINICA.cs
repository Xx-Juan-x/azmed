using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms.DataVisualization.Charting;

namespace VISTA
{
    public partial class frmCLINICA : Form
    {      
        private CONTROLADORA.USUARIOS cUSUARIOS;
        private CONTROLADORA.LISTA_DE_PEDIDOS cLISTA_PEDIDOS;
        private CONTROLADORA.SOLICITUDES_DE_PEDIDOS cSOLICITUDES_PEDIDOS;
        private CONTROLADORA.ACCIONES_GRUPOS cACCIONES_GRUPOS ;
        private CONTROLADORA.AUDITORIAS cAUDITORIAS;
        private MODELO.AUDITORIA_LOGIN_LOGOUT oAUDITORIA;
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
            cLISTA_PEDIDOS = CONTROLADORA.LISTA_DE_PEDIDOS.OBTENER_INSTANCIA();
            cSOLICITUDES_PEDIDOS = CONTROLADORA.SOLICITUDES_DE_PEDIDOS.OBTENER_INSTANCIA();
            cACCIONES_GRUPOS = CONTROLADORA.ACCIONES_GRUPOS.OBTENER_INSTANCIA();
            cAUDITORIAS = CONTROLADORA.AUDITORIAS.OBTENER_INSTANCIA();
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

        
        private object GetValueByPropertyName<T>(T obj, string propertyName)
        {
            PropertyInfo propInfo = typeof(T).GetProperty(propertyName);

            return propInfo.GetValue(obj);
        }

        //PATRON COMPOSITE
        private void frmCLINICA_Load(object sender, EventArgs e)
        {
            lblTIPO_USUARIO.Text = frmLOGIN.TIPO_USUARIO;
            List<ToolStripMenuItem> tool_list = new List<ToolStripMenuItem>();
            tool_list.Add(uSUARIOSToolStripMenuItem);
            tool_list.Add(pACIENTESToolStripMenuItem);
            tool_list.Add(pROFESIONALESToolStripMenuItem);
            tool_list.Add(tURNOSToolStripMenuItem);
            tool_list.Add(SolicitarTurnoToolStripMenuItem);
            tool_list.Add(turnosToolStripMenuItem1);
            tool_list.Add(registrarMaterialesToolStripMenuItem);
            tool_list.Add(registrarProveedoresToolStripMenuItem);
            tool_list.Add(crearCotizacionesToolStripMenuItem);
            tool_list.Add(crearOrdenDeCompraToolStripMenuItem);
            tool_list.Add(turnosDeHoyToolStripMenuItem);
            tool_list.Add(cOMPRASToolStripMenuItem);
            tool_list.Add(crearSolicitudDePedidoToolStripMenuItem);
            tool_list.Add(rEPORTESToolStripMenuItem);
            tool_list.Add(horariosLaboralesToolStripMenuItem);
            tool_list.Add(registrarEspecialidadesToolStripMenuItem);
            tool_list.Add(registrarProfesionalesToolStripMenuItem);
            tool_list.Add(gestionarAtenciónToolStripMenuItem);
            tool_list.Add(facturarToolStripMenuItem);
            tool_list.Add(bACKUPToolStripMenuItem);

            foreach (ToolStripMenuItem itm in tool_list)
            {
                itm.Visible = false;
            }
            gbLISTA_SOLICITUDES_PEDIDOS.Visible = false;

            switch (frmLOGIN.TIPO_USUARIO)
            {
                case "ADMINISTRADOR":
                    var acciones_grupos = (from a in cACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS() where a.GRUPO_ID_GRUPO == 2 select a).ToList();
                    foreach(var item in acciones_grupos){
                        foreach(ToolStripMenuItem itm in tool_list)
                        {
                            if(itm.Name == item.ACCION.ACCION)
                            {
                                itm.Visible = true;
                            }
                            
                        }
                        if ("gbLISTA_SOLICITUDES_PEDIDOS" == item.ACCION.ACCION)
                        {
                            gbLISTA_SOLICITUDES_PEDIDOS.Visible = true;
                        }
                    }
                    
                    break;
                
                case "JEFE DE COMPRAS":
                    acciones_grupos = (from a in cACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS() where a.GRUPO_ID_GRUPO == 4 select a).ToList();
                    foreach (var item in acciones_grupos)
                    {
                        foreach (ToolStripMenuItem itm in tool_list)
                        {
                            if (itm.Name == item.ACCION.ACCION)
                            {
                                itm.Visible = true;
                            }

                        }
                        if ("gbLISTA_SOLICITUDES_PEDIDOS" == item.ACCION.ACCION)
                        {
                            gbLISTA_SOLICITUDES_PEDIDOS.Visible = true;
                        }
                    }
                    ARMA_LISTA_SOLICITUD_PEDIDO();                
                    break;

                case "PROFESIONAL":
                    acciones_grupos = (from a in cACCIONES_GRUPOS.OBTENER_ACCIONES_GRUPOS() where a.GRUPO_ID_GRUPO == 3 select a).ToList();
                    foreach (var item in acciones_grupos)
                    {
                        foreach (ToolStripMenuItem itm in tool_list)
                        {
                            if (itm.Name == item.ACCION.ACCION)
                            {
                                itm.Visible = true;
                            }

                        }
                        if ("gbLISTA_SOLICITUDES_PEDIDOS" == item.ACCION.ACCION)
                        {
                            gbLISTA_SOLICITUDES_PEDIDOS.Visible = true;
                        }
                    }
                    break;

                default:
                    MessageBox.Show("GRUPO no encontrado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ARMA_LISTA_SOLICITUD_PEDIDO()
        {
            picIMAGEN_CLINICA.Visible = false;
            gbLISTA_SOLICITUDES_PEDIDOS.Visible = true;
            dgvLISTA_SOLICITUD_PEDIDO.DataSource = null;
            dgvLISTA_SOLICITUD_PEDIDO.DataSource = cSOLICITUDES_PEDIDOS.OBTENER_SOLICITUDES_PEDIDOS();
        }

        private void gestionarAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmATENCION FORMULARIO_GESTIONAR_ATENCIONES = frmATENCION.OBTENER_INSTANCIA();
            FORMULARIO_GESTIONAR_ATENCIONES.Show();           
        }

        private void sALIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CIERRE_DE_SESION(frmLOGIN.ID_USUARIO.ToString());
            frmLOGIN FORMULARIO_LOGIN = frmLOGIN.OBTENER_INSTANCIA();
            FORMULARIO_LOGIN.Show();
            this.Close();
        }

        //AUDITORIA CIERRE DE SESION
        private void CIERRE_DE_SESION(string USUARIO)
        {
            
            var LOGIN_USUARIO = cUSUARIOS.OBTENER_USUARIOS().FirstOrDefault(u => u.ID_USUARIO == frmLOGIN.ID_USUARIO);
            if (LOGIN_USUARIO != null)
            {
                oAUDITORIA = new MODELO.AUDITORIA_LOGIN_LOGOUT();

                oAUDITORIA.USUARIO = LOGIN_USUARIO.EMAIL;
                oAUDITORIA.FECHA_HORA = DateTime.Now;
                oAUDITORIA.ACCION = "Cierre de Sesión";
                oAUDITORIA.DATOS_REGISTRADOS = "LOGOUT";

                cAUDITORIAS.AGREGAR_AUDITORIA(oAUDITORIA);
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTURNOS FORMULARIO_TURNOS_CONSULTA = frmTURNOS.OBTENER_INSTANCIA();
            FORMULARIO_TURNOS_CONSULTA.Show();
        }

        private void horariosLaboralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLISTA_HORARIOS_LABORALES FORMULARIO_HORARIO_LABORAL = frmLISTA_HORARIOS_LABORALES.OBTENER_INSTANCIA();
            FORMULARIO_HORARIO_LABORAL.Show();
        }

        private void consultaYReportesDeProfesionalesRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmREPORTE_ESTADISTICO FORMULARIO_CANTIDAD_PROFESIONAL = frmREPORTE_ESTADISTICO.OBTENER_INSTANCIA();
            FORMULARIO_CANTIDAD_PROFESIONAL.Show();
        }

        private void turnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLISTA_TURNOS_PROFESIONAL FORMULARIO_LISTA_TURNOS = frmLISTA_TURNOS_PROFESIONAL.OBTENER_INSTANCIA();
            FORMULARIO_LISTA_TURNOS.Show();
        }

        private void consultaYReportesDeTurnosSolicitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmREPORTE_CANTIDAD_TURNOS FORMULARIO_CANTIDAD_TURNOS = frmREPORTE_CANTIDAD_TURNOS.OBTENER_INSTANCIA();
            FORMULARIO_CANTIDAD_TURNOS.Show();
        }

        private void registrarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMATERIAL FORMULARIO_MATERIALES = frmMATERIAL.OBTENER_INSTANCIA();
            FORMULARIO_MATERIALES.Show();
        }

        private void registrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPROVEEDOR FORMULARIO_PROVEEDOR = frmPROVEEDOR.OBTENER_INSTANCIA();
            FORMULARIO_PROVEEDOR.Show();
        }

        private void crearSolicitudDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSOLICITAR_PEDIDO_INSUMO FORMULARIOS_SOLICITUD_PEDIDO = frmSOLICITAR_PEDIDO_INSUMO.OBTENER_INSTANCIA();
            FORMULARIOS_SOLICITUD_PEDIDO.Show();
        }

        private void crearCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCOTIZACION FORMULARIO_COTIZACION = frmCOTIZACION.OBTENER_INSTANCIA();
            FORMULARIO_COTIZACION.Show();
        }

        private void crearOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmORDEN_COMPRA FORMULARIO_ORDEN_COMPRA = frmORDEN_COMPRA.OBTENER_INSTANCIA();
            FORMULARIO_ORDEN_COMPRA.Show();
        }

        private void reportesDeComprasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmREPORTE_COMPRAS FORMULARIO_REPORTE_COMPRAS = frmREPORTE_COMPRAS.OBTENER_INSTANCIA();
            FORMULARIO_REPORTE_COMPRAS.Show();
        }

        private void reportesDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmREPORTE_MATERIALES FORMULARIO_REPORTE_MATERIALES = frmREPORTE_MATERIALES.OBTENER_INSTANCIA();
            FORMULARIO_REPORTE_MATERIALES.Show();
        }

        private void turnosDeHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLISTA_TURNOS_HOY FORMULARIO_TURNOS_HOY = frmLISTA_TURNOS_HOY.OBTENER_INSTANCIA();
            FORMULARIO_TURNOS_HOY.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFACTURACION_TURNOS FORMULARIO_FACTURACION = frmFACTURACION_TURNOS.OBTENER_INSTANCIA();
            FORMULARIO_FACTURACION.Show();
        }

        private void gestionarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRUPO FORMULARIO_GRUPO = frmGRUPO.OBTENER_INSTANCIA();
            FORMULARIO_GRUPO.Show();
        }

        private void registrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPACIENTES FORMULARIO_PACIENTE = frmPACIENTES.OBTENER_INSTANCIA();
            FORMULARIO_PACIENTE.Show();
        }

        private void registrarProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPROFESIONALES FORMULARIO_PROFESIONAL = frmPROFESIONALES.OBTENER_INSTANCIA();
            FORMULARIO_PROFESIONAL.Show();
        }

        private void gestionAccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmACCIONES ACCIONES = frmACCIONES.OBTENER_INSTANCIA();
            ACCIONES.Show();
        }

        private void realizarBackupDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBACKUP_RESTAURACION FORMULARIO_BACKUP = frmBACKUP_RESTAURACION.OBTENER_INSTANCIA();
            FORMULARIO_BACKUP.Show();
        }

        private void auditorialoginlogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAUDITORIA_LOGIN_LOGOUT FORMULARIO_AUDITORIA = frmAUDITORIA_LOGIN_LOGOUT.OBTENER_INSTANCIA();
            FORMULARIO_AUDITORIA.Show();
        }

        private void auditoriaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAUDITORIA_USUARIO FORMULARIO_AUDITORIA_USUARIO = frmAUDITORIA_USUARIO.OBTENER_INSTANCIA();
            FORMULARIO_AUDITORIA_USUARIO.Show();
        }
    }
}
