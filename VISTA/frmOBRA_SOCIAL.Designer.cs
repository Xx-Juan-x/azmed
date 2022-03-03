
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDATOS_OBRA_SOCIAL = new System.Windows.Forms.GroupBox();
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.lblCONTACTO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.txtCONTACTO = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_OBRAS_SOCIALES = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvLISTA_OBRAS_SOCIALES = new System.Windows.Forms.DataGridView();
            this.gbDATOS_OBRA_SOCIAL.SuspendLayout();
            this.gbLISTA_OBRAS_SOCIALES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_OBRAS_SOCIALES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_OBRA_SOCIAL
            // 
            this.gbDATOS_OBRA_SOCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.lbl_NOMBRE);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.lblCUIL);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.lblCONTACTO);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.txtCUIL);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.txtCONTACTO);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_OBRA_SOCIAL.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_OBRA_SOCIAL.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_OBRA_SOCIAL.Location = new System.Drawing.Point(611, 8);
            this.gbDATOS_OBRA_SOCIAL.Name = "gbDATOS_OBRA_SOCIAL";
            this.gbDATOS_OBRA_SOCIAL.Size = new System.Drawing.Size(264, 191);
            this.gbDATOS_OBRA_SOCIAL.TabIndex = 5;
            this.gbDATOS_OBRA_SOCIAL.TabStop = false;
            this.gbDATOS_OBRA_SOCIAL.Text = "DATOS DE LA OBRA SOCIAL";
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Location = new System.Drawing.Point(8, 22);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(57, 13);
            this.lbl_NOMBRE.TabIndex = 10;
            this.lbl_NOMBRE.Text = "NOMBRE:";
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(8, 62);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(34, 13);
            this.lblCUIL.TabIndex = 11;
            this.lblCUIL.Text = "CUIL:";
            // 
            // lblCONTACTO
            // 
            this.lblCONTACTO.AutoSize = true;
            this.lblCONTACTO.Location = new System.Drawing.Point(8, 111);
            this.lblCONTACTO.Name = "lblCONTACTO";
            this.lblCONTACTO.Size = new System.Drawing.Size(69, 13);
            this.lblCONTACTO.TabIndex = 12;
            this.lblCONTACTO.Text = "CONTACTO:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(83, 19);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(172, 20);
            this.txtNOMBRE.TabIndex = 13;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress_1);
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(83, 59);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(172, 20);
            this.txtCUIL.TabIndex = 14;
            this.txtCUIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIL_KeyPress_1);
            // 
            // txtCONTACTO
            // 
            this.txtCONTACTO.Location = new System.Drawing.Point(83, 108);
            this.txtCONTACTO.Name = "txtCONTACTO";
            this.txtCONTACTO.Size = new System.Drawing.Size(172, 20);
            this.txtCONTACTO.TabIndex = 15;
            this.txtCONTACTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCONTACTO_KeyPress_1);
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
            this.btnCANCELAR.Location = new System.Drawing.Point(155, 145);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(100, 36);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 145);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(100, 36);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // gbLISTA_OBRAS_SOCIALES
            // 
            this.gbLISTA_OBRAS_SOCIALES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_OBRAS_SOCIALES.Controls.Add(this.dgvLISTA_OBRAS_SOCIALES);
            this.gbLISTA_OBRAS_SOCIALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_OBRAS_SOCIALES.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_OBRAS_SOCIALES.Location = new System.Drawing.Point(7, 8);
            this.gbLISTA_OBRAS_SOCIALES.Name = "gbLISTA_OBRAS_SOCIALES";
            this.gbLISTA_OBRAS_SOCIALES.Size = new System.Drawing.Size(602, 368);
            this.gbLISTA_OBRAS_SOCIALES.TabIndex = 4;
            this.gbLISTA_OBRAS_SOCIALES.TabStop = false;
            this.gbLISTA_OBRAS_SOCIALES.Text = "LISTA DE OBRAS SOCIALES";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(513, 332);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click_1);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnELIMINAR.FlatAppearance.BorderSize = 0;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(272, 332);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(83, 30);
            this.btnELIMINAR.TabIndex = 15;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click_1);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCONSULTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCONSULTAR.FlatAppearance.BorderSize = 0;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(183, 332);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(83, 30);
            this.btnCONSULTAR.TabIndex = 14;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click_1);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnMODIFICAR.FlatAppearance.BorderSize = 0;
            this.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMODIFICAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMODIFICAR.ForeColor = System.Drawing.Color.White;
            this.btnMODIFICAR.Location = new System.Drawing.Point(94, 332);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(83, 30);
            this.btnMODIFICAR.TabIndex = 13;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click_1);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 332);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(83, 30);
            this.btnAGREGAR.TabIndex = 11;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // dgvLISTA_OBRAS_SOCIALES
            // 
            this.dgvLISTA_OBRAS_SOCIALES.AllowUserToAddRows = false;
            this.dgvLISTA_OBRAS_SOCIALES.AllowUserToDeleteRows = false;
            this.dgvLISTA_OBRAS_SOCIALES.AllowUserToResizeColumns = false;
            this.dgvLISTA_OBRAS_SOCIALES.AllowUserToResizeRows = false;
            this.dgvLISTA_OBRAS_SOCIALES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_OBRAS_SOCIALES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_OBRAS_SOCIALES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_OBRAS_SOCIALES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_OBRAS_SOCIALES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_OBRAS_SOCIALES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_OBRAS_SOCIALES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLISTA_OBRAS_SOCIALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_OBRAS_SOCIALES.EnableHeadersVisualStyles = false;
            this.dgvLISTA_OBRAS_SOCIALES.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_OBRAS_SOCIALES.Location = new System.Drawing.Point(5, 19);
            this.dgvLISTA_OBRAS_SOCIALES.Name = "dgvLISTA_OBRAS_SOCIALES";
            this.dgvLISTA_OBRAS_SOCIALES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_OBRAS_SOCIALES.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLISTA_OBRAS_SOCIALES.RowHeadersVisible = false;
            this.dgvLISTA_OBRAS_SOCIALES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_OBRAS_SOCIALES.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvLISTA_OBRAS_SOCIALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_OBRAS_SOCIALES.Size = new System.Drawing.Size(590, 307);
            this.dgvLISTA_OBRAS_SOCIALES.TabIndex = 0;
            // 
            // frmOBRA_SOCIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(883, 384);
            this.Controls.Add(this.gbDATOS_OBRA_SOCIAL);
            this.Controls.Add(this.gbLISTA_OBRAS_SOCIALES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbLISTA_OBRAS_SOCIALES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvLISTA_OBRAS_SOCIALES;
    }
}