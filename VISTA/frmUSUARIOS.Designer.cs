
namespace VISTA
{
    partial class frmUSUARIOS
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
            this.lblNOMBRE_USUARIO = new System.Windows.Forms.Label();
            this.lblAPELLIDO_USUARIO = new System.Windows.Forms.Label();
            this.lblEMAIL_USUARIO = new System.Windows.Forms.Label();
            this.lblPASSWORD_USUARIO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.lblROL_USUARIO = new System.Windows.Forms.Label();
            this.cmbROL = new System.Windows.Forms.ComboBox();
            this.gbDATOS_USUARIO = new System.Windows.Forms.GroupBox();
            this.txtCONFIRMAR_PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.gbLISTA_USUARIOS = new System.Windows.Forms.GroupBox();
            this.lblFILTRO_TIPO = new System.Windows.Forms.Label();
            this.cmbFILTRO_TIPO = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dgvLISTA_USUARIOS = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.gbDATOS_USUARIO.SuspendLayout();
            this.gbLISTA_USUARIOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_USUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNOMBRE_USUARIO
            // 
            this.lblNOMBRE_USUARIO.AutoSize = true;
            this.lblNOMBRE_USUARIO.Location = new System.Drawing.Point(6, 43);
            this.lblNOMBRE_USUARIO.Name = "lblNOMBRE_USUARIO";
            this.lblNOMBRE_USUARIO.Size = new System.Drawing.Size(57, 13);
            this.lblNOMBRE_USUARIO.TabIndex = 0;
            this.lblNOMBRE_USUARIO.Text = "NOMBRE:";
            // 
            // lblAPELLIDO_USUARIO
            // 
            this.lblAPELLIDO_USUARIO.AutoSize = true;
            this.lblAPELLIDO_USUARIO.Location = new System.Drawing.Point(6, 88);
            this.lblAPELLIDO_USUARIO.Name = "lblAPELLIDO_USUARIO";
            this.lblAPELLIDO_USUARIO.Size = new System.Drawing.Size(62, 13);
            this.lblAPELLIDO_USUARIO.TabIndex = 1;
            this.lblAPELLIDO_USUARIO.Text = "APELLIDO:";
            // 
            // lblEMAIL_USUARIO
            // 
            this.lblEMAIL_USUARIO.AutoSize = true;
            this.lblEMAIL_USUARIO.Location = new System.Drawing.Point(6, 135);
            this.lblEMAIL_USUARIO.Name = "lblEMAIL_USUARIO";
            this.lblEMAIL_USUARIO.Size = new System.Drawing.Size(42, 13);
            this.lblEMAIL_USUARIO.TabIndex = 2;
            this.lblEMAIL_USUARIO.Text = "EMAIL:";
            // 
            // lblPASSWORD_USUARIO
            // 
            this.lblPASSWORD_USUARIO.AutoSize = true;
            this.lblPASSWORD_USUARIO.Location = new System.Drawing.Point(6, 188);
            this.lblPASSWORD_USUARIO.Name = "lblPASSWORD_USUARIO";
            this.lblPASSWORD_USUARIO.Size = new System.Drawing.Size(84, 13);
            this.lblPASSWORD_USUARIO.TabIndex = 3;
            this.lblPASSWORD_USUARIO.Text = "CONTRASEÑA:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(96, 40);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(159, 20);
            this.txtNOMBRE.TabIndex = 4;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress);
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(96, 85);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(159, 20);
            this.txtAPELLIDO.TabIndex = 5;
            this.txtAPELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPELLIDO_KeyPress);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(96, 132);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(159, 20);
            this.txtEMAIL.TabIndex = 6;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(96, 185);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(159, 20);
            this.txtPASSWORD.TabIndex = 7;
            // 
            // lblROL_USUARIO
            // 
            this.lblROL_USUARIO.AutoSize = true;
            this.lblROL_USUARIO.Location = new System.Drawing.Point(6, 297);
            this.lblROL_USUARIO.Name = "lblROL_USUARIO";
            this.lblROL_USUARIO.Size = new System.Drawing.Size(32, 13);
            this.lblROL_USUARIO.TabIndex = 8;
            this.lblROL_USUARIO.Text = "ROL:";
            // 
            // cmbROL
            // 
            this.cmbROL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbROL.FormattingEnabled = true;
            this.cmbROL.Location = new System.Drawing.Point(96, 294);
            this.cmbROL.Name = "cmbROL";
            this.cmbROL.Size = new System.Drawing.Size(159, 21);
            this.cmbROL.TabIndex = 9;
            // 
            // gbDATOS_USUARIO
            // 
            this.gbDATOS_USUARIO.Controls.Add(this.txtCONFIRMAR_PASSWORD);
            this.gbDATOS_USUARIO.Controls.Add(this.label1);
            this.gbDATOS_USUARIO.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_USUARIO.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_USUARIO.Controls.Add(this.txtNOMBRE);
            this.gbDATOS_USUARIO.Controls.Add(this.lblNOMBRE_USUARIO);
            this.gbDATOS_USUARIO.Controls.Add(this.cmbROL);
            this.gbDATOS_USUARIO.Controls.Add(this.lblAPELLIDO_USUARIO);
            this.gbDATOS_USUARIO.Controls.Add(this.lblROL_USUARIO);
            this.gbDATOS_USUARIO.Controls.Add(this.lblEMAIL_USUARIO);
            this.gbDATOS_USUARIO.Controls.Add(this.txtPASSWORD);
            this.gbDATOS_USUARIO.Controls.Add(this.lblPASSWORD_USUARIO);
            this.gbDATOS_USUARIO.Controls.Add(this.txtEMAIL);
            this.gbDATOS_USUARIO.Controls.Add(this.txtAPELLIDO);
            this.gbDATOS_USUARIO.Location = new System.Drawing.Point(736, 12);
            this.gbDATOS_USUARIO.Name = "gbDATOS_USUARIO";
            this.gbDATOS_USUARIO.Size = new System.Drawing.Size(261, 379);
            this.gbDATOS_USUARIO.TabIndex = 10;
            this.gbDATOS_USUARIO.TabStop = false;
            this.gbDATOS_USUARIO.Text = "DATOS DEL USUARIO";
            // 
            // txtCONFIRMAR_PASSWORD
            // 
            this.txtCONFIRMAR_PASSWORD.Location = new System.Drawing.Point(123, 244);
            this.txtCONFIRMAR_PASSWORD.Name = "txtCONFIRMAR_PASSWORD";
            this.txtCONFIRMAR_PASSWORD.PasswordChar = '*';
            this.txtCONFIRMAR_PASSWORD.Size = new System.Drawing.Size(132, 20);
            this.txtCONFIRMAR_PASSWORD.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "CONFIRMAR CLAVE:";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(9, 350);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(88, 23);
            this.btnGUARDAR.TabIndex = 60;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click_1);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.Red;
            this.btnCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(167, 350);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(88, 23);
            this.btnCANCELAR.TabIndex = 61;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // gbLISTA_USUARIOS
            // 
            this.gbLISTA_USUARIOS.Controls.Add(this.lblFILTRO_TIPO);
            this.gbLISTA_USUARIOS.Controls.Add(this.cmbFILTRO_TIPO);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.dgvLISTA_USUARIOS);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnCERRAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_USUARIOS.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_USUARIOS.Name = "gbLISTA_USUARIOS";
            this.gbLISTA_USUARIOS.Size = new System.Drawing.Size(718, 415);
            this.gbLISTA_USUARIOS.TabIndex = 11;
            this.gbLISTA_USUARIOS.TabStop = false;
            this.gbLISTA_USUARIOS.Text = "LISTA DE USUARIOS";
            // 
            // lblFILTRO_TIPO
            // 
            this.lblFILTRO_TIPO.AutoSize = true;
            this.lblFILTRO_TIPO.Location = new System.Drawing.Point(334, 25);
            this.lblFILTRO_TIPO.Name = "lblFILTRO_TIPO";
            this.lblFILTRO_TIPO.Size = new System.Drawing.Size(105, 13);
            this.lblFILTRO_TIPO.TabIndex = 70;
            this.lblFILTRO_TIPO.Text = "TIPO DE USUARIO:";
            // 
            // cmbFILTRO_TIPO
            // 
            this.cmbFILTRO_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_TIPO.FormattingEnabled = true;
            this.cmbFILTRO_TIPO.Location = new System.Drawing.Point(445, 22);
            this.cmbFILTRO_TIPO.Name = "cmbFILTRO_TIPO";
            this.cmbFILTRO_TIPO.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_TIPO.TabIndex = 69;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBUSCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(610, 14);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(102, 35);
            this.btnBUSCAR.TabIndex = 68;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // dgvLISTA_USUARIOS
            // 
            this.dgvLISTA_USUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTA_USUARIOS.Location = new System.Drawing.Point(6, 55);
            this.dgvLISTA_USUARIOS.Name = "dgvLISTA_USUARIOS";
            this.dgvLISTA_USUARIOS.Size = new System.Drawing.Size(706, 324);
            this.dgvLISTA_USUARIOS.TabIndex = 61;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCONSULTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.White;
            this.btnCONSULTAR.Location = new System.Drawing.Point(194, 385);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(88, 23);
            this.btnCONSULTAR.TabIndex = 60;
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
            this.btnCERRAR.Location = new System.Drawing.Point(624, 385);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(88, 23);
            this.btnCERRAR.TabIndex = 59;
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
            this.btnELIMINAR.Location = new System.Drawing.Point(288, 385);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(88, 23);
            this.btnELIMINAR.TabIndex = 58;
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(100, 385);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(88, 23);
            this.btnMODIFICAR.TabIndex = 57;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click_1);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAGREGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(6, 385);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(88, 23);
            this.btnAGREGAR.TabIndex = 56;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // frmUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 432);
            this.Controls.Add(this.gbLISTA_USUARIOS);
            this.Controls.Add(this.gbDATOS_USUARIO);
            this.Name = "frmUSUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIOS";
            this.gbDATOS_USUARIO.ResumeLayout(false);
            this.gbDATOS_USUARIO.PerformLayout();
            this.gbLISTA_USUARIOS.ResumeLayout(false);
            this.gbLISTA_USUARIOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_USUARIOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNOMBRE_USUARIO;
        private System.Windows.Forms.Label lblAPELLIDO_USUARIO;
        private System.Windows.Forms.Label lblEMAIL_USUARIO;
        private System.Windows.Forms.Label lblPASSWORD_USUARIO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label lblROL_USUARIO;
        private System.Windows.Forms.ComboBox cmbROL;
        private System.Windows.Forms.GroupBox gbDATOS_USUARIO;
        private System.Windows.Forms.GroupBox gbLISTA_USUARIOS;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.DataGridView dgvLISTA_USUARIOS;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Label lblFILTRO_TIPO;
        private System.Windows.Forms.ComboBox cmbFILTRO_TIPO;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtCONFIRMAR_PASSWORD;
        private System.Windows.Forms.Label label1;
    }
}