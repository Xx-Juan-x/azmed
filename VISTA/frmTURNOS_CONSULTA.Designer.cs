﻿
namespace VISTA
{
    partial class frmTURNOS_CONSULTA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLISTA_ATENCIONES = new System.Windows.Forms.DataGridView();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_PROFESIONALES = new System.Windows.Forms.GroupBox();
            this.gbDATOS_PROFESIONAL_HORARIOS = new System.Windows.Forms.GroupBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.cmbPROFESIONALES = new System.Windows.Forms.ComboBox();
            this.lblPROFESIONAL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblESPECIALIDAD = new System.Windows.Forms.Label();
            this.gbHORARIOS_ATENCION = new System.Windows.Forms.GroupBox();
            this.numericHORA_FIN = new System.Windows.Forms.NumericUpDown();
            this.cmbDIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.numericHORA_INICIO = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HORA_INICIO = new System.Windows.Forms.Label();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.lblFILTRO_DIA_LABORAL = new System.Windows.Forms.Label();
            this.cmbFILTRO_DIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).BeginInit();
            this.gbLISTA_PROFESIONALES.SuspendLayout();
            this.gbDATOS_PROFESIONAL_HORARIOS.SuspendLayout();
            this.gbHORARIOS_ATENCION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_FIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_INICIO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLISTA_ATENCIONES
            // 
            this.dgvLISTA_ATENCIONES.AllowUserToAddRows = false;
            this.dgvLISTA_ATENCIONES.AllowUserToDeleteRows = false;
            this.dgvLISTA_ATENCIONES.AllowUserToResizeColumns = false;
            this.dgvLISTA_ATENCIONES.AllowUserToResizeRows = false;
            this.dgvLISTA_ATENCIONES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_ATENCIONES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_ATENCIONES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_ATENCIONES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_ATENCIONES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_ATENCIONES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_ATENCIONES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_ATENCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_ATENCIONES.EnableHeadersVisualStyles = false;
            this.dgvLISTA_ATENCIONES.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_ATENCIONES.Location = new System.Drawing.Point(5, 58);
            this.dgvLISTA_ATENCIONES.Name = "dgvLISTA_ATENCIONES";
            this.dgvLISTA_ATENCIONES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_ATENCIONES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_ATENCIONES.RowHeadersVisible = false;
            this.dgvLISTA_ATENCIONES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_ATENCIONES.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_ATENCIONES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_ATENCIONES.Size = new System.Drawing.Size(639, 297);
            this.dgvLISTA_ATENCIONES.TabIndex = 0;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGUARDAR.FlatAppearance.BorderSize = 0;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 149);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(100, 36);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            // 
            // gbLISTA_PROFESIONALES
            // 
            this.gbLISTA_PROFESIONALES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.lblFILTRO_DIA_LABORAL);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.cmbFILTRO_DIA_LABORAL);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.dgvLISTA_ATENCIONES);
            this.gbLISTA_PROFESIONALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_PROFESIONALES.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_PROFESIONALES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_PROFESIONALES.Name = "gbLISTA_PROFESIONALES";
            this.gbLISTA_PROFESIONALES.Size = new System.Drawing.Size(651, 397);
            this.gbLISTA_PROFESIONALES.TabIndex = 2;
            this.gbLISTA_PROFESIONALES.TabStop = false;
            this.gbLISTA_PROFESIONALES.Text = "LISTA DE PROFESIONALES";
            // 
            // gbDATOS_PROFESIONAL_HORARIOS
            // 
            this.gbDATOS_PROFESIONAL_HORARIOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.cmbPROFESIONALES);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.comboBox1);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.lblESPECIALIDAD);
            this.gbDATOS_PROFESIONAL_HORARIOS.Controls.Add(this.lblPROFESIONAL);
            this.gbDATOS_PROFESIONAL_HORARIOS.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_PROFESIONAL_HORARIOS.Location = new System.Drawing.Point(669, 12);
            this.gbDATOS_PROFESIONAL_HORARIOS.Name = "gbDATOS_PROFESIONAL_HORARIOS";
            this.gbDATOS_PROFESIONAL_HORARIOS.Size = new System.Drawing.Size(354, 105);
            this.gbDATOS_PROFESIONAL_HORARIOS.TabIndex = 3;
            this.gbDATOS_PROFESIONAL_HORARIOS.TabStop = false;
            this.gbDATOS_PROFESIONAL_HORARIOS.Text = "DATOS DEL PROFESIONAL";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCANCELAR.FlatAppearance.BorderSize = 0;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(245, 149);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(100, 36);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 361);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(83, 30);
            this.btnAGREGAR.TabIndex = 11;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(562, 361);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            // 
            // cmbPROFESIONALES
            // 
            this.cmbPROFESIONALES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPROFESIONALES.FormattingEnabled = true;
            this.cmbPROFESIONALES.Location = new System.Drawing.Point(167, 61);
            this.cmbPROFESIONALES.Name = "cmbPROFESIONALES";
            this.cmbPROFESIONALES.Size = new System.Drawing.Size(178, 21);
            this.cmbPROFESIONALES.TabIndex = 82;
            // 
            // lblPROFESIONAL
            // 
            this.lblPROFESIONAL.AutoSize = true;
            this.lblPROFESIONAL.Location = new System.Drawing.Point(10, 69);
            this.lblPROFESIONAL.Name = "lblPROFESIONAL";
            this.lblPROFESIONAL.Size = new System.Drawing.Size(85, 13);
            this.lblPROFESIONAL.TabIndex = 80;
            this.lblPROFESIONAL.Text = "PROFESIONAL:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 81;
            // 
            // lblESPECIALIDAD
            // 
            this.lblESPECIALIDAD.AutoSize = true;
            this.lblESPECIALIDAD.Location = new System.Drawing.Point(10, 25);
            this.lblESPECIALIDAD.Name = "lblESPECIALIDAD";
            this.lblESPECIALIDAD.Size = new System.Drawing.Size(87, 13);
            this.lblESPECIALIDAD.TabIndex = 79;
            this.lblESPECIALIDAD.Text = "ESPECIALIDAD:";
            // 
            // gbHORARIOS_ATENCION
            // 
            this.gbHORARIOS_ATENCION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHORARIOS_ATENCION.Controls.Add(this.numericHORA_FIN);
            this.gbHORARIOS_ATENCION.Controls.Add(this.cmbDIA_LABORAL);
            this.gbHORARIOS_ATENCION.Controls.Add(this.numericHORA_INICIO);
            this.gbHORARIOS_ATENCION.Controls.Add(this.label2);
            this.gbHORARIOS_ATENCION.Controls.Add(this.label1);
            this.gbHORARIOS_ATENCION.Controls.Add(this.HORA_INICIO);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnGUARDAR);
            this.gbHORARIOS_ATENCION.Controls.Add(this.btnCANCELAR);
            this.gbHORARIOS_ATENCION.ForeColor = System.Drawing.Color.White;
            this.gbHORARIOS_ATENCION.Location = new System.Drawing.Point(669, 123);
            this.gbHORARIOS_ATENCION.Name = "gbHORARIOS_ATENCION";
            this.gbHORARIOS_ATENCION.Size = new System.Drawing.Size(354, 192);
            this.gbHORARIOS_ATENCION.TabIndex = 83;
            this.gbHORARIOS_ATENCION.TabStop = false;
            this.gbHORARIOS_ATENCION.Text = "HORARIOS DE ATENCION DEL PROFESIONAL";
            // 
            // numericHORA_FIN
            // 
            this.numericHORA_FIN.Location = new System.Drawing.Point(167, 63);
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
            this.numericHORA_FIN.TabIndex = 83;
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
            this.cmbDIA_LABORAL.Location = new System.Drawing.Point(167, 103);
            this.cmbDIA_LABORAL.Name = "cmbDIA_LABORAL";
            this.cmbDIA_LABORAL.Size = new System.Drawing.Size(178, 21);
            this.cmbDIA_LABORAL.TabIndex = 81;
            // 
            // numericHORA_INICIO
            // 
            this.numericHORA_INICIO.Location = new System.Drawing.Point(167, 19);
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
            this.numericHORA_INICIO.TabIndex = 82;
            this.numericHORA_INICIO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "DIA LABORAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "HORA DE FIN:";
            // 
            // HORA_INICIO
            // 
            this.HORA_INICIO.AutoSize = true;
            this.HORA_INICIO.Location = new System.Drawing.Point(10, 21);
            this.HORA_INICIO.Name = "HORA_INICIO";
            this.HORA_INICIO.Size = new System.Drawing.Size(94, 13);
            this.HORA_INICIO.TabIndex = 78;
            this.HORA_INICIO.Text = "HORA DE INICIO:";
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnMODIFICAR.FlatAppearance.BorderSize = 0;
            this.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMODIFICAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMODIFICAR.ForeColor = System.Drawing.Color.White;
            this.btnMODIFICAR.Location = new System.Drawing.Point(94, 361);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(83, 30);
            this.btnMODIFICAR.TabIndex = 17;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCONSULTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCONSULTAR.FlatAppearance.BorderSize = 0;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(183, 361);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(83, 30);
            this.btnCONSULTAR.TabIndex = 18;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnELIMINAR.FlatAppearance.BorderSize = 0;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(272, 361);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(83, 30);
            this.btnELIMINAR.TabIndex = 19;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // lblFILTRO_DIA_LABORAL
            // 
            this.lblFILTRO_DIA_LABORAL.AutoSize = true;
            this.lblFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(219, 28);
            this.lblFILTRO_DIA_LABORAL.Name = "lblFILTRO_DIA_LABORAL";
            this.lblFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(154, 13);
            this.lblFILTRO_DIA_LABORAL.TabIndex = 84;
            this.lblFILTRO_DIA_LABORAL.Text = "FILTRAR POR DIA LABORAL:";
            // 
            // cmbFILTRO_DIA_LABORAL
            // 
            this.cmbFILTRO_DIA_LABORAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_DIA_LABORAL.FormattingEnabled = true;
            this.cmbFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(379, 25);
            this.cmbFILTRO_DIA_LABORAL.Name = "cmbFILTRO_DIA_LABORAL";
            this.cmbFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_DIA_LABORAL.TabIndex = 85;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBUSCAR.FlatAppearance.BorderSize = 0;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBUSCAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(544, 16);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(100, 36);
            this.btnBUSCAR.TabIndex = 84;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // frmTURNOS_CONSULTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1026, 413);
            this.Controls.Add(this.gbHORARIOS_ATENCION);
            this.Controls.Add(this.gbDATOS_PROFESIONAL_HORARIOS);
            this.Controls.Add(this.gbLISTA_PROFESIONALES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTURNOS_CONSULTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REALIZAR UNA CONSULTA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).EndInit();
            this.gbLISTA_PROFESIONALES.ResumeLayout(false);
            this.gbLISTA_PROFESIONALES.PerformLayout();
            this.gbDATOS_PROFESIONAL_HORARIOS.ResumeLayout(false);
            this.gbDATOS_PROFESIONAL_HORARIOS.PerformLayout();
            this.gbHORARIOS_ATENCION.ResumeLayout(false);
            this.gbHORARIOS_ATENCION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_FIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHORA_INICIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLISTA_ATENCIONES;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbLISTA_PROFESIONALES;
        private System.Windows.Forms.GroupBox gbDATOS_PROFESIONAL_HORARIOS;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.ComboBox cmbPROFESIONALES;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblESPECIALIDAD;
        private System.Windows.Forms.Label lblPROFESIONAL;
        private System.Windows.Forms.GroupBox gbHORARIOS_ATENCION;
        private System.Windows.Forms.NumericUpDown numericHORA_FIN;
        private System.Windows.Forms.ComboBox cmbDIA_LABORAL;
        private System.Windows.Forms.NumericUpDown numericHORA_INICIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HORA_INICIO;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Label lblFILTRO_DIA_LABORAL;
        private System.Windows.Forms.ComboBox cmbFILTRO_DIA_LABORAL;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}