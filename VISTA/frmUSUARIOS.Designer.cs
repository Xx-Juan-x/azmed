
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDATOS_USUARIO = new System.Windows.Forms.GroupBox();
            this.lblDESCRIPCION_CLAVE = new System.Windows.Forms.Label();
            this.lblDESCRIPCION = new System.Windows.Forms.Label();
            this.txtCONFIRMAR_PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.lblNOMBRE_USUARIO = new System.Windows.Forms.Label();
            this.cmbROL = new System.Windows.Forms.ComboBox();
            this.lblAPELLIDO_USUARIO = new System.Windows.Forms.Label();
            this.lblROL_USUARIO = new System.Windows.Forms.Label();
            this.lblEMAIL_USUARIO = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.lblPASSWORD_USUARIO = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_USUARIOS = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.lblFILTRO_TIPO = new System.Windows.Forms.Label();
            this.cmbFILTRO_TIPO = new System.Windows.Forms.ComboBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvLISTA_USUARIOS = new System.Windows.Forms.DataGridView();
            this.gbDATOS_USUARIO.SuspendLayout();
            this.gbLISTA_USUARIOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_USUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_USUARIO
            // 
            this.gbDATOS_USUARIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_USUARIO.Controls.Add(this.lblDESCRIPCION_CLAVE);
            this.gbDATOS_USUARIO.Controls.Add(this.lblDESCRIPCION);
            this.gbDATOS_USUARIO.Controls.Add(this.txtCONFIRMAR_PASSWORD);
            this.gbDATOS_USUARIO.Controls.Add(this.label1);
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
            this.gbDATOS_USUARIO.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_USUARIO.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_USUARIO.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_USUARIO.Location = new System.Drawing.Point(799, 8);
            this.gbDATOS_USUARIO.Name = "gbDATOS_USUARIO";
            this.gbDATOS_USUARIO.Size = new System.Drawing.Size(264, 375);
            this.gbDATOS_USUARIO.TabIndex = 5;
            this.gbDATOS_USUARIO.TabStop = false;
            this.gbDATOS_USUARIO.Text = "DATOS DEL USUARIO";
            // 
            // lblDESCRIPCION_CLAVE
            // 
            this.lblDESCRIPCION_CLAVE.AutoSize = true;
            this.lblDESCRIPCION_CLAVE.Location = new System.Drawing.Point(176, 258);
            this.lblDESCRIPCION_CLAVE.Name = "lblDESCRIPCION_CLAVE";
            this.lblDESCRIPCION_CLAVE.Size = new System.Drawing.Size(82, 13);
            this.lblDESCRIPCION_CLAVE.TabIndex = 77;
            this.lblDESCRIPCION_CLAVE.Text = "8-16 Caracteres";
            // 
            // lblDESCRIPCION
            // 
            this.lblDESCRIPCION.AutoSize = true;
            this.lblDESCRIPCION.Location = new System.Drawing.Point(176, 199);
            this.lblDESCRIPCION.Name = "lblDESCRIPCION";
            this.lblDESCRIPCION.Size = new System.Drawing.Size(82, 13);
            this.lblDESCRIPCION.TabIndex = 76;
            this.lblDESCRIPCION.Text = "8-16 Caracteres";
            // 
            // txtCONFIRMAR_PASSWORD
            // 
            this.txtCONFIRMAR_PASSWORD.Location = new System.Drawing.Point(126, 235);
            this.txtCONFIRMAR_PASSWORD.Name = "txtCONFIRMAR_PASSWORD";
            this.txtCONFIRMAR_PASSWORD.PasswordChar = '*';
            this.txtCONFIRMAR_PASSWORD.Size = new System.Drawing.Size(132, 20);
            this.txtCONFIRMAR_PASSWORD.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "CONFIRMAR CLAVE:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(99, 31);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(159, 20);
            this.txtNOMBRE.TabIndex = 68;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress_1);
            // 
            // lblNOMBRE_USUARIO
            // 
            this.lblNOMBRE_USUARIO.AutoSize = true;
            this.lblNOMBRE_USUARIO.Location = new System.Drawing.Point(9, 34);
            this.lblNOMBRE_USUARIO.Name = "lblNOMBRE_USUARIO";
            this.lblNOMBRE_USUARIO.Size = new System.Drawing.Size(57, 13);
            this.lblNOMBRE_USUARIO.TabIndex = 64;
            this.lblNOMBRE_USUARIO.Text = "NOMBRE:";
            // 
            // cmbROL
            // 
            this.cmbROL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbROL.FormattingEnabled = true;
            this.cmbROL.Location = new System.Drawing.Point(99, 285);
            this.cmbROL.Name = "cmbROL";
            this.cmbROL.Size = new System.Drawing.Size(159, 21);
            this.cmbROL.TabIndex = 73;
            // 
            // lblAPELLIDO_USUARIO
            // 
            this.lblAPELLIDO_USUARIO.AutoSize = true;
            this.lblAPELLIDO_USUARIO.Location = new System.Drawing.Point(9, 79);
            this.lblAPELLIDO_USUARIO.Name = "lblAPELLIDO_USUARIO";
            this.lblAPELLIDO_USUARIO.Size = new System.Drawing.Size(62, 13);
            this.lblAPELLIDO_USUARIO.TabIndex = 65;
            this.lblAPELLIDO_USUARIO.Text = "APELLIDO:";
            // 
            // lblROL_USUARIO
            // 
            this.lblROL_USUARIO.AutoSize = true;
            this.lblROL_USUARIO.Location = new System.Drawing.Point(9, 288);
            this.lblROL_USUARIO.Name = "lblROL_USUARIO";
            this.lblROL_USUARIO.Size = new System.Drawing.Size(32, 13);
            this.lblROL_USUARIO.TabIndex = 72;
            this.lblROL_USUARIO.Text = "ROL:";
            // 
            // lblEMAIL_USUARIO
            // 
            this.lblEMAIL_USUARIO.AutoSize = true;
            this.lblEMAIL_USUARIO.Location = new System.Drawing.Point(9, 126);
            this.lblEMAIL_USUARIO.Name = "lblEMAIL_USUARIO";
            this.lblEMAIL_USUARIO.Size = new System.Drawing.Size(42, 13);
            this.lblEMAIL_USUARIO.TabIndex = 66;
            this.lblEMAIL_USUARIO.Text = "EMAIL:";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(99, 176);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(159, 20);
            this.txtPASSWORD.TabIndex = 71;
            // 
            // lblPASSWORD_USUARIO
            // 
            this.lblPASSWORD_USUARIO.AutoSize = true;
            this.lblPASSWORD_USUARIO.Location = new System.Drawing.Point(9, 179);
            this.lblPASSWORD_USUARIO.Name = "lblPASSWORD_USUARIO";
            this.lblPASSWORD_USUARIO.Size = new System.Drawing.Size(84, 13);
            this.lblPASSWORD_USUARIO.TabIndex = 67;
            this.lblPASSWORD_USUARIO.Text = "CONTRASEÑA:";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(99, 123);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(159, 20);
            this.txtEMAIL.TabIndex = 70;
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(99, 76);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(159, 20);
            this.txtAPELLIDO.TabIndex = 69;
            this.txtAPELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPELLIDO_KeyPress_1);
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
            this.btnCANCELAR.Location = new System.Drawing.Point(155, 323);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(100, 36);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 323);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(100, 36);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // gbLISTA_USUARIOS
            // 
            this.gbLISTA_USUARIOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_USUARIOS.Controls.Add(this.btnBUSCAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.lblFILTRO_TIPO);
            this.gbLISTA_USUARIOS.Controls.Add(this.cmbFILTRO_TIPO);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnCERRAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_USUARIOS.Controls.Add(this.dgvLISTA_USUARIOS);
            this.gbLISTA_USUARIOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_USUARIOS.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_USUARIOS.Location = new System.Drawing.Point(8, 8);
            this.gbLISTA_USUARIOS.Name = "gbLISTA_USUARIOS";
            this.gbLISTA_USUARIOS.Size = new System.Drawing.Size(789, 417);
            this.gbLISTA_USUARIOS.TabIndex = 4;
            this.gbLISTA_USUARIOS.TabStop = false;
            this.gbLISTA_USUARIOS.Text = "LISTA DE USUARIOS";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBUSCAR.FlatAppearance.BorderSize = 0;
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBUSCAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.btnBUSCAR.Location = new System.Drawing.Point(683, 18);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(100, 36);
            this.btnBUSCAR.TabIndex = 76;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click_1);
            // 
            // lblFILTRO_TIPO
            // 
            this.lblFILTRO_TIPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFILTRO_TIPO.AutoSize = true;
            this.lblFILTRO_TIPO.ForeColor = System.Drawing.Color.White;
            this.lblFILTRO_TIPO.Location = new System.Drawing.Point(407, 31);
            this.lblFILTRO_TIPO.Name = "lblFILTRO_TIPO";
            this.lblFILTRO_TIPO.Size = new System.Drawing.Size(105, 13);
            this.lblFILTRO_TIPO.TabIndex = 71;
            this.lblFILTRO_TIPO.Text = "TIPO DE USUARIO:";
            // 
            // cmbFILTRO_TIPO
            // 
            this.cmbFILTRO_TIPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFILTRO_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFILTRO_TIPO.FormattingEnabled = true;
            this.cmbFILTRO_TIPO.Location = new System.Drawing.Point(518, 26);
            this.cmbFILTRO_TIPO.Name = "cmbFILTRO_TIPO";
            this.cmbFILTRO_TIPO.Size = new System.Drawing.Size(159, 21);
            this.cmbFILTRO_TIPO.TabIndex = 70;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(700, 381);
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
            this.btnELIMINAR.Location = new System.Drawing.Point(272, 381);
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
            this.btnCONSULTAR.Location = new System.Drawing.Point(183, 381);
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(94, 381);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(83, 30);
            this.btnMODIFICAR.TabIndex = 13;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.ForeColor = System.Drawing.Color.White;
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 381);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(83, 30);
            this.btnAGREGAR.TabIndex = 11;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvLISTA_USUARIOS
            // 
            this.dgvLISTA_USUARIOS.AllowUserToAddRows = false;
            this.dgvLISTA_USUARIOS.AllowUserToDeleteRows = false;
            this.dgvLISTA_USUARIOS.AllowUserToResizeColumns = false;
            this.dgvLISTA_USUARIOS.AllowUserToResizeRows = false;
            this.dgvLISTA_USUARIOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_USUARIOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_USUARIOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_USUARIOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_USUARIOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_USUARIOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_USUARIOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_USUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_USUARIOS.EnableHeadersVisualStyles = false;
            this.dgvLISTA_USUARIOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_USUARIOS.Location = new System.Drawing.Point(6, 61);
            this.dgvLISTA_USUARIOS.Name = "dgvLISTA_USUARIOS";
            this.dgvLISTA_USUARIOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_USUARIOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_USUARIOS.RowHeadersVisible = false;
            this.dgvLISTA_USUARIOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_USUARIOS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_USUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_USUARIOS.Size = new System.Drawing.Size(777, 314);
            this.dgvLISTA_USUARIOS.TabIndex = 0;
            // 
            // frmUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1070, 432);
            this.Controls.Add(this.gbDATOS_USUARIO);
            this.Controls.Add(this.gbLISTA_USUARIOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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

        private System.Windows.Forms.GroupBox gbDATOS_USUARIO;
        private System.Windows.Forms.TextBox txtCONFIRMAR_PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label lblNOMBRE_USUARIO;
        private System.Windows.Forms.ComboBox cmbROL;
        private System.Windows.Forms.Label lblAPELLIDO_USUARIO;
        private System.Windows.Forms.Label lblROL_USUARIO;
        private System.Windows.Forms.Label lblEMAIL_USUARIO;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label lblPASSWORD_USUARIO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbLISTA_USUARIOS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label lblFILTRO_TIPO;
        private System.Windows.Forms.ComboBox cmbFILTRO_TIPO;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvLISTA_USUARIOS;
        private System.Windows.Forms.Label lblDESCRIPCION_CLAVE;
        private System.Windows.Forms.Label lblDESCRIPCION;
    }
}