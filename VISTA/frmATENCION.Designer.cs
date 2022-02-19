
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
            this.txtPROFESIONAL = new System.Windows.Forms.TextBox();
            this.txtESPECIALIDAD = new System.Windows.Forms.TextBox();
            this.lblPROFESIONAL = new System.Windows.Forms.Label();
            this.lblESPECIALIDAD = new System.Windows.Forms.Label();
            this.gbHORARIOS_ATENCION = new System.Windows.Forms.GroupBox();
            this.dgvLISTA_ATENCIONES = new System.Windows.Forms.DataGridView();
            this.dtpHORA_FIN = new System.Windows.Forms.DateTimePicker();
            this.dtpHORA_INICIO = new System.Windows.Forms.DateTimePicker();
            this.cmbDIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HORA_INICIO = new System.Windows.Forms.Label();
            this.gbLISTA_HORARIOS_ATENCION = new System.Windows.Forms.GroupBox();
            this.lblFILTRO_ESPECIALIDAD = new System.Windows.Forms.Label();
            this.cmbFILTRO_ESPECIALIDADES = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dgvLISTA_PROFESIONALES = new System.Windows.Forms.DataGridView();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.gbDATOS_PROFESIONAL_HORARIOS.SuspendLayout();
            this.gbHORARIOS_ATENCION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).BeginInit();
            this.gbLISTA_HORARIOS_ATENCION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_PROFESIONAL_HORARIOS
            // 
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.txtPROFESIONAL);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.txtESPECIALIDAD);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.lblPROFESIONAL);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.lblESPECIALIDAD);
            this.gbDATOS_PROFESIONAL_HORARIOS.Location = new System.Drawing.Point(588, 12);
            this.gbDATOS_PROFESIONAL_HORARIOS.Name = "gbDATOS_PROFESIONAL_HORARIOS";
            this.gbDATOS_PROFESIONAL_HORARIOS.Size = new System.Drawing.Size(349, 109);
            this.gbDATOS_PROFESIONAL_HORARIOS.TabIndex = 60;
            this.gbDATOS_PROFESIONAL_HORARIOS.TabStop = false;
            this.gbDATOS_PROFESIONAL_HORARIOS.Text = "DATOS DEL PROFESIONAL";
            // 
            // txtPROFESIONAL
            // 
            this.txtPROFESIONAL.Location = new System.Drawing.Point(163, 79);
            this.txtPROFESIONAL.Name = "txtPROFESIONAL";
            this.txtPROFESIONAL.Size = new System.Drawing.Size(178, 20);
            this.txtPROFESIONAL.TabIndex = 71;
            // 
            // txtESPECIALIDAD
            // 
            this.txtESPECIALIDAD.Location = new System.Drawing.Point(161, 35);
            this.txtESPECIALIDAD.Name = "txtESPECIALIDAD";
            this.txtESPECIALIDAD.Size = new System.Drawing.Size(180, 20);
            this.txtESPECIALIDAD.TabIndex = 70;
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
            // lblESPECIALIDAD
            // 
            this.lblESPECIALIDAD.AutoSize = true;
            this.lblESPECIALIDAD.Location = new System.Drawing.Point(6, 38);
            this.lblESPECIALIDAD.Name = "lblESPECIALIDAD";
            this.lblESPECIALIDAD.Size = new System.Drawing.Size(87, 13);
            this.lblESPECIALIDAD.TabIndex = 65;
            this.lblESPECIALIDAD.Text = "ESPECIALIDAD:";
            // 
            // gbHORARIOS_ATENCION
            // 
            this.gbHORARIOS_ATENCION.Controls.Add(this.dgvLISTA_ATENCIONES);
            this.gbHORARIOS_ATENCION.Controls.Add(this.dtpHORA_FIN);
            this.gbHORARIOS_ATENCION.Controls.Add(this.dtpHORA_INICIO);
            this.gbHORARIOS_ATENCION.Controls.Add(this.cmbDIA_LABORAL);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnELIMINAR);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnCANCELAR);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnGUARDAR);
            this.gbHORARIOS_ATENCION.Controls.Add(this.label2);
            this.gbHORARIOS_ATENCION.Controls.Add(this.label1);
            this.gbHORARIOS_ATENCION.Controls.Add(this.HORA_INICIO);
            this.gbHORARIOS_ATENCION.Location = new System.Drawing.Point(588, 127);
            this.gbHORARIOS_ATENCION.Name = "gbHORARIOS_ATENCION";
            this.gbHORARIOS_ATENCION.Size = new System.Drawing.Size(349, 394);
            this.gbHORARIOS_ATENCION.TabIndex = 69;
            this.gbHORARIOS_ATENCION.TabStop = false;
            this.gbHORARIOS_ATENCION.Text = "HORARIOS DE ATENCION DEL PROFESIONAL";
            // 
            // dgvLISTA_ATENCIONES
            // 
            this.dgvLISTA_ATENCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_ATENCIONES.Location = new System.Drawing.Point(9, 176);
            this.dgvLISTA_ATENCIONES.Name = "dgvLISTA_ATENCIONES";
            this.dgvLISTA_ATENCIONES.Size = new System.Drawing.Size(332, 178);
            this.dgvLISTA_ATENCIONES.TabIndex = 77;
            // 
            // dtpHORA_FIN
            // 
            this.dtpHORA_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHORA_FIN.Location = new System.Drawing.Point(163, 76);
            this.dtpHORA_FIN.Name = "dtpHORA_FIN";
            this.dtpHORA_FIN.ShowUpDown = true;
            this.dtpHORA_FIN.Size = new System.Drawing.Size(178, 20);
            this.dtpHORA_FIN.TabIndex = 76;
            // 
            // dtpHORA_INICIO
            // 
            this.dtpHORA_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHORA_INICIO.Location = new System.Drawing.Point(163, 31);
            this.dtpHORA_INICIO.Name = "dtpHORA_INICIO";
            this.dtpHORA_INICIO.ShowUpDown = true;
            this.dtpHORA_INICIO.Size = new System.Drawing.Size(178, 20);
            this.dtpHORA_INICIO.TabIndex = 75;
            // 
            // cmbDIA_LABORAL
            // 
            this.cmbDIA_LABORAL.FormattingEnabled = true;
            this.cmbDIA_LABORAL.Location = new System.Drawing.Point(163, 120);
            this.cmbDIA_LABORAL.Name = "cmbDIA_LABORAL";
            this.cmbDIA_LABORAL.Size = new System.Drawing.Size(178, 21);
            this.cmbDIA_LABORAL.TabIndex = 74;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.Red;
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(253, 147);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(88, 23);
            this.btnELIMINAR.TabIndex = 51;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(253, 360);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 59;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(9, 360);
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
            // gbLISTA_HORARIOS_ATENCION
            // 
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.lblFILTRO_ESPECIALIDAD);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.cmbFILTRO_ESPECIALIDADES);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.dgvLISTA_PROFESIONALES);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnCERRAR);
            this.gbLISTA_HORARIOS_ATENCION.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_HORARIOS_ATENCION.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_HORARIOS_ATENCION.Name = "gbLISTA_HORARIOS_ATENCION";
            this.gbLISTA_HORARIOS_ATENCION.Size = new System.Drawing.Size(570, 515);
            this.gbLISTA_HORARIOS_ATENCION.TabIndex = 59;
            this.gbLISTA_HORARIOS_ATENCION.TabStop = false;
            this.gbLISTA_HORARIOS_ATENCION.Text = "LISTA DE HORARIOS DE ATENCION";
            // 
            // lblFILTRO_ESPECIALIDAD
            // 
            this.lblFILTRO_ESPECIALIDAD.AutoSize = true;
            this.lblFILTRO_ESPECIALIDAD.Location = new System.Drawing.Point(6, 32);
            this.lblFILTRO_ESPECIALIDAD.Name = "lblFILTRO_ESPECIALIDAD";
            this.lblFILTRO_ESPECIALIDAD.Size = new System.Drawing.Size(101, 13);
            this.lblFILTRO_ESPECIALIDAD.TabIndex = 67;
            this.lblFILTRO_ESPECIALIDAD.Text = "ESPECIALIDADES:";
            // 
            // cmbFILTRO_ESPECIALIDADES
            // 
            this.cmbFILTRO_ESPECIALIDADES.FormattingEnabled = true;
            this.cmbFILTRO_ESPECIALIDADES.Location = new System.Drawing.Point(113, 29);
            this.cmbFILTRO_ESPECIALIDADES.Name = "cmbFILTRO_ESPECIALIDADES";
            this.cmbFILTRO_ESPECIALIDADES.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_ESPECIALIDADES.TabIndex = 67;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBUSCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(463, 18);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(102, 35);
            this.btnBUSCAR.TabIndex = 58;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // dgvLISTA_PROFESIONALES
            // 
            this.dgvLISTA_PROFESIONALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_PROFESIONALES.Location = new System.Drawing.Point(6, 59);
            this.dgvLISTA_PROFESIONALES.Name = "dgvLISTA_PROFESIONALES";
            this.dgvLISTA_PROFESIONALES.Size = new System.Drawing.Size(559, 421);
            this.dgvLISTA_PROFESIONALES.TabIndex = 56;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(477, 486);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(88, 23);
            this.btnCERRAR.TabIndex = 52;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
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
            // 
            // frmATENCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 533);
            this.Controls.Add(this.gbDATOS_PROFESIONAL_HORARIOS);
            this.Controls.Add(this.gbLISTA_HORARIOS_ATENCION);
            this.Controls.Add(this.gbHORARIOS_ATENCION);
            this.Name = "frmATENCION";
            this.Text = "GESTION DE HORARIOS DEL PROFESIONAL";
            this.gbDATOS_PROFESIONAL_HORARIOS.ResumeLayout(false);
            this.gbDATOS_PROFESIONAL_HORARIOS.PerformLayout();
            this.gbHORARIOS_ATENCION.ResumeLayout(false);
            this.gbHORARIOS_ATENCION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).EndInit();
            this.gbLISTA_HORARIOS_ATENCION.ResumeLayout(false);
            this.gbLISTA_HORARIOS_ATENCION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_PROFESIONAL_HORARIOS;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbLISTA_HORARIOS_ATENCION;
        private System.Windows.Forms.DataGridView dgvLISTA_PROFESIONALES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Label lblESPECIALIDAD;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.ComboBox cmbFILTRO_ESPECIALIDADES;
        private System.Windows.Forms.Label lblFILTRO_ESPECIALIDAD;
        private System.Windows.Forms.Label lblPROFESIONAL;
        private System.Windows.Forms.GroupBox gbHORARIOS_ATENCION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HORA_INICIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDIA_LABORAL;
        private System.Windows.Forms.DateTimePicker dtpHORA_INICIO;
        private System.Windows.Forms.DateTimePicker dtpHORA_FIN;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.TextBox txtPROFESIONAL;
        private System.Windows.Forms.TextBox txtESPECIALIDAD;
        private System.Windows.Forms.DataGridView dgvLISTA_ATENCIONES;
        private System.Windows.Forms.Button btnMODIFICAR;
    }
}