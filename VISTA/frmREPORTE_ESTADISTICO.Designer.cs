
namespace VISTA
{
    partial class frmREPORTE_ESTADISTICO
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
            this.chartESPECIALIDAD_PROFESIONAL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCERRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartESPECIALIDAD_PROFESIONAL)).BeginInit();
            this.SuspendLayout();
            // 
            // chartESPECIALIDAD_PROFESIONAL
            // 
            this.chartESPECIALIDAD_PROFESIONAL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartESPECIALIDAD_PROFESIONAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.chartESPECIALIDAD_PROFESIONAL.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chartESPECIALIDAD_PROFESIONAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartESPECIALIDAD_PROFESIONAL.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartESPECIALIDAD_PROFESIONAL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartESPECIALIDAD_PROFESIONAL.Legends.Add(legend1);
            this.chartESPECIALIDAD_PROFESIONAL.Location = new System.Drawing.Point(12, 12);
            this.chartESPECIALIDAD_PROFESIONAL.Name = "chartESPECIALIDAD_PROFESIONAL";
            this.chartESPECIALIDAD_PROFESIONAL.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartESPECIALIDAD_PROFESIONAL.Size = new System.Drawing.Size(817, 365);
            this.chartESPECIALIDAD_PROFESIONAL.TabIndex = 0;
            this.chartESPECIALIDAD_PROFESIONAL.Text = "CANTIDAD DE PROFESIONALES";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(746, 383);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 13;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmREPORTE_ESTADISTICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(837, 425);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.chartESPECIALIDAD_PROFESIONAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmREPORTE_ESTADISTICO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANTIDAD DE PROFESIONALES POR ESPECIALIDAD";
            ((System.ComponentModel.ISupportInitialize)(this.chartESPECIALIDAD_PROFESIONAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartESPECIALIDAD_PROFESIONAL;
        private System.Windows.Forms.Button btnCERRAR;
    }
}