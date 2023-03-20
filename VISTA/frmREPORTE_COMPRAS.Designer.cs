
namespace VISTA
{
    partial class frmREPORTE_COMPRAS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_CANTIDAD_GASTOS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCERRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CANTIDAD_GASTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_CANTIDAD_GASTOS
            // 
            this.chart_CANTIDAD_GASTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_CANTIDAD_GASTOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.chart_CANTIDAD_GASTOS.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart_CANTIDAD_GASTOS.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart_CANTIDAD_GASTOS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_CANTIDAD_GASTOS.Legends.Add(legend1);
            this.chart_CANTIDAD_GASTOS.Location = new System.Drawing.Point(12, 12);
            this.chart_CANTIDAD_GASTOS.Name = "chart_CANTIDAD_GASTOS";
            this.chart_CANTIDAD_GASTOS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_CANTIDAD_GASTOS.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CANTIDAD DE GASTOS";
            this.chart_CANTIDAD_GASTOS.Series.Add(series1);
            this.chart_CANTIDAD_GASTOS.Size = new System.Drawing.Size(825, 390);
            this.chart_CANTIDAD_GASTOS.TabIndex = 1;
            this.chart_CANTIDAD_GASTOS.Text = "CANTIDAD DE GASTOS POR MES";
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "CANTIDAD DE GASTOS POR MES";
            title1.Text = "CANTIDAD DE GASTOS POR MES";
            this.chart_CANTIDAD_GASTOS.Titles.Add(title1);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(754, 408);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 15;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click_1);
            // 
            // frmREPORTE_COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.chart_CANTIDAD_GASTOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmREPORTE_COMPRAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE COMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.chart_CANTIDAD_GASTOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CANTIDAD_GASTOS;
        private System.Windows.Forms.Button btnCERRAR;
    }
}