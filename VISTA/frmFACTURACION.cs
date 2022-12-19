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

        public string firstLU(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToLower();
        }

        private void btnEXPORTAR_PDF_Click(object sender, EventArgs e)
        {
            if (dgvLISTA_TURNOS_HOY_FACTURAR.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista para poder facturar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS_HOY_FACTURAR.CurrentRow.DataBoundItem;

            if (oTURNO.ESTADO == "TOMADO")
            {
                using (PdfDocument doc = new PdfDocument())
                {
                    oTURNO = (MODELO.TURNO)dgvLISTA_TURNOS_HOY_FACTURAR.CurrentRow.DataBoundItem;
                    //Create a new PDF document.
                    doc.PageSettings.Margins.Left = 0;
                    doc.PageSettings.Margins.Right = 0;
                    doc.PageSettings.Margins.Bottom = 0;
                    //Add a page.
                    PdfPage page = doc.Pages.Add();


                    /*-----IMAGEN-----*/
                    PdfGraphics graphics = page.Graphics;
                    //Load the image from the disk.
                    PdfBitmap image = new PdfBitmap("../../Resources/AZMEDLogo.jpg");
                    //Draw the image
                    graphics.DrawImage(image, 0, 0);

                    //Set the standard font.
                    PdfGraphics graphicsTitulo = page.Graphics;
                    PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 28, PdfFontStyle.Bold);
                    graphics.DrawString("FACTURA", font, PdfBrushes.DarkGray, new PointF(45, 100));
                    /*-----TABLA HEADER-----*/
                    //Create a PdfGrid.
                    Syncfusion.Pdf.Grid.PdfGrid pdfGrid_header = new Syncfusion.Pdf.Grid.PdfGrid();
                    //Create a DataTable.
                    DataTable dataTable_header = new DataTable();
                    dataTable_header.Columns.Add("INFORMACION DEL PACIENTE");
                    dataTable_header.Columns.Add(" ");
                    dataTable_header.Columns.Add("INFORMACION DEL PROFESIONAL");

                    dataTable_header.Rows.Add(new object[] { firstLU(oTURNO.PACIENTE.NOMBRE) + " " + firstLU(oTURNO.PACIENTE.APELLIDO), "", firstLU(oTURNO.PROFESIONAL.NOMBRE) });
                    dataTable_header.Rows.Add(new object[] { oTURNO.PACIENTE.EMAIL.ToLower(), "", oTURNO.PROFESIONAL.EMAIL.ToLower() });
                    dataTable_header.Rows.Add(new object[] { firstLU(oTURNO.PACIENTE.PLAN.NOMBRE), "", firstLU(oTURNO.PROFESIONAL.ESPECIALIDADES.NOMBRE) });
                    pdfGrid_header.DataSource = dataTable_header;
                    //Add layout format for grid pagination
                    Syncfusion.Pdf.Grid.PdfGridLayoutFormat layoutFormat = new Syncfusion.Pdf.Grid.PdfGridLayoutFormat();
                    layoutFormat.Layout = PdfLayoutType.Paginate;

                    Syncfusion.Pdf.Grid.PdfGridCellStyle cellStyle = new Syncfusion.Pdf.Grid.PdfGridCellStyle();
                    Syncfusion.Pdf.Grid.PdfGridCellStyle cellStyle_border = new Syncfusion.Pdf.Grid.PdfGridCellStyle();
                    Syncfusion.Pdf.Grid.PdfGridCellStyle cellStyle_header = new Syncfusion.Pdf.Grid.PdfGridCellStyle();
                    //Set borders.
                    PdfBorders borders = new PdfBorders();
                    borders.Left = PdfPens.Transparent;
                    borders.Top = PdfPens.Transparent;
                    borders.Right = PdfPens.Transparent;
                    borders.Bottom = PdfPens.Transparent;
                    PdfBorders borders_azul = new PdfBorders();
                    borders_azul.Left = PdfPens.DeepSkyBlue;
                    borders_azul.Top = PdfPens.Transparent;
                    borders_azul.Right = PdfPens.Transparent;
                    borders_azul.Bottom = PdfPens.Transparent;
                    PdfBorders borders_bottom = new PdfBorders();
                    borders_bottom.Left = PdfPens.Transparent;
                    borders_bottom.Top = PdfPens.Transparent;
                    borders_bottom.Right = PdfPens.Transparent;
                    borders_bottom.Bottom = PdfPens.DeepSkyBlue;
                    PdfBorders borders_top = new PdfBorders();
                    borders_top.Left = PdfPens.Transparent;
                    borders_top.Top = PdfPens.DeepSkyBlue;
                    borders_top.Right = PdfPens.Transparent;
                    borders_top.Bottom = PdfPens.Transparent;
                    cellStyle_border.Borders = borders_azul;
                    cellStyle_border.CellPadding = new PdfPaddings(5, 5, 5, 5);
                    cellStyle_border.BackgroundBrush = PdfBrushes.Transparent;

                    cellStyle.Borders = borders;
                    cellStyle.BackgroundBrush = PdfBrushes.Transparent;
                    cellStyle.CellPadding = new PdfPaddings(5, 5, 5, 5);

                    cellStyle_header.Borders = borders_azul;
                    cellStyle_header.BackgroundBrush = PdfBrushes.Transparent;
                    cellStyle_header.CellPadding = new PdfPaddings(5, 5, 5, 5);
                    cellStyle_header.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
                    cellStyle_header.TextBrush = PdfBrushes.DeepSkyBlue;
                    //Create an instance of PdfGridRowStyle 
                    Syncfusion.Pdf.Grid.PdfGridRowStyle pdfGridRowStyle = new Syncfusion.Pdf.Grid.PdfGridRowStyle();
                    pdfGridRowStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);

                    pdfGrid_header.Headers[0].Cells[0].Style = cellStyle_header;
                    pdfGrid_header.Headers[0].Cells[1].Style = cellStyle;
                    pdfGrid_header.Headers[0].Cells[2].Style = cellStyle_header;
                    //Set style for the PdfGridRow 
                    pdfGrid_header.Rows[0].Style = pdfGridRowStyle;
                    pdfGrid_header.Rows[1].Style = pdfGridRowStyle;
                    pdfGrid_header.Rows[2].Style = pdfGridRowStyle;

                    //Applying style to grid
                    pdfGrid_header.Rows[0].Cells[0].Style = cellStyle_border;
                    pdfGrid_header.Rows[0].Cells[1].Style = cellStyle;
                    pdfGrid_header.Rows[0].Cells[2].Style = cellStyle_border;
                    pdfGrid_header.Rows[1].Cells[0].Style = cellStyle_border;
                    pdfGrid_header.Rows[1].Cells[1].Style = cellStyle;
                    pdfGrid_header.Rows[1].Cells[2].Style = cellStyle_border;
                    pdfGrid_header.Rows[2].Cells[0].Style = cellStyle_border;
                    pdfGrid_header.Rows[2].Cells[1].Style = cellStyle;
                    pdfGrid_header.Rows[2].Cells[2].Style = cellStyle_border;
                    pdfGrid_header.Style.BackgroundBrush = PdfBrushes.Transparent;
                    //Draw grid to the page of PDF document
                    PdfLayoutResult result = pdfGrid_header.Draw(page, new PointF(50, 160), layoutFormat);

                    /*-----TABLA INVOICE usuario-----*/
                    Syncfusion.Pdf.Grid.PdfGrid pdfGrid_invoice = new Syncfusion.Pdf.Grid.PdfGrid();
                    DataTable dataTable_invoice = new DataTable();

                    dataTable_invoice.Columns.Add("NUMERO DEL TURNO");
                    dataTable_invoice.Columns.Add("FECHA");
                    dataTable_invoice.Columns.Add("HORA");
                    dataTable_invoice.Columns.Add("PRECIO");

                    dataTable_invoice.Rows.Add(new object[] { oTURNO.ID_TURNO, (oTURNO.FECHA.Day + "/" + oTURNO.FECHA.Month + "/" + oTURNO.FECHA.Year), oTURNO.HORA_TURNO, "$" + oTURNO.PRECIO + ",00" });
                    Syncfusion.Pdf.Grid.PdfGridCellStyle cellStyle_invoice = new Syncfusion.Pdf.Grid.PdfGridCellStyle();
                    cellStyle_invoice.Borders = borders_top;
                    cellStyle_invoice.BackgroundBrush = PdfBrushes.Transparent;
                    cellStyle_invoice.CellPadding = new PdfPaddings(5, 5, 25, 5);
                    cellStyle_invoice.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Regular);

                    Syncfusion.Pdf.Grid.PdfGridCellStyle cellStyle_invoice_data = new Syncfusion.Pdf.Grid.PdfGridCellStyle();
                    cellStyle_invoice_data.Borders = borders_bottom;
                    cellStyle_invoice_data.BackgroundBrush = PdfBrushes.Transparent;
                    cellStyle_invoice_data.CellPadding = new PdfPaddings(5, 5, 5, 30);
                    cellStyle_invoice_data.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);

                    pdfGrid_invoice.DataSource = dataTable_invoice;
                    pdfGrid_invoice.Headers[0].Cells[0].Style = cellStyle_invoice;
                    pdfGrid_invoice.Headers[0].Cells[1].Style = cellStyle_invoice;
                    pdfGrid_invoice.Headers[0].Cells[2].Style = cellStyle_invoice;
                    pdfGrid_invoice.Headers[0].Cells[3].Style = cellStyle_invoice;

                    pdfGrid_invoice.Rows[0].Cells[0].Style = cellStyle_invoice_data;
                    pdfGrid_invoice.Rows[0].Cells[1].Style = cellStyle_invoice_data;
                    pdfGrid_invoice.Rows[0].Cells[2].Style = cellStyle_invoice_data;
                    pdfGrid_invoice.Rows[0].Cells[3].Style = cellStyle_invoice_data;
                    pdfGrid_invoice.Draw(result.Page, new PointF(30, 370));

                    /*-----IMAGEN-----*/
                    PdfGraphics graphics_footer = page.Graphics;
                    //Load the image from the disk.
                    PdfBitmap image_footer = new PdfBitmap("../../Resources/azmed_footer.jpg");
                    //Draw the image
                    graphics.DrawImage(image_footer, 0, (Bottom - 30), (page.Graphics.ClientSize.Width), 100);

                    DateTime hoy = DateTime.Now;

                    //Save the document.
                    doc.Save("import/" + hoy.Day + "-" + hoy.Month + "-" + hoy.Year + "_" + oTURNO.PACIENTE.NOMBRE + " " + oTURNO.PACIENTE.APELLIDO + ".pdf");
                    //close the document
                    doc.Close(true);
                    MessageBox.Show("Su factura se ah creado correctamente, visite AZMED\azmedVISTA\binDebugimport", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oTURNO.ESTADO = "FACTURADO";
                }
            }
            else
            {
                MessageBox.Show("El turno no se encuentra tomado o ya está facturado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }   
    }
}
