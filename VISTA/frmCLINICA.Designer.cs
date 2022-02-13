
namespace VISTA
{
    partial class frmCLINICA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnStripMENU_CLINICA = new System.Windows.Forms.MenuStrip();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarObrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESIONALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tURNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSolicitudDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaYReportesDePacientesRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaYReportesDeProfesionalesRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaYReportesDeTurnosSolicitadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaYReportesDeComprasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStripMENU_CLINICA.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStripMENU_CLINICA
            // 
            this.mnStripMENU_CLINICA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.pACIENTESToolStripMenuItem,
            this.pROFESIONALESToolStripMenuItem,
            this.tURNOSToolStripMenuItem,
            this.cOMPRASToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.mnStripMENU_CLINICA.Location = new System.Drawing.Point(0, 0);
            this.mnStripMENU_CLINICA.Name = "mnStripMENU_CLINICA";
            this.mnStripMENU_CLINICA.Size = new System.Drawing.Size(663, 24);
            this.mnStripMENU_CLINICA.TabIndex = 1;
            this.mnStripMENU_CLINICA.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem});
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearUsuariosToolStripMenuItem.Text = "Crear Usuarios";
            // 
            // pACIENTESToolStripMenuItem
            // 
            this.pACIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacientesToolStripMenuItem,
            this.registrarPlanesToolStripMenuItem,
            this.registrarObrasSocialesToolStripMenuItem,
            this.facturarPacientesToolStripMenuItem});
            this.pACIENTESToolStripMenuItem.Name = "pACIENTESToolStripMenuItem";
            this.pACIENTESToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pACIENTESToolStripMenuItem.Text = "PACIENTES";
            // 
            // registrarPacientesToolStripMenuItem
            // 
            this.registrarPacientesToolStripMenuItem.Name = "registrarPacientesToolStripMenuItem";
            this.registrarPacientesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registrarPacientesToolStripMenuItem.Text = "Registrar Pacientes";
            // 
            // registrarPlanesToolStripMenuItem
            // 
            this.registrarPlanesToolStripMenuItem.Name = "registrarPlanesToolStripMenuItem";
            this.registrarPlanesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registrarPlanesToolStripMenuItem.Text = "Registrar Planes";
            this.registrarPlanesToolStripMenuItem.Click += new System.EventHandler(this.registrarPlanesToolStripMenuItem_Click);
            // 
            // registrarObrasSocialesToolStripMenuItem
            // 
            this.registrarObrasSocialesToolStripMenuItem.Name = "registrarObrasSocialesToolStripMenuItem";
            this.registrarObrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registrarObrasSocialesToolStripMenuItem.Text = "Registrar Obras Sociales";
            this.registrarObrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.registrarObrasSocialesToolStripMenuItem_Click);
            // 
            // facturarPacientesToolStripMenuItem
            // 
            this.facturarPacientesToolStripMenuItem.Name = "facturarPacientesToolStripMenuItem";
            this.facturarPacientesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.facturarPacientesToolStripMenuItem.Text = "Facturar Pacientes";
            // 
            // pROFESIONALESToolStripMenuItem
            // 
            this.pROFESIONALESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProfesionalesToolStripMenuItem,
            this.registrarEspecialidadesToolStripMenuItem,
            this.crearToolStripMenuItem});
            this.pROFESIONALESToolStripMenuItem.Name = "pROFESIONALESToolStripMenuItem";
            this.pROFESIONALESToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.pROFESIONALESToolStripMenuItem.Text = "PROFESIONALES";
            // 
            // registrarProfesionalesToolStripMenuItem
            // 
            this.registrarProfesionalesToolStripMenuItem.Name = "registrarProfesionalesToolStripMenuItem";
            this.registrarProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registrarProfesionalesToolStripMenuItem.Text = "Registrar Profesionales";
            // 
            // registrarEspecialidadesToolStripMenuItem
            // 
            this.registrarEspecialidadesToolStripMenuItem.Name = "registrarEspecialidadesToolStripMenuItem";
            this.registrarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registrarEspecialidadesToolStripMenuItem.Text = "Registrar Especialidad";
            this.registrarEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.registrarEspecialidadesToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.crearToolStripMenuItem.Text = "Crear Atención";
            // 
            // tURNOSToolStripMenuItem
            // 
            this.tURNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarTurnosToolStripMenuItem});
            this.tURNOSToolStripMenuItem.Name = "tURNOSToolStripMenuItem";
            this.tURNOSToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tURNOSToolStripMenuItem.Text = "TURNOS";
            // 
            // solicitarTurnosToolStripMenuItem
            // 
            this.solicitarTurnosToolStripMenuItem.Name = "solicitarTurnosToolStripMenuItem";
            this.solicitarTurnosToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.solicitarTurnosToolStripMenuItem.Text = "Solicitar y Asignar un Turno (Consulta-Estudio)";
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSolicitudDePedidoToolStripMenuItem,
            this.crearMaterialesToolStripMenuItem,
            this.registrarProveedoresToolStripMenuItem,
            this.crearCotizacionesToolStripMenuItem,
            this.crearOrdenDeCompraToolStripMenuItem});
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.cOMPRASToolStripMenuItem.Text = "COMPRAS";
            // 
            // crearSolicitudDePedidoToolStripMenuItem
            // 
            this.crearSolicitudDePedidoToolStripMenuItem.Name = "crearSolicitudDePedidoToolStripMenuItem";
            this.crearSolicitudDePedidoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.crearSolicitudDePedidoToolStripMenuItem.Text = "Crear Solicitud de Pedido";
            // 
            // crearMaterialesToolStripMenuItem
            // 
            this.crearMaterialesToolStripMenuItem.Name = "crearMaterialesToolStripMenuItem";
            this.crearMaterialesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.crearMaterialesToolStripMenuItem.Text = "Crear Materiales";
            // 
            // registrarProveedoresToolStripMenuItem
            // 
            this.registrarProveedoresToolStripMenuItem.Name = "registrarProveedoresToolStripMenuItem";
            this.registrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registrarProveedoresToolStripMenuItem.Text = "Registrar Proveedores";
            // 
            // crearCotizacionesToolStripMenuItem
            // 
            this.crearCotizacionesToolStripMenuItem.Name = "crearCotizacionesToolStripMenuItem";
            this.crearCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.crearCotizacionesToolStripMenuItem.Text = "Crear Cotizaciones";
            // 
            // crearOrdenDeCompraToolStripMenuItem
            // 
            this.crearOrdenDeCompraToolStripMenuItem.Name = "crearOrdenDeCompraToolStripMenuItem";
            this.crearOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.crearOrdenDeCompraToolStripMenuItem.Text = "Crear Orden de Compra";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaYReportesDePacientesRegistradosToolStripMenuItem,
            this.consultaYReportesDeProfesionalesRegistradosToolStripMenuItem,
            this.consultaYReportesDeTurnosSolicitadosToolStripMenuItem,
            this.consultaYReportesDeComprasRealizadasToolStripMenuItem});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // consultaYReportesDePacientesRegistradosToolStripMenuItem
            // 
            this.consultaYReportesDePacientesRegistradosToolStripMenuItem.Name = "consultaYReportesDePacientesRegistradosToolStripMenuItem";
            this.consultaYReportesDePacientesRegistradosToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.consultaYReportesDePacientesRegistradosToolStripMenuItem.Text = "Consulta y Reportes de Pacientes Registrados";
            // 
            // consultaYReportesDeProfesionalesRegistradosToolStripMenuItem
            // 
            this.consultaYReportesDeProfesionalesRegistradosToolStripMenuItem.Name = "consultaYReportesDeProfesionalesRegistradosToolStripMenuItem";
            this.consultaYReportesDeProfesionalesRegistradosToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.consultaYReportesDeProfesionalesRegistradosToolStripMenuItem.Text = "Consulta y Reportes de Profesionales Registrados";
            // 
            // consultaYReportesDeTurnosSolicitadosToolStripMenuItem
            // 
            this.consultaYReportesDeTurnosSolicitadosToolStripMenuItem.Name = "consultaYReportesDeTurnosSolicitadosToolStripMenuItem";
            this.consultaYReportesDeTurnosSolicitadosToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.consultaYReportesDeTurnosSolicitadosToolStripMenuItem.Text = "Consulta y Reportes de Turnos Solicitados";
            // 
            // consultaYReportesDeComprasRealizadasToolStripMenuItem
            // 
            this.consultaYReportesDeComprasRealizadasToolStripMenuItem.Name = "consultaYReportesDeComprasRealizadasToolStripMenuItem";
            this.consultaYReportesDeComprasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.consultaYReportesDeComprasRealizadasToolStripMenuItem.Text = "Consulta y Reportes de Compras Realizadas";
            // 
            // frmCLINICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 312);
            this.Controls.Add(this.mnStripMENU_CLINICA);
            this.Name = "frmCLINICA";
            this.Text = "CLINICA:: AZMED";
            this.mnStripMENU_CLINICA.ResumeLayout(false);
            this.mnStripMENU_CLINICA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStripMENU_CLINICA;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarObrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESIONALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tURNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSolicitudDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearOrdenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaYReportesDePacientesRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaYReportesDeProfesionalesRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaYReportesDeTurnosSolicitadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaYReportesDeComprasRealizadasToolStripMenuItem;
    }
}