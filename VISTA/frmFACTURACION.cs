using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Compression;
using System.IO;

namespace VISTA
{
    public partial class frmFACTURACION_TURNOS : Form
    {
        private static frmFACTURACION_TURNOS instancia;

        public static frmFACTURACION_TURNOS OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new frmFACTURACION_TURNOS();
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmFACTURACION_TURNOS();
            }
            return instancia;
        }

        private CONTROLADORA.TURNOS cTURNOS;
        private CONTROLADORA.USUARIOS cUSUARIOS;
        private MODELO.TURNO oTURNO;

        public frmFACTURACION_TURNOS()
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.TURNOS.OBTENER_INSTANCIA();
            cUSUARIOS = CONTROLADORA.USUARIOS.OBTENER_INSTANCIA();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            DateTime DIA_ACTUAL = DateTime.Now;

            var LISTA_TURNOS_HOY_FACTURAR = (from a in cTURNOS.OBTENER_TURNOS()
                                             where a.FECHA.Date == DIA_ACTUAL.Date
                                             select a).ToList();

            dgvLISTA_TURNOS_HOY_FACTURAR.DataSource = null;
            dgvLISTA_TURNOS_HOY_FACTURAR.DataSource = LISTA_TURNOS_HOY_FACTURAR;

        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEXPORTAR_PDF_Click(object sender, EventArgs e)
        {
            using (PdfDocument doc = new PdfDocument())
            {
                oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS_HOY_FACTURAR.CurrentRow.DataBoundItem;
                //Create a new PDF document.

                //Add a page.
                PdfPage page = doc.Pages.Add();
                //Create a PdfGrid.
                Syncfusion.Pdf.Grid.PdfGrid pdfGrid = new Syncfusion.Pdf.Grid.PdfGrid();
                //Create a DataTable.
                DataTable dataTable_cliente = new DataTable();
                DataTable dataTable_detalles = new DataTable();
                DataTable dataTable_header = new DataTable();
                DataTable dataTable_invoice = new DataTable();

                /*-----IMAGEN-----*/
               
                /*-----TABLA HEADER-----*/
                dataTable_header.Columns.Add("INFORMACION DEL PACIENTE");
                dataTable_header.Columns.Add("");
                dataTable_header.Columns.Add("INFORMACION DEL PROFESIONAL");

                dataTable_header.Rows.Add(new object[] { oTURNO.PACIENTE.NOMBRE + " " + oTURNO.PACIENTE.APELLIDO, "", oTURNO.PROFESIONAL.NOMBRE });
                dataTable_header.Rows.Add(new object[] { oTURNO.PACIENTE.EMAIL, "", oTURNO.PROFESIONAL.EMAIL });
                dataTable_header.Rows.Add(new object[] { oTURNO.PACIENTE.PLAN.NOMBRE, "", oTURNO.PROFESIONAL.ESPECIALIDADES.NOMBRE });
                pdfGrid.DataSource = dataTable_detalles;

                /*-----TABLA INVOICE usuario-----*/
                dataTable_invoice.Columns.Add("NUMERO DEL TURNO");
                dataTable_invoice.Columns.Add("FECHA");
                dataTable_invoice.Columns.Add("HORA");
                dataTable_invoice.Columns.Add("PRECIO");
                dataTable_invoice.Rows.Add(new object[] { oTURNO.ID_TURNO, oTURNO.FECHA, oTURNO.HORA_TURNO, "$" + oTURNO.PRECIO + ",00" });
                pdfGrid.DataSource = dataTable_invoice;

                /*var LISTA_TURNOS_PACIENTE = (from a in cTURNOS.OBTENER_TURNOS()
                                             where a.PACIENTE.ID_USUARIO == oUSUARIO.ID_USUARIO
                                             select a).ToList();*/
                //Add columns to the DataTable
                dataTable_cliente.Columns.Add("PACIENTE");
                dataTable_cliente.Columns.Add("Email");
                dataTable_cliente.Columns.Add("Profesional");

                dataTable_cliente.Rows.Add(new object[] { oTURNO.PACIENTE.NOMBRE + " " + oTURNO.PACIENTE.APELLIDO, oTURNO.PACIENTE.EMAIL, oTURNO.PROFESIONAL.NOMBRE });
                pdfGrid.DataSource = dataTable_cliente;
                pdfGrid.Draw(page, new PointF(10, 10));
                /*-----TABLA Precio-----*/
                oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS_HOY_FACTURAR.CurrentRow.DataBoundItem;

                //Add columns to the DataTable
                dataTable_detalles.Columns.Add("#ITEM");
                dataTable_detalles.Columns.Add("DESCRIPCION");
                dataTable_detalles.Columns.Add("IMPORTE");
                //Add rows to the DataTable.
                dataTable_detalles.Rows.Add(new object[] { oTURNO.TIPO, oTURNO.PRECIO });
                //Assign data source.
                pdfGrid.DataSource = dataTable_detalles;
                //Draw grid to the page of PDF document.
                pdfGrid.Draw(page, new PointF(10, 10));
                //Save the document.
                doc.Save("import/Output.pdf");
                //close the document
                doc.Close(true);
            }
        }
    }
}
