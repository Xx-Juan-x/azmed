
namespace VISTA
{
    partial class frmESPECIALIDAD
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
            this.gbDATOS_ESPECIALIDAD = new System.Windows.Forms.GroupBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtID_ESPECIALIDAD = new System.Windows.Forms.TextBox();
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.lblCONTACTO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtPRECIO = new System.Windows.Forms.TextBox();
            this.gbLISTA_ESPECIALIDADES = new System.Windows.Forms.GroupBox();
            this.dgvLISTA_ESPECIALIDADES = new System.Windows.Forms.DataGridView();
            this.cmbFILTRAR = new System.Windows.Forms.ComboBox();
            this.txtFILTRADO = new System.Windows.Forms.TextBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.lblFILTRAR = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.gbDATOS_ESPECIALIDAD.SuspendLayout();
            this.gbLISTA_ESPECIALIDADES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ESPECIALIDADES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_ESPECIALIDAD
            // 
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.txtID_ESPECIALIDAD);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.lbl_NOMBRE);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.lblCONTACTO);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.txtPRECIO);
            this.gbDATOS_ESPECIALIDAD.Location = new System.Drawing.Point(1, 12);
            this.gbDATOS_ESPECIALIDAD.Name = "gbDATOS_ESPECIALIDAD";
            this.gbDATOS_ESPECIALIDAD.Size = new System.Drawing.Size(505, 94);
            this.gbDATOS_ESPECIALIDAD.TabIndex = 58;
            this.gbDATOS_ESPECIALIDAD.TabStop = false;
            this.gbDATOS_ESPECIALIDAD.Text = "ESPECIALIDAD";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(410, 65);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 58;
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
            this.btnGUARDAR.Location = new System.Drawing.Point(410, 36);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 54;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // txtID_ESPECIALIDAD
            // 
            this.txtID_ESPECIALIDAD.Location = new System.Drawing.Point(6, 16);
            this.txtID_ESPECIALIDAD.Name = "txtID_ESPECIALIDAD";
            this.txtID_ESPECIALIDAD.Size = new System.Drawing.Size(31, 20);
            this.txtID_ESPECIALIDAD.TabIndex = 57;
            this.txtID_ESPECIALIDAD.Visible = false;
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Location = new System.Drawing.Point(59, 22);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(57, 13);
            this.lbl_NOMBRE.TabIndex = 0;
            this.lbl_NOMBRE.Text = "NOMBRE:";
            // 
            // lblCONTACTO
            // 
            this.lblCONTACTO.AutoSize = true;
            this.lblCONTACTO.Location = new System.Drawing.Point(66, 48);
            this.lblCONTACTO.Name = "lblCONTACTO";
            this.lblCONTACTO.Size = new System.Drawing.Size(50, 13);
            this.lblCONTACTO.TabIndex = 4;
            this.lblCONTACTO.Text = "PRECIO:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(122, 19);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(142, 20);
            this.txtNOMBRE.TabIndex = 6;
            // 
            // txtPRECIO
            // 
            this.txtPRECIO.Location = new System.Drawing.Point(121, 45);
            this.txtPRECIO.Name = "txtPRECIO";
            this.txtPRECIO.Size = new System.Drawing.Size(143, 20);
            this.txtPRECIO.TabIndex = 9;
            // 
            // gbLISTA_ESPECIALIDADES
            // 
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.dgvLISTA_ESPECIALIDADES);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.cmbFILTRAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.txtFILTRADO);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.lblFILTRAR);
            this.gbLISTA_ESPECIALIDADES.Location = new System.Drawing.Point(1, 112);
            this.gbLISTA_ESPECIALIDADES.Name = "gbLISTA_ESPECIALIDADES";
            this.gbLISTA_ESPECIALIDADES.Size = new System.Drawing.Size(505, 308);
            this.gbLISTA_ESPECIALIDADES.TabIndex = 57;
            this.gbLISTA_ESPECIALIDADES.TabStop = false;
            this.gbLISTA_ESPECIALIDADES.Text = "LISTA DE ESPECIALIDADES";
            // 
            // dgvLISTA_ESPECIALIDADES
            // 
            this.dgvLISTA_ESPECIALIDADES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_ESPECIALIDADES.Location = new System.Drawing.Point(6, 45);
            this.dgvLISTA_ESPECIALIDADES.Name = "dgvLISTA_ESPECIALIDADES";
            this.dgvLISTA_ESPECIALIDADES.Size = new System.Drawing.Size(492, 228);
            this.dgvLISTA_ESPECIALIDADES.TabIndex = 60;
            // 
            // cmbFILTRAR
            // 
            this.cmbFILTRAR.FormattingEnabled = true;
            this.cmbFILTRAR.Location = new System.Drawing.Point(229, 18);
            this.cmbFILTRAR.Name = "cmbFILTRAR";
            this.cmbFILTRAR.Size = new System.Drawing.Size(121, 21);
            this.cmbFILTRAR.TabIndex = 59;
            // 
            // txtFILTRADO
            // 
            this.txtFILTRADO.Location = new System.Drawing.Point(356, 19);
            this.txtFILTRADO.Name = "txtFILTRADO";
            this.txtFILTRADO.Size = new System.Drawing.Size(142, 20);
            this.txtFILTRADO.TabIndex = 53;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(410, 279);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(88, 23);
            this.btnCERRAR.TabIndex = 52;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.Red;
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(194, 279);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(88, 23);
            this.btnELIMINAR.TabIndex = 51;
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(100, 279);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(88, 23);
            this.btnMODIFICAR.TabIndex = 50;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAGREGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 279);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 48;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // lblFILTRAR
            // 
            this.lblFILTRAR.AutoSize = true;
            this.lblFILTRAR.ForeColor = System.Drawing.Color.Black;
            this.lblFILTRAR.Location = new System.Drawing.Point(142, 22);
            this.lblFILTRAR.Name = "lblFILTRAR";
            this.lblFILTRAR.Size = new System.Drawing.Size(81, 13);
            this.lblFILTRAR.TabIndex = 19;
            this.lblFILTRAR.Text = "FILTRAR POR:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(288, 278);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(88, 23);
            this.btnCONSULTAR.TabIndex = 61;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // frmESPECIALIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 425);
            this.Controls.Add(this.gbDATOS_ESPECIALIDAD);
            this.Controls.Add(this.gbLISTA_ESPECIALIDADES);
            this.Name = "frmESPECIALIDAD";
            this.Text = "ESPECIALIDADES";
            this.gbDATOS_ESPECIALIDAD.ResumeLayout(false);
            this.gbDATOS_ESPECIALIDAD.PerformLayout();
            this.gbLISTA_ESPECIALIDADES.ResumeLayout(false);
            this.gbLISTA_ESPECIALIDADES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ESPECIALIDADES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_ESPECIALIDAD;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtID_ESPECIALIDAD;
        private System.Windows.Forms.Label lbl_NOMBRE;
        private System.Windows.Forms.Label lblCONTACTO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtPRECIO;
        private System.Windows.Forms.GroupBox gbLISTA_ESPECIALIDADES;
        private System.Windows.Forms.DataGridView dgvLISTA_ESPECIALIDADES;
        private System.Windows.Forms.ComboBox cmbFILTRAR;
        private System.Windows.Forms.TextBox txtFILTRADO;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Label lblFILTRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
    }
}