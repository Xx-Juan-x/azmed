
namespace VISTA
{
    partial class frmTURNOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLISTA_ATENCIONES = new System.Windows.Forms.DataGridView();
            this.gbLISTA_PROFESIONALES = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.lblFILTRO_DIA_LABORAL = new System.Windows.Forms.Label();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.cmbFILTRO_DIA_LABORAL = new System.Windows.Forms.ComboBox();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.gbDATOS_TURNOS = new System.Windows.Forms.GroupBox();
            this.cmbDIA = new System.Windows.Forms.ComboBox();
            this.cmbESPECIALIDAD = new System.Windows.Forms.ComboBox();
            this.lblESPECIALIDAD = new System.Windows.Forms.Label();
            this.lblDIA = new System.Windows.Forms.Label();
            this.cmbHORAS = new System.Windows.Forms.ComboBox();
            this.lblHORAS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).BeginInit();
            this.gbLISTA_PROFESIONALES.SuspendLayout();
            this.gbDATOS_TURNOS.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_ATENCIONES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLISTA_ATENCIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_ATENCIONES.EnableHeadersVisualStyles = false;
            this.dgvLISTA_ATENCIONES.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_ATENCIONES.Location = new System.Drawing.Point(5, 58);
            this.dgvLISTA_ATENCIONES.Name = "dgvLISTA_ATENCIONES";
            this.dgvLISTA_ATENCIONES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_ATENCIONES.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLISTA_ATENCIONES.RowHeadersVisible = false;
            this.dgvLISTA_ATENCIONES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_ATENCIONES.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLISTA_ATENCIONES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_ATENCIONES.Size = new System.Drawing.Size(752, 297);
            this.dgvLISTA_ATENCIONES.TabIndex = 0;
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
            this.gbLISTA_PROFESIONALES.Size = new System.Drawing.Size(763, 397);
            this.gbLISTA_PROFESIONALES.TabIndex = 2;
            this.gbLISTA_PROFESIONALES.TabStop = false;
            this.gbLISTA_PROFESIONALES.Text = "LISTA DE PROFESIONALES";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBUSCAR.FlatAppearance.BorderSize = 0;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBUSCAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(656, 16);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(100, 36);
            this.btnBUSCAR.TabIndex = 84;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // lblFILTRO_DIA_LABORAL
            // 
            this.lblFILTRO_DIA_LABORAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFILTRO_DIA_LABORAL.AutoSize = true;
            this.lblFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(331, 28);
            this.lblFILTRO_DIA_LABORAL.Name = "lblFILTRO_DIA_LABORAL";
            this.lblFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(154, 13);
            this.lblFILTRO_DIA_LABORAL.TabIndex = 84;
            this.lblFILTRO_DIA_LABORAL.Text = "FILTRAR POR DIA LABORAL:";
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
            // cmbFILTRO_DIA_LABORAL
            // 
            this.cmbFILTRO_DIA_LABORAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFILTRO_DIA_LABORAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_DIA_LABORAL.FormattingEnabled = true;
            this.cmbFILTRO_DIA_LABORAL.Location = new System.Drawing.Point(491, 25);
            this.cmbFILTRO_DIA_LABORAL.Name = "cmbFILTRO_DIA_LABORAL";
            this.cmbFILTRO_DIA_LABORAL.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_DIA_LABORAL.TabIndex = 85;
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
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(674, 361);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
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
            // gbDATOS_TURNOS
            // 
            this.gbDATOS_TURNOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_TURNOS.Controls.Add(this.lblHORAS);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbHORAS);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbDIA);
            this.gbDATOS_TURNOS.Controls.Add(this.cmbESPECIALIDAD);
            this.gbDATOS_TURNOS.Controls.Add(this.lblESPECIALIDAD);
            this.gbDATOS_TURNOS.Controls.Add(this.lblDIA);
            this.gbDATOS_TURNOS.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_TURNOS.Location = new System.Drawing.Point(781, 12);
            this.gbDATOS_TURNOS.Name = "gbDATOS_TURNOS";
            this.gbDATOS_TURNOS.Size = new System.Drawing.Size(354, 175);
            this.gbDATOS_TURNOS.TabIndex = 5;
            this.gbDATOS_TURNOS.TabStop = false;
            this.gbDATOS_TURNOS.Text = "DATOS DEL TURNO";
            // 
            // cmbDIA
            // 
            this.cmbDIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDIA.FormattingEnabled = true;
            this.cmbDIA.Location = new System.Drawing.Point(167, 61);
            this.cmbDIA.Name = "cmbDIA";
            this.cmbDIA.Size = new System.Drawing.Size(178, 21);
            this.cmbDIA.TabIndex = 82;
            this.cmbDIA.SelectedIndexChanged += new System.EventHandler(this.cmbDIA_SelectedIndexChanged);
            // 
            // cmbESPECIALIDAD
            // 
            this.cmbESPECIALIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESPECIALIDAD.FormattingEnabled = true;
            this.cmbESPECIALIDAD.Location = new System.Drawing.Point(167, 22);
            this.cmbESPECIALIDAD.Name = "cmbESPECIALIDAD";
            this.cmbESPECIALIDAD.Size = new System.Drawing.Size(178, 21);
            this.cmbESPECIALIDAD.TabIndex = 81;
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
            // lblDIA
            // 
            this.lblDIA.AutoSize = true;
            this.lblDIA.Location = new System.Drawing.Point(10, 69);
            this.lblDIA.Name = "lblDIA";
            this.lblDIA.Size = new System.Drawing.Size(28, 13);
            this.lblDIA.TabIndex = 80;
            this.lblDIA.Text = "DIA:";
            // 
            // cmbHORAS
            // 
            this.cmbHORAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHORAS.FormattingEnabled = true;
            this.cmbHORAS.Location = new System.Drawing.Point(167, 102);
            this.cmbHORAS.Name = "cmbHORAS";
            this.cmbHORAS.Size = new System.Drawing.Size(178, 21);
            this.cmbHORAS.TabIndex = 83;
            // 
            // lblHORAS
            // 
            this.lblHORAS.AutoSize = true;
            this.lblHORAS.Location = new System.Drawing.Point(10, 110);
            this.lblHORAS.Name = "lblHORAS";
            this.lblHORAS.Size = new System.Drawing.Size(48, 13);
            this.lblHORAS.TabIndex = 84;
            this.lblHORAS.Text = "HORAS:";
            // 
            // frmTURNOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1155, 413);
            this.Controls.Add(this.gbDATOS_TURNOS);
            this.Controls.Add(this.gbLISTA_PROFESIONALES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTURNOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REALIZAR UNA CONSULTA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ATENCIONES)).EndInit();
            this.gbLISTA_PROFESIONALES.ResumeLayout(false);
            this.gbLISTA_PROFESIONALES.PerformLayout();
            this.gbDATOS_TURNOS.ResumeLayout(false);
            this.gbDATOS_TURNOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLISTA_ATENCIONES;
        private System.Windows.Forms.GroupBox gbLISTA_PROFESIONALES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Label lblFILTRO_DIA_LABORAL;
        private System.Windows.Forms.ComboBox cmbFILTRO_DIA_LABORAL;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.GroupBox gbDATOS_TURNOS;
        private System.Windows.Forms.Label lblHORAS;
        private System.Windows.Forms.ComboBox cmbHORAS;
        private System.Windows.Forms.ComboBox cmbDIA;
        private System.Windows.Forms.ComboBox cmbESPECIALIDAD;
        private System.Windows.Forms.Label lblESPECIALIDAD;
        private System.Windows.Forms.Label lblDIA;
    }
}