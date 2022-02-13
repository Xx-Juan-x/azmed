
namespace VISTA
{
    partial class frmREGISTRO_PROFESIONALES
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
            this.gbDATOS_PROFESIONAL = new System.Windows.Forms.GroupBox();
            this.lblESPECIALIDAD = new System.Windows.Forms.Label();
            this.cmbESPECIALIDADES = new System.Windows.Forms.ComboBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.gbLISTA_PROFESIONALES = new System.Windows.Forms.GroupBox();
            this.lblFILTRO_DNI = new System.Windows.Forms.Label();
            this.cmbFILTRO_DNI = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dgvLISTA_PROFESIONALES = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtMATRICULA = new System.Windows.Forms.TextBox();
            this.lblMATRICULA = new System.Windows.Forms.Label();
            this.lblAPELLIDO = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.gbDATOS_PROFESIONAL.SuspendLayout();
            this.gbLISTA_PROFESIONALES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_PROFESIONAL
            // 
            this.gbDATOS_PROFESIONAL.Controls.Add(this.lblDNI);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.lblAPELLIDO);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.lblMATRICULA);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.txtMATRICULA);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.txtDNI);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.txtAPELLIDO);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.lblNOMBRE);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.lblESPECIALIDAD);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.cmbESPECIALIDADES);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_PROFESIONAL.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_PROFESIONAL.Location = new System.Drawing.Point(647, 12);
            this.gbDATOS_PROFESIONAL.Name = "gbDATOS_PROFESIONAL";
            this.gbDATOS_PROFESIONAL.Size = new System.Drawing.Size(295, 403);
            this.gbDATOS_PROFESIONAL.TabIndex = 62;
            this.gbDATOS_PROFESIONAL.TabStop = false;
            this.gbDATOS_PROFESIONAL.Text = "DATOS DEL PROFESIONAL";
            // 
            // lblESPECIALIDAD
            // 
            this.lblESPECIALIDAD.AutoSize = true;
            this.lblESPECIALIDAD.Location = new System.Drawing.Point(6, 217);
            this.lblESPECIALIDAD.Name = "lblESPECIALIDAD";
            this.lblESPECIALIDAD.Size = new System.Drawing.Size(87, 13);
            this.lblESPECIALIDAD.TabIndex = 65;
            this.lblESPECIALIDAD.Text = "ESPECIALIDAD:";
            // 
            // cmbESPECIALIDADES
            // 
            this.cmbESPECIALIDADES.FormattingEnabled = true;
            this.cmbESPECIALIDADES.Location = new System.Drawing.Point(99, 214);
            this.cmbESPECIALIDADES.Name = "cmbESPECIALIDADES";
            this.cmbESPECIALIDADES.Size = new System.Drawing.Size(190, 21);
            this.cmbESPECIALIDADES.TabIndex = 64;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 374);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 55;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(201, 374);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 59;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            // 
            // gbLISTA_PROFESIONALES
            // 
            this.gbLISTA_PROFESIONALES.Controls.Add(this.lblFILTRO_DNI);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.cmbFILTRO_DNI);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.dgvLISTA_PROFESIONALES);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_PROFESIONALES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_PROFESIONALES.Name = "gbLISTA_PROFESIONALES";
            this.gbLISTA_PROFESIONALES.Size = new System.Drawing.Size(629, 403);
            this.gbLISTA_PROFESIONALES.TabIndex = 63;
            this.gbLISTA_PROFESIONALES.TabStop = false;
            this.gbLISTA_PROFESIONALES.Text = "LISTA DE PROFESIONALES";
            // 
            // lblFILTRO_DNI
            // 
            this.lblFILTRO_DNI.AutoSize = true;
            this.lblFILTRO_DNI.Location = new System.Drawing.Point(157, 29);
            this.lblFILTRO_DNI.Name = "lblFILTRO_DNI";
            this.lblFILTRO_DNI.Size = new System.Drawing.Size(29, 13);
            this.lblFILTRO_DNI.TabIndex = 67;
            this.lblFILTRO_DNI.Text = "DNI:";
            // 
            // cmbFILTRO_DNI
            // 
            this.cmbFILTRO_DNI.FormattingEnabled = true;
            this.cmbFILTRO_DNI.Location = new System.Drawing.Point(192, 26);
            this.cmbFILTRO_DNI.Name = "cmbFILTRO_DNI";
            this.cmbFILTRO_DNI.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_DNI.TabIndex = 67;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBUSCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(521, 18);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(102, 35);
            this.btnBUSCAR.TabIndex = 58;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // dgvLISTA_PROFESIONALES
            // 
            this.dgvLISTA_PROFESIONALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_PROFESIONALES.Location = new System.Drawing.Point(4, 59);
            this.dgvLISTA_PROFESIONALES.Name = "dgvLISTA_PROFESIONALES";
            this.dgvLISTA_PROFESIONALES.Size = new System.Drawing.Size(619, 309);
            this.dgvLISTA_PROFESIONALES.TabIndex = 56;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(192, 374);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(88, 23);
            this.btnCONSULTAR.TabIndex = 55;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(535, 374);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(88, 23);
            this.btnCERRAR.TabIndex = 52;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.Red;
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(286, 374);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(88, 23);
            this.btnELIMINAR.TabIndex = 51;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMODIFICAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMODIFICAR.ForeColor = System.Drawing.Color.White;
            this.btnMODIFICAR.Location = new System.Drawing.Point(98, 374);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(88, 23);
            this.btnMODIFICAR.TabIndex = 50;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAGREGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(4, 374);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 48;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(99, 73);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(190, 20);
            this.txtNOMBRE.TabIndex = 66;
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Location = new System.Drawing.Point(6, 76);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(57, 13);
            this.lblNOMBRE.TabIndex = 67;
            this.lblNOMBRE.Text = "NOMBRE:";
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(99, 116);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(190, 20);
            this.txtAPELLIDO.TabIndex = 68;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(99, 162);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(190, 20);
            this.txtDNI.TabIndex = 69;
            // 
            // txtMATRICULA
            // 
            this.txtMATRICULA.Location = new System.Drawing.Point(99, 33);
            this.txtMATRICULA.Name = "txtMATRICULA";
            this.txtMATRICULA.Size = new System.Drawing.Size(190, 20);
            this.txtMATRICULA.TabIndex = 70;
            // 
            // lblMATRICULA
            // 
            this.lblMATRICULA.AutoSize = true;
            this.lblMATRICULA.Location = new System.Drawing.Point(6, 36);
            this.lblMATRICULA.Name = "lblMATRICULA";
            this.lblMATRICULA.Size = new System.Drawing.Size(72, 13);
            this.lblMATRICULA.TabIndex = 71;
            this.lblMATRICULA.Text = "MATRICULA:";
            // 
            // lblAPELLIDO
            // 
            this.lblAPELLIDO.AutoSize = true;
            this.lblAPELLIDO.Location = new System.Drawing.Point(6, 119);
            this.lblAPELLIDO.Name = "lblAPELLIDO";
            this.lblAPELLIDO.Size = new System.Drawing.Size(62, 13);
            this.lblAPELLIDO.TabIndex = 72;
            this.lblAPELLIDO.Text = "APELLIDO:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 169);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 73;
            this.lblDNI.Text = "DNI:";
            // 
            // frmREGISTRO_PROFESIONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 420);
            this.Controls.Add(this.gbLISTA_PROFESIONALES);
            this.Controls.Add(this.gbDATOS_PROFESIONAL);
            this.Name = "frmREGISTRO_PROFESIONAL";
            this.Text = "REGISTRO DE PROFESIONALES";
            this.gbDATOS_PROFESIONAL.ResumeLayout(false);
            this.gbDATOS_PROFESIONAL.PerformLayout();
            this.gbLISTA_PROFESIONALES.ResumeLayout(false);
            this.gbLISTA_PROFESIONALES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_PROFESIONAL;
        private System.Windows.Forms.Label lblESPECIALIDAD;
        private System.Windows.Forms.ComboBox cmbESPECIALIDADES;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.GroupBox gbLISTA_PROFESIONALES;
        private System.Windows.Forms.Label lblFILTRO_DNI;
        private System.Windows.Forms.ComboBox cmbFILTRO_DNI;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.DataGridView dgvLISTA_PROFESIONALES;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.Label lblMATRICULA;
        private System.Windows.Forms.TextBox txtMATRICULA;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblAPELLIDO;
    }
}