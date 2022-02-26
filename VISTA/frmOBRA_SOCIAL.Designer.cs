
namespace VISTA
{
    partial class frmOBRA_SOCIAL
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
            this.gbDATOS_OBRA_SOCIAL = new System.Windows.Forms.GroupBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.lblCONTACTO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.txtCONTACTO = new System.Windows.Forms.TextBox();
            this.gbLISTA_OBRAS_SOCIALES = new System.Windows.Forms.GroupBox();
            this.dgvLISTA_OBRAS_SOCIALES = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.gbDATOS_OBRA_SOCIAL.SuspendLayout();
            this.gbLISTA_OBRAS_SOCIALES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_OBRAS_SOCIALES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_OBRA_SOCIAL
            // 
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.lbl_NOMBRE);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.lblCUIL);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.lblCONTACTO);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.txtCUIL);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.txtCONTACTO);
            this.gbDATOS_OBRA_SOCIAL.Location = new System.Drawing.Point(633, 12);
            this.gbDATOS_OBRA_SOCIAL.Name = "gbDATOS_OBRA_SOCIAL";
            this.gbDATOS_OBRA_SOCIAL.Size = new System.Drawing.Size(247, 369);
            this.gbDATOS_OBRA_SOCIAL.TabIndex = 56;
            this.gbDATOS_OBRA_SOCIAL.TabStop = false;
            this.gbDATOS_OBRA_SOCIAL.Text = "DATOS DE LA OBRA SOCIAL";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(150, 332);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 59;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 332);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 55;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click_1);
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Location = new System.Drawing.Point(6, 52);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(57, 13);
            this.lbl_NOMBRE.TabIndex = 0;
            this.lbl_NOMBRE.Text = "NOMBRE:";
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(6, 92);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(34, 13);
            this.lblCUIL.TabIndex = 3;
            this.lblCUIL.Text = "CUIL:";
            // 
            // lblCONTACTO
            // 
            this.lblCONTACTO.AutoSize = true;
            this.lblCONTACTO.Location = new System.Drawing.Point(6, 141);
            this.lblCONTACTO.Name = "lblCONTACTO";
            this.lblCONTACTO.Size = new System.Drawing.Size(69, 13);
            this.lblCONTACTO.TabIndex = 4;
            this.lblCONTACTO.Text = "CONTACTO:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(81, 49);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(160, 20);
            this.txtNOMBRE.TabIndex = 6;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress);
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(81, 89);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(160, 20);
            this.txtCUIL.TabIndex = 8;
            this.txtCUIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIL_KeyPress);
            // 
            // txtCONTACTO
            // 
            this.txtCONTACTO.Location = new System.Drawing.Point(81, 138);
            this.txtCONTACTO.Name = "txtCONTACTO";
            this.txtCONTACTO.Size = new System.Drawing.Size(160, 20);
            this.txtCONTACTO.TabIndex = 9;
            this.txtCONTACTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCONTACTO_KeyPress);
            // 
            // gbLISTA_OBRAS_SOCIALES
            // 
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.dgvLISTA_OBRAS_SOCIALES);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_OBRAS_SOCIALES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_OBRAS_SOCIALES.Name = "gbLISTA_OBRAS_SOCIALES";
            this.gbLISTA_OBRAS_SOCIALES.Size = new System.Drawing.Size(615, 369);
            this.gbLISTA_OBRAS_SOCIALES.TabIndex = 55;
            this.gbLISTA_OBRAS_SOCIALES.TabStop = false;
            this.gbLISTA_OBRAS_SOCIALES.Text = "LISTA DE OBRAS SOCIALES";
            // 
            // dgvLISTA_OBRAS_SOCIALES
            // 
            this.dgvLISTA_OBRAS_SOCIALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_OBRAS_SOCIALES.Location = new System.Drawing.Point(6, 19);
            this.dgvLISTA_OBRAS_SOCIALES.Name = "dgvLISTA_OBRAS_SOCIALES";
            this.dgvLISTA_OBRAS_SOCIALES.Size = new System.Drawing.Size(603, 311);
            this.dgvLISTA_OBRAS_SOCIALES.TabIndex = 56;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(193, 336);
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
            this.btnCERRAR.Location = new System.Drawing.Point(520, 336);
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
            this.btnELIMINAR.Location = new System.Drawing.Point(287, 336);
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(99, 336);
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
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 336);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 48;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // frmOBRA_SOCIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 384);
            this.Controls.Add(this.gbDATOS_OBRA_SOCIAL);
            this.Controls.Add(this.gbLISTA_OBRAS_SOCIALES);
            this.Name = "frmOBRA_SOCIAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OBRAS SOCIALES";
            this.gbDATOS_OBRA_SOCIAL.ResumeLayout(false);
            this.gbDATOS_OBRA_SOCIAL.PerformLayout();
            this.gbLISTA_OBRAS_SOCIALES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_OBRAS_SOCIALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_OBRA_SOCIAL;
        private System.Windows.Forms.Label lbl_NOMBRE;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.Label lblCONTACTO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.TextBox txtCONTACTO;
        private System.Windows.Forms.GroupBox gbLISTA_OBRAS_SOCIALES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.DataGridView dgvLISTA_OBRAS_SOCIALES;
    }
}