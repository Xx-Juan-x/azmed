
namespace VISTA
{
    partial class frmPLAN
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
            this.gbDATOS_PLAN = new System.Windows.Forms.GroupBox();
            this.lblOBRA_SOCIAL = new System.Windows.Forms.Label();
            this.cmbOBRA_SOCIAL = new System.Windows.Forms.ComboBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.lblTIPO = new System.Windows.Forms.Label();
            this.txtTIPO_PLAN = new System.Windows.Forms.TextBox();
            this.gbLISTA_PLANES = new System.Windows.Forms.GroupBox();
            this.dgvLISTA_PLANES = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.cmbPLANES = new System.Windows.Forms.ComboBox();
            this.gbDATOS_PLAN.SuspendLayout();
            this.gbLISTA_PLANES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PLANES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_PLAN
            // 
            this.gbDATOS_PLAN.Controls.Add(this.cmbPLANES);
            this.gbDATOS_PLAN.Controls.Add(this.lblOBRA_SOCIAL);
            this.gbDATOS_PLAN.Controls.Add(this.cmbOBRA_SOCIAL);
            this.gbDATOS_PLAN.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_PLAN.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_PLAN.Controls.Add(this.lbl_NOMBRE);
            this.gbDATOS_PLAN.Controls.Add(this.lblTIPO);
            this.gbDATOS_PLAN.Controls.Add(this.txtTIPO_PLAN);
            this.gbDATOS_PLAN.Location = new System.Drawing.Point(612, 12);
            this.gbDATOS_PLAN.Name = "gbDATOS_PLAN";
            this.gbDATOS_PLAN.Size = new System.Drawing.Size(258, 369);
            this.gbDATOS_PLAN.TabIndex = 58;
            this.gbDATOS_PLAN.TabStop = false;
            this.gbDATOS_PLAN.Text = "DATOS DEL PLAN";
            // 
            // lblOBRA_SOCIAL
            // 
            this.lblOBRA_SOCIAL.AutoSize = true;
            this.lblOBRA_SOCIAL.Location = new System.Drawing.Point(6, 120);
            this.lblOBRA_SOCIAL.Name = "lblOBRA_SOCIAL";
            this.lblOBRA_SOCIAL.Size = new System.Drawing.Size(81, 13);
            this.lblOBRA_SOCIAL.TabIndex = 61;
            this.lblOBRA_SOCIAL.Text = "OBRA SOCIAL:";
            // 
            // cmbOBRA_SOCIAL
            // 
            this.cmbOBRA_SOCIAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOBRA_SOCIAL.FormattingEnabled = true;
            this.cmbOBRA_SOCIAL.Location = new System.Drawing.Point(93, 117);
            this.cmbOBRA_SOCIAL.Name = "cmbOBRA_SOCIAL";
            this.cmbOBRA_SOCIAL.Size = new System.Drawing.Size(159, 21);
            this.cmbOBRA_SOCIAL.TabIndex = 60;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(164, 333);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 334);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 55;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Location = new System.Drawing.Point(6, 43);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(38, 13);
            this.lbl_NOMBRE.TabIndex = 0;
            this.lbl_NOMBRE.Text = "PLAN:";
            // 
            // lblTIPO
            // 
            this.lblTIPO.AutoSize = true;
            this.lblTIPO.Location = new System.Drawing.Point(6, 80);
            this.lblTIPO.Name = "lblTIPO";
            this.lblTIPO.Size = new System.Drawing.Size(84, 13);
            this.lblTIPO.TabIndex = 3;
            this.lblTIPO.Text = "TIPO DE PLAN:";
            // 
            // txtTIPO_PLAN
            // 
            this.txtTIPO_PLAN.Location = new System.Drawing.Point(93, 77);
            this.txtTIPO_PLAN.Name = "txtTIPO_PLAN";
            this.txtTIPO_PLAN.Size = new System.Drawing.Size(159, 20);
            this.txtTIPO_PLAN.TabIndex = 8;
            // 
            // gbLISTA_PLANES
            // 
            this.gbLISTA_PLANES.Controls.Add(this.dgvLISTA_PLANES);
            this.gbLISTA_PLANES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_PLANES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_PLANES.Name = "gbLISTA_PLANES";
            this.gbLISTA_PLANES.Size = new System.Drawing.Size(594, 369);
            this.gbLISTA_PLANES.TabIndex = 57;
            this.gbLISTA_PLANES.TabStop = false;
            this.gbLISTA_PLANES.Text = "LISTA DE PLANES";
            // 
            // dgvLISTA_PLANES
            // 
            this.dgvLISTA_PLANES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_PLANES.Location = new System.Drawing.Point(6, 19);
            this.dgvLISTA_PLANES.Name = "dgvLISTA_PLANES";
            this.dgvLISTA_PLANES.Size = new System.Drawing.Size(582, 309);
            this.dgvLISTA_PLANES.TabIndex = 56;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(193, 334);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(88, 23);
            this.btnCONSULTAR.TabIndex = 55;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Red;
            this.btnCERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(499, 334);
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
            this.btnELIMINAR.Location = new System.Drawing.Point(287, 334);
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(99, 334);
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
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 334);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 48;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // cmbPLANES
            // 
            this.cmbPLANES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPLANES.FormattingEnabled = true;
            this.cmbPLANES.Location = new System.Drawing.Point(93, 40);
            this.cmbPLANES.Name = "cmbPLANES";
            this.cmbPLANES.Size = new System.Drawing.Size(159, 21);
            this.cmbPLANES.TabIndex = 62;
            // 
            // frmPLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 385);
            this.Controls.Add(this.gbDATOS_PLAN);
            this.Controls.Add(this.gbLISTA_PLANES);
            this.Name = "frmPLAN";
            this.Text = "PLANES";
            this.gbDATOS_PLAN.ResumeLayout(false);
            this.gbDATOS_PLAN.PerformLayout();
            this.gbLISTA_PLANES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PLANES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_PLAN;
        private System.Windows.Forms.ComboBox cmbOBRA_SOCIAL;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lbl_NOMBRE;
        private System.Windows.Forms.Label lblTIPO;
        private System.Windows.Forms.TextBox txtTIPO_PLAN;
        private System.Windows.Forms.GroupBox gbLISTA_PLANES;
        private System.Windows.Forms.DataGridView dgvLISTA_PLANES;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Label lblOBRA_SOCIAL;
        private System.Windows.Forms.ComboBox cmbPLANES;
    }
}