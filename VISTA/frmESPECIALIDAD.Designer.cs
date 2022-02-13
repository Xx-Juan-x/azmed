
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
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.gbLISTA_ESPECIALIDADES = new System.Windows.Forms.GroupBox();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.dgvLISTA_ESPECIALIDADES = new System.Windows.Forms.DataGridView();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.gbDATOS_ESPECIALIDAD.SuspendLayout();
            this.gbLISTA_ESPECIALIDADES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ESPECIALIDADES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_ESPECIALIDAD
            // 
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.lbl_NOMBRE);
            this.gbDATOS_ESPECIALIDAD.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_ESPECIALIDAD.Location = new System.Drawing.Point(614, 12);
            this.gbDATOS_ESPECIALIDAD.Name = "gbDATOS_ESPECIALIDAD";
            this.gbDATOS_ESPECIALIDAD.Size = new System.Drawing.Size(215, 112);
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
            this.btnCANCELAR.Location = new System.Drawing.Point(116, 80);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 80);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 54;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Location = new System.Drawing.Point(8, 33);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(57, 13);
            this.lbl_NOMBRE.TabIndex = 0;
            this.lbl_NOMBRE.Text = "NOMBRE:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(81, 30);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(123, 20);
            this.txtNOMBRE.TabIndex = 6;
            // 
            // gbLISTA_ESPECIALIDADES
            // 
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.dgvLISTA_ESPECIALIDADES);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_ESPECIALIDADES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_ESPECIALIDADES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_ESPECIALIDADES.Name = "gbLISTA_ESPECIALIDADES";
            this.gbLISTA_ESPECIALIDADES.Size = new System.Drawing.Size(596, 326);
            this.gbLISTA_ESPECIALIDADES.TabIndex = 57;
            this.gbLISTA_ESPECIALIDADES.TabStop = false;
            this.gbLISTA_ESPECIALIDADES.Text = "LISTA DE ESPECIALIDADES";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(192, 295);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(88, 23);
            this.btnCONSULTAR.TabIndex = 61;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // dgvLISTA_ESPECIALIDADES
            // 
            this.dgvLISTA_ESPECIALIDADES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_ESPECIALIDADES.Location = new System.Drawing.Point(6, 19);
            this.dgvLISTA_ESPECIALIDADES.Name = "dgvLISTA_ESPECIALIDADES";
            this.dgvLISTA_ESPECIALIDADES.Size = new System.Drawing.Size(584, 270);
            this.dgvLISTA_ESPECIALIDADES.TabIndex = 60;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(500, 295);
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
            this.btnELIMINAR.Location = new System.Drawing.Point(286, 295);
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(98, 295);
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
            this.btnAGREGAR.Location = new System.Drawing.Point(4, 295);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 48;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // frmESPECIALIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 341);
            this.Controls.Add(this.gbDATOS_ESPECIALIDAD);
            this.Controls.Add(this.gbLISTA_ESPECIALIDADES);
            this.Name = "frmESPECIALIDAD";
            this.Text = "ESPECIALIDADES";
            this.gbDATOS_ESPECIALIDAD.ResumeLayout(false);
            this.gbDATOS_ESPECIALIDAD.PerformLayout();
            this.gbLISTA_ESPECIALIDADES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_ESPECIALIDADES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_ESPECIALIDAD;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lbl_NOMBRE;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.GroupBox gbLISTA_ESPECIALIDADES;
        private System.Windows.Forms.DataGridView dgvLISTA_ESPECIALIDADES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONSULTAR;
    }
}