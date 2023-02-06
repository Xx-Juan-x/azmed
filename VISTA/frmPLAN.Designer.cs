
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDATOS_PLAN = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDESCUENTO_CONSULTA = new System.Windows.Forms.Label();
            this.txtDESCUENTO_ESTUDIO = new System.Windows.Forms.TextBox();
            this.txtDESCUENTO_CONSULTA = new System.Windows.Forms.TextBox();
            this.txtPLAN = new System.Windows.Forms.TextBox();
            this.lblOBRA_SOCIAL = new System.Windows.Forms.Label();
            this.cmbOBRA_SOCIAL = new System.Windows.Forms.ComboBox();
            this.lbl_NOMBRE = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_PLANES = new System.Windows.Forms.GroupBox();
            this.btnRECUPERAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvLISTA_PLANES = new System.Windows.Forms.DataGridView();
            this.gbDATOS_PLAN.SuspendLayout();
            this.gbLISTA_PLANES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PLANES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDATOS_PLAN
            // 
            this.gbDATOS_PLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_PLAN.Controls.Add(this.label1);
            this.gbDATOS_PLAN.Controls.Add(this.lblDESCUENTO_CONSULTA);
            this.gbDATOS_PLAN.Controls.Add(this.txtDESCUENTO_ESTUDIO);
            this.gbDATOS_PLAN.Controls.Add(this.txtDESCUENTO_CONSULTA);
            this.gbDATOS_PLAN.Controls.Add(this.txtPLAN);
            this.gbDATOS_PLAN.Controls.Add(this.lblOBRA_SOCIAL);
            this.gbDATOS_PLAN.Controls.Add(this.cmbOBRA_SOCIAL);
            this.gbDATOS_PLAN.Controls.Add(this.lbl_NOMBRE);
            this.gbDATOS_PLAN.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_PLAN.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_PLAN.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_PLAN.Location = new System.Drawing.Point(730, 12);
            this.gbDATOS_PLAN.Name = "gbDATOS_PLAN";
            this.gbDATOS_PLAN.Size = new System.Drawing.Size(344, 224);
            this.gbDATOS_PLAN.TabIndex = 5;
            this.gbDATOS_PLAN.TabStop = false;
            this.gbDATOS_PLAN.Text = "DATOS DEL PLAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "DESCUENTO DE ESTUDIO:";
            // 
            // lblDESCUENTO_CONSULTA
            // 
            this.lblDESCUENTO_CONSULTA.AutoSize = true;
            this.lblDESCUENTO_CONSULTA.Location = new System.Drawing.Point(6, 108);
            this.lblDESCUENTO_CONSULTA.Name = "lblDESCUENTO_CONSULTA";
            this.lblDESCUENTO_CONSULTA.Size = new System.Drawing.Size(156, 13);
            this.lblDESCUENTO_CONSULTA.TabIndex = 71;
            this.lblDESCUENTO_CONSULTA.Text = "DESCUENTO DE CONSULTA:";
            // 
            // txtDESCUENTO_ESTUDIO
            // 
            this.txtDESCUENTO_ESTUDIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDESCUENTO_ESTUDIO.Location = new System.Drawing.Point(176, 141);
            this.txtDESCUENTO_ESTUDIO.Name = "txtDESCUENTO_ESTUDIO";
            this.txtDESCUENTO_ESTUDIO.Size = new System.Drawing.Size(159, 20);
            this.txtDESCUENTO_ESTUDIO.TabIndex = 70;
            this.txtDESCUENTO_ESTUDIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDESCUENTO_ESTUDIO_KeyPress);
            // 
            // txtDESCUENTO_CONSULTA
            // 
            this.txtDESCUENTO_CONSULTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDESCUENTO_CONSULTA.Location = new System.Drawing.Point(176, 101);
            this.txtDESCUENTO_CONSULTA.Name = "txtDESCUENTO_CONSULTA";
            this.txtDESCUENTO_CONSULTA.Size = new System.Drawing.Size(159, 20);
            this.txtDESCUENTO_CONSULTA.TabIndex = 69;
            this.txtDESCUENTO_CONSULTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDESCUENTO_CONSULTA_KeyPress);
            // 
            // txtPLAN
            // 
            this.txtPLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPLAN.Location = new System.Drawing.Point(176, 21);
            this.txtPLAN.Name = "txtPLAN";
            this.txtPLAN.Size = new System.Drawing.Size(159, 20);
            this.txtPLAN.TabIndex = 68;
            this.txtPLAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPLAN_KeyPress);
            // 
            // lblOBRA_SOCIAL
            // 
            this.lblOBRA_SOCIAL.AutoSize = true;
            this.lblOBRA_SOCIAL.Location = new System.Drawing.Point(3, 62);
            this.lblOBRA_SOCIAL.Name = "lblOBRA_SOCIAL";
            this.lblOBRA_SOCIAL.Size = new System.Drawing.Size(81, 13);
            this.lblOBRA_SOCIAL.TabIndex = 67;
            this.lblOBRA_SOCIAL.Text = "OBRA SOCIAL:";
            // 
            // cmbOBRA_SOCIAL
            // 
            this.cmbOBRA_SOCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOBRA_SOCIAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOBRA_SOCIAL.FormattingEnabled = true;
            this.cmbOBRA_SOCIAL.Location = new System.Drawing.Point(176, 59);
            this.cmbOBRA_SOCIAL.Name = "cmbOBRA_SOCIAL";
            this.cmbOBRA_SOCIAL.Size = new System.Drawing.Size(159, 21);
            this.cmbOBRA_SOCIAL.TabIndex = 66;
            // 
            // lbl_NOMBRE
            // 
            this.lbl_NOMBRE.AutoSize = true;
            this.lbl_NOMBRE.Location = new System.Drawing.Point(9, 24);
            this.lbl_NOMBRE.Name = "lbl_NOMBRE";
            this.lbl_NOMBRE.Size = new System.Drawing.Size(38, 13);
            this.lbl_NOMBRE.TabIndex = 63;
            this.lbl_NOMBRE.Text = "PLAN:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCANCELAR.FlatAppearance.BorderSize = 0;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(212, 182);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(123, 36);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGUARDAR.FlatAppearance.BorderSize = 0;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 182);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(123, 36);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click_1);
            // 
            // gbLISTA_PLANES
            // 
            this.gbLISTA_PLANES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_PLANES.Controls.Add(this.btnRECUPERAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnELIMINAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnCONSULTAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnMODIFICAR);
            this.gbLISTA_PLANES.Controls.Add(this.btnAGREGAR);
            this.gbLISTA_PLANES.Controls.Add(this.dgvLISTA_PLANES);
            this.gbLISTA_PLANES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_PLANES.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_PLANES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_PLANES.Name = "gbLISTA_PLANES";
            this.gbLISTA_PLANES.Size = new System.Drawing.Size(712, 341);
            this.gbLISTA_PLANES.TabIndex = 4;
            this.gbLISTA_PLANES.TabStop = false;
            this.gbLISTA_PLANES.Text = "LISTA DE PLANES";
            // 
            // btnRECUPERAR
            // 
            this.btnRECUPERAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRECUPERAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnRECUPERAR.FlatAppearance.BorderSize = 0;
            this.btnRECUPERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRECUPERAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRECUPERAR.ForeColor = System.Drawing.Color.White;
            this.btnRECUPERAR.Location = new System.Drawing.Point(361, 305);
            this.btnRECUPERAR.Name = "btnRECUPERAR";
            this.btnRECUPERAR.Size = new System.Drawing.Size(83, 30);
            this.btnRECUPERAR.TabIndex = 17;
            this.btnRECUPERAR.Text = "Recuperar";
            this.btnRECUPERAR.UseVisualStyleBackColor = false;
            this.btnRECUPERAR.Click += new System.EventHandler(this.btnRECUPERAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(623, 305);
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
            this.btnELIMINAR.Location = new System.Drawing.Point(272, 305);
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
            this.btnCONSULTAR.Location = new System.Drawing.Point(183, 305);
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
            this.btnMODIFICAR.Location = new System.Drawing.Point(94, 305);
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
            this.btnAGREGAR.Location = new System.Drawing.Point(5, 305);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(83, 30);
            this.btnAGREGAR.TabIndex = 11;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // dgvLISTA_PLANES
            // 
            this.dgvLISTA_PLANES.AllowUserToAddRows = false;
            this.dgvLISTA_PLANES.AllowUserToDeleteRows = false;
            this.dgvLISTA_PLANES.AllowUserToResizeColumns = false;
            this.dgvLISTA_PLANES.AllowUserToResizeRows = false;
            this.dgvLISTA_PLANES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_PLANES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_PLANES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_PLANES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_PLANES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_PLANES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_PLANES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_PLANES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_PLANES.EnableHeadersVisualStyles = false;
            this.dgvLISTA_PLANES.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_PLANES.Location = new System.Drawing.Point(5, 19);
            this.dgvLISTA_PLANES.Name = "dgvLISTA_PLANES";
            this.dgvLISTA_PLANES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_PLANES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_PLANES.RowHeadersVisible = false;
            this.dgvLISTA_PLANES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_PLANES.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_PLANES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_PLANES.Size = new System.Drawing.Size(700, 280);
            this.dgvLISTA_PLANES.TabIndex = 0;
            // 
            // frmPLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1086, 357);
            this.Controls.Add(this.gbDATOS_PLAN);
            this.Controls.Add(this.gbLISTA_PLANES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPLAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLANES";
            this.gbDATOS_PLAN.ResumeLayout(false);
            this.gbDATOS_PLAN.PerformLayout();
            this.gbLISTA_PLANES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PLANES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDATOS_PLAN;
        private System.Windows.Forms.Label lblOBRA_SOCIAL;
        private System.Windows.Forms.ComboBox cmbOBRA_SOCIAL;
        private System.Windows.Forms.Label lbl_NOMBRE;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbLISTA_PLANES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvLISTA_PLANES;
        private System.Windows.Forms.TextBox txtPLAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDESCUENTO_CONSULTA;
        private System.Windows.Forms.TextBox txtDESCUENTO_ESTUDIO;
        private System.Windows.Forms.TextBox txtDESCUENTO_CONSULTA;
        private System.Windows.Forms.Button btnRECUPERAR;
    }
}