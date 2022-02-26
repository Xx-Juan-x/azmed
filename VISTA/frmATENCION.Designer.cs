
namespace VISTA
{
    partial class frmATENCION
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
            this.gbDATOS_PROFESIONAL_HORARIOS = new System.Windows.Forms.GroupBox();
            this.cmbPROFESIONALES = new System.Windows.Forms.ComboBox();
            this.lblPROFESIONAL = new System.Windows.Forms.Label();
            this.cmbESPECIALIDADES = new System.Windows.Forms.ComboBox();
            this.lblESPECIALIDAD = new System.Windows.Forms.Label();
            this.gbLISTA_HORARIOS_ATENCION = new System.Windows.Forms.GroupBox();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.lblFILTRO_DIA_LABORAL = new System.Windows.Forms.Label();
            this.cmbFILTRO_DIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dgvLISTA_ATENCIONES = new System.Windows.Forms.DataGridView();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.gbHORARIOS_ATENCION = new System.Windows.Forms.GroupBox();
            this.numericHORA_FIN = new System.Windows.Forms.NumericUpDown();
            this.cmbDIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.numericHORA_INICIO = new System.Windows.Forms.NumericUpDown();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HORA_INICIO = new System.Windows.Forms.Label();
            this.gbDATOS_PROFESIONAL_HORARIOS.SuspendLayout();
            this.gbLISTA_HORARIOS_ATENCION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).BeginInit();
            this.gbHORARIOS_ATENCION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_FIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_INICIO)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_PROFESIONAL_HORARIOS
            // 
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.cmbPROFESIONALES);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.lblPROFESIONAL);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.cmbESPECIALIDADES);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.lblESPECIALIDAD);
            this.gbDATOS_PROFESIONAL_HORARIOS.Location = new System.Drawing.Point(670, 12);
            this.gbDATOS_PROFESIONAL_HORARIOS.Name = "gbDATOS_PROFESIONAL_HORARIOS";
            this.gbDATOS_PROFESIONAL_HORARIOS.Size = new System.Drawing.Size(349, 109);
            this.gbDATOS_PROFESIONAL_HORARIOS.TabIndex = 74;
            this.gbDATOS_PROFESIONAL_HORARIOS.TabStop = false;
            this.gbDATOS_PROFESIONAL_HORARIOS.Text = "DATOS DEL PROFESIONAL";
            // 
            // cmbPROFESIONALES
            // 
            this.cmbPROFESIONALES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPROFESIONALES.FormattingEnabled = true;
            this.cmbPROFESIONALES.Location = new System.Drawing.Point(163, 74);
            this.cmbPROFESIONALES.Name = "cmbPROFESIONALES";
            this.cmbPROFESIONALES.Size = new System.Drawing.Size(178, 21);
            this.cmbPROFESIONALES.TabIndex = 78;
            this.cmbPROFESIONALES.SelectedIndexChanged += new System.EventHandler(this.cmbPROFESIONALES_SelectedIndexChanged);
            // 
            // lblPROFESIONAL
            // 
            this.lblPROFESIONAL.AutoSize = true;
            this.lblPROFESIONAL.Location = new System.Drawing.Point(6, 82);
            this.lblPROFESIONAL.Name = "lblPROFESIONAL";
            this.lblPROFESIONAL.Size = new System.Drawing.Size(85, 13);
            this.lblPROFESIONAL.TabIndex = 67;
            this.lblPROFESIONAL.Text = "PROFESIONAL:";
            // 
            // cmbESPECIALIDADES
            // 
            this.cmbESPECIALIDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESPECIALIDADES.FormattingEnabled = true;
            this.cmbESPECIALIDADES.Location = new System.Drawing.Point(163, 35);
            this.cmbESPECIALIDADES.Name = "cmbESPECIALIDADES";
            this.cmbESPECIALIDADES.Size = new System.Drawing.Size(178, 21);
            this.cmbESPECIALIDADES.TabIndex = 77;
            this.cmbESPECIALIDADES.SelectedIndexChanged += new System.EventHandler(this.cmbESPECIALIDADES_SelectedIndexChanged);
            // 
            // lblESPECIALIDAD
            // 
            this.lblESPECIALIDAD.AutoSize = true;
            this.lblESPECIALIDAD.Location = new System.Drawing.Point(6, 38);
            this.lblESPECIALIDAD.Name = "lblESPECIALIDAD";
            this.lblESPECIALIDAD.Size = new System.Drawing.Size(87, 13);
            this.lblESPECIALIDAD.TabIndex = 65;
            this.lblESPECIALIDAD.Text = "ESPECIALIDAD:";
            // 
            // gbLISTA_HORARIOS_ATENCION
            // 
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.lblFILTRO_DIA_LABORAL);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.cmbFILTRO_DIA_LABORAL);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.dgvLISTA_ATENCIONES);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnCERRAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_HORARIOS_ATENCION.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_HORARIOS_ATENCION.Name = "gbLISTA_HORARIOS_ATENCION";
            this.gbLISTA_HORARIOS_ATENCION.Size = new System.Drawing.Size(652, 515);
            this.gbLISTA_HORARIOS_ATENCION.TabIndex = 73;
            this.gbLISTA_HORARIOS_ATENCION.TabStop = false;
            this.gbLISTA_HORARIOS_ATENCION.Text = "LISTA DE HORARIOS DE ATENCION";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(192, 486);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(86, 23);
            this.btnCONSULTAR.TabIndex = 78;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.Red;
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(284, 486);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(88, 23);
            this.btnELIMINAR.TabIndex = 77;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMODIFICAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMODIFICAR.ForeColor = System.Drawing.Color.White;
            this.btnMODIFICAR.Location = new System.Drawing.Point(100, 486);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(86, 23);
            this.btnMODIFICAR.TabIndex = 68;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // lblFILTRO_DIA_LABORAL
            // 
            this.lblFILTRO_DIA_LABORAL.AutoSize = true;
            this.lblFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(219, 29);
            this.lblFILTRO_DIA_LABORAL.Name = "lblFILTRO_DIA_LABORAL";
            this.lblFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(154, 13);
            this.lblFILTRO_DIA_LABORAL.TabIndex = 67;
            this.lblFILTRO_DIA_LABORAL.Text = "FILTRAR POR DIA LABORAL:";
            // 
            // cmbFILTRO_DIA_LABORAL
            // 
            this.cmbFILTRO_DIA_LABORAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_DIA_LABORAL.FormattingEnabled = true;
            this.cmbFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(379, 26);
            this.cmbFILTRO_DIA_LABORAL.Name = "cmbFILTRO_DIA_LABORAL";
            this.cmbFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_DIA_LABORAL.TabIndex = 67;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBUSCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(544, 18);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(102, 35);
            this.btnBUSCAR.TabIndex = 58;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // dgvLISTA_ATENCIONES
            // 
            this.dgvLISTA_ATENCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_ATENCIONES.Location = new System.Drawing.Point(6, 59);
            this.dgvLISTA_ATENCIONES.Name = "dgvLISTA_ATENCIONES";
            this.dgvLISTA_ATENCIONES.Size = new System.Drawing.Size(640, 421);
            this.dgvLISTA_ATENCIONES.TabIndex = 56;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(558, 485);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(88, 23);
            this.btnCERRAR.TabIndex = 52;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAGREGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 486);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 48;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // gbHORARIOS_ATENCION
            // 
            this.gbHORARIOS_ATENCION.Controls.Add(this.numericHORA_FIN);
            this.gbHORARIOS_ATENCION.Controls.Add(this.cmbDIA_LABORAL);
            this.gbHORARIOS_ATENCION.Controls.Add(this.numericHORA_INICIO);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnCANCELAR);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnGUARDAR);
            this.gbHORARIOS_ATENCION.Controls.Add(this.label2);
            this.gbHORARIOS_ATENCION.Controls.Add(this.label1);
            this.gbHORARIOS_ATENCION.Controls.Add(this.HORA_INICIO);
            this.gbHORARIOS_ATENCION.Location = new System.Drawing.Point(670, 127);
            this.gbHORARIOS_ATENCION.Name = "gbHORARIOS_ATENCION";
            this.gbHORARIOS_ATENCION.Size = new System.Drawing.Size(349, 200);
            this.gbHORARIOS_ATENCION.TabIndex = 75;
            this.gbHORARIOS_ATENCION.TabStop = false;
            this.gbHORARIOS_ATENCION.Text = "HORARIOS DE ATENCION DEL PROFESIONAL";
            // 
            // numericHORA_FIN
            // 
            this.numericHORA_FIN.Location = new System.Drawing.Point(163, 80);
            this.numericHORA_FIN.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericHORA_FIN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHORA_FIN.Name = "numericHORA_FIN";
            this.numericHORA_FIN.Size = new System.Drawing.Size(178, 20);
            this.numericHORA_FIN.TabIndex = 77;
            this.numericHORA_FIN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbDIA_LABORAL
            // 
            this.cmbDIA_LABORAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDIA_LABORAL.FormattingEnabled = true;
            this.cmbDIA_LABORAL.Location = new System.Drawing.Point(163, 120);
            this.cmbDIA_LABORAL.Name = "cmbDIA_LABORAL";
            this.cmbDIA_LABORAL.Size = new System.Drawing.Size(178, 21);
            this.cmbDIA_LABORAL.TabIndex = 74;
            // 
            // numericHORA_INICIO
            // 
            this.numericHORA_INICIO.Location = new System.Drawing.Point(163, 36);
            this.numericHORA_INICIO.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericHORA_INICIO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHORA_INICIO.Name = "numericHORA_INICIO";
            this.numericHORA_INICIO.Size = new System.Drawing.Size(178, 20);
            this.numericHORA_INICIO.TabIndex = 76;
            this.numericHORA_INICIO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(255, 166);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 59;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 166);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 55;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "DIA LABORAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "HORA DE FIN:";
            // 
            // HORA_INICIO
            // 
            this.HORA_INICIO.AutoSize = true;
            this.HORA_INICIO.Location = new System.Drawing.Point(6, 38);
            this.HORA_INICIO.Name = "HORA_INICIO";
            this.HORA_INICIO.Size = new System.Drawing.Size(94, 13);
            this.HORA_INICIO.TabIndex = 65;
            this.HORA_INICIO.Text = "HORA DE INICIO:";
            // 
            // frmATENCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 532);
            this.Controls.Add(this.gbDATOS_PROFESIONAL_HORARIOS);
            this.Controls.Add(this.gbLISTA_HORARIOS_ATENCION);
            this.Controls.Add(this.gbHORARIOS_ATENCION);
            this.Name = "frmATENCION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIÓN DE ATENCIONES DE PROFESIONALES";
            this.gbDATOS_PROFESIONAL_HORARIOS.ResumeLayout(false);
            this.gbDATOS_PROFESIONAL_HORARIOS.PerformLayout();
            this.gbLISTA_HORARIOS_ATENCION.ResumeLayout(false);
            this.gbLISTA_HORARIOS_ATENCION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).EndInit();
            this.gbHORARIOS_ATENCION.ResumeLayout(false);
            this.gbHORARIOS_ATENCION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_FIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_INICIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_PROFESIONAL_HORARIOS;
        private System.Windows.Forms.Label lblPROFESIONAL;
        private System.Windows.Forms.Label lblESPECIALIDAD;
        private System.Windows.Forms.GroupBox gbLISTA_HORARIOS_ATENCION;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Label lblFILTRO_DIA_LABORAL;
        private System.Windows.Forms.ComboBox cmbFILTRO_DIA_LABORAL;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.DataGridView dgvLISTA_ATENCIONES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.GroupBox gbHORARIOS_ATENCION;
        private System.Windows.Forms.ComboBox cmbDIA_LABORAL;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HORA_INICIO;
        private System.Windows.Forms.ComboBox cmbPROFESIONALES;
        private System.Windows.Forms.ComboBox cmbESPECIALIDADES;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.NumericUpDown numericHORA_FIN;
        private System.Windows.Forms.NumericUpDown numericHORA_INICIO;
        private System.Windows.Forms.Button btnCONSULTAR;
    }
}