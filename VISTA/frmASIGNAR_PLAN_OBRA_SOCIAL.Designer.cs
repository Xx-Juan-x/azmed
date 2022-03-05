
namespace VISTA
{
    partial class frmASIGNAR_PLAN_OBRA_SOCIAL
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
            this.gbLISTA_PACIENTES = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnASIGNAR = new System.Windows.Forms.Button();
            this.dgvLISTA_PACIENTES = new System.Windows.Forms.DataGridView();
            this.gbDATOS_PLAN_OBRA_SOCIAL = new System.Windows.Forms.GroupBox();
            this.lblOBRA_SOCIAL = new System.Windows.Forms.Label();
            this.lblPLAN = new System.Windows.Forms.Label();
            this.cmbPLAN = new System.Windows.Forms.ComboBox();
            this.cmbOBRA_SOCIAL = new System.Windows.Forms.ComboBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_PACIENTES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PACIENTES)).BeginInit();
            this.gbDATOS_PLAN_OBRA_SOCIAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLISTA_PACIENTES
            // 
            this.gbLISTA_PACIENTES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_PACIENTES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PACIENTES.Controls.Add(this.btnASIGNAR);
            this.gbLISTA_PACIENTES.Controls.Add(this.dgvLISTA_PACIENTES);
            this.gbLISTA_PACIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_PACIENTES.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_PACIENTES.Location = new System.Drawing.Point(12, 12);
            this.gbLISTA_PACIENTES.Name = "gbLISTA_PACIENTES";
            this.gbLISTA_PACIENTES.Size = new System.Drawing.Size(652, 317);
            this.gbLISTA_PACIENTES.TabIndex = 5;
            this.gbLISTA_PACIENTES.TabStop = false;
            this.gbLISTA_PACIENTES.Text = "LISTA DE PACIENTES";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(563, 281);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(83, 30);
            this.btnCERRAR.TabIndex = 16;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnASIGNAR
            // 
            this.btnASIGNAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASIGNAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnASIGNAR.FlatAppearance.BorderSize = 0;
            this.btnASIGNAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASIGNAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASIGNAR.ForeColor = System.Drawing.Color.White;
            this.btnASIGNAR.Location = new System.Drawing.Point(5, 281);
            this.btnASIGNAR.Name = "btnASIGNAR";
            this.btnASIGNAR.Size = new System.Drawing.Size(83, 30);
            this.btnASIGNAR.TabIndex = 11;
            this.btnASIGNAR.Text = "Asignar";
            this.btnASIGNAR.UseVisualStyleBackColor = false;
            this.btnASIGNAR.Click += new System.EventHandler(this.btnASIGNAR_Click);
            // 
            // dgvLISTA_PACIENTES
            // 
            this.dgvLISTA_PACIENTES.AllowUserToAddRows = false;
            this.dgvLISTA_PACIENTES.AllowUserToDeleteRows = false;
            this.dgvLISTA_PACIENTES.AllowUserToResizeColumns = false;
            this.dgvLISTA_PACIENTES.AllowUserToResizeRows = false;
            this.dgvLISTA_PACIENTES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_PACIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_PACIENTES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_PACIENTES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_PACIENTES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_PACIENTES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_PACIENTES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_PACIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_PACIENTES.EnableHeadersVisualStyles = false;
            this.dgvLISTA_PACIENTES.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_PACIENTES.Location = new System.Drawing.Point(5, 19);
            this.dgvLISTA_PACIENTES.Name = "dgvLISTA_PACIENTES";
            this.dgvLISTA_PACIENTES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_PACIENTES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_PACIENTES.RowHeadersVisible = false;
            this.dgvLISTA_PACIENTES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_PACIENTES.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_PACIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_PACIENTES.Size = new System.Drawing.Size(640, 256);
            this.dgvLISTA_PACIENTES.TabIndex = 0;
            // 
            // gbDATOS_PLAN_OBRA_SOCIAL
            // 
            this.gbDATOS_PLAN_OBRA_SOCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDATOS_PLAN_OBRA_SOCIAL.Controls.Add(this.lblOBRA_SOCIAL);
            this.gbDATOS_PLAN_OBRA_SOCIAL.Controls.Add(this.lblPLAN);
            this.gbDATOS_PLAN_OBRA_SOCIAL.Controls.Add(this.cmbPLAN);
            this.gbDATOS_PLAN_OBRA_SOCIAL.Controls.Add(this.cmbOBRA_SOCIAL);
            this.gbDATOS_PLAN_OBRA_SOCIAL.Controls.Add(this.btnCANCELAR);
            this.gbDATOS_PLAN_OBRA_SOCIAL.Controls.Add(this.btnGUARDAR);
            this.gbDATOS_PLAN_OBRA_SOCIAL.ForeColor = System.Drawing.Color.White;
            this.gbDATOS_PLAN_OBRA_SOCIAL.Location = new System.Drawing.Point(670, 12);
            this.gbDATOS_PLAN_OBRA_SOCIAL.Name = "gbDATOS_PLAN_OBRA_SOCIAL";
            this.gbDATOS_PLAN_OBRA_SOCIAL.Size = new System.Drawing.Size(328, 127);
            this.gbDATOS_PLAN_OBRA_SOCIAL.TabIndex = 6;
            this.gbDATOS_PLAN_OBRA_SOCIAL.TabStop = false;
            this.gbDATOS_PLAN_OBRA_SOCIAL.Text = "DATOS";
            // 
            // lblOBRA_SOCIAL
            // 
            this.lblOBRA_SOCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOBRA_SOCIAL.AutoSize = true;
            this.lblOBRA_SOCIAL.Location = new System.Drawing.Point(6, 19);
            this.lblOBRA_SOCIAL.Name = "lblOBRA_SOCIAL";
            this.lblOBRA_SOCIAL.Size = new System.Drawing.Size(81, 13);
            this.lblOBRA_SOCIAL.TabIndex = 11;
            this.lblOBRA_SOCIAL.Text = "OBRA SOCIAL:";
            // 
            // lblPLAN
            // 
            this.lblPLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPLAN.AutoSize = true;
            this.lblPLAN.Location = new System.Drawing.Point(6, 60);
            this.lblPLAN.Name = "lblPLAN";
            this.lblPLAN.Size = new System.Drawing.Size(38, 13);
            this.lblPLAN.TabIndex = 10;
            this.lblPLAN.Text = "PLAN:";
            // 
            // cmbPLAN
            // 
            this.cmbPLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPLAN.FormattingEnabled = true;
            this.cmbPLAN.Location = new System.Drawing.Point(118, 52);
            this.cmbPLAN.Name = "cmbPLAN";
            this.cmbPLAN.Size = new System.Drawing.Size(204, 21);
            this.cmbPLAN.TabIndex = 8;
            // 
            // cmbOBRA_SOCIAL
            // 
            this.cmbOBRA_SOCIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOBRA_SOCIAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOBRA_SOCIAL.FormattingEnabled = true;
            this.cmbOBRA_SOCIAL.Location = new System.Drawing.Point(118, 16);
            this.cmbOBRA_SOCIAL.Name = "cmbOBRA_SOCIAL";
            this.cmbOBRA_SOCIAL.Size = new System.Drawing.Size(204, 21);
            this.cmbOBRA_SOCIAL.TabIndex = 9;
            this.cmbOBRA_SOCIAL.SelectedIndexChanged += new System.EventHandler(this.cmbOBRA_SOCIAL_SelectedIndexChanged);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCANCELAR.FlatAppearance.BorderSize = 0;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.White;
            this.btnCANCELAR.Location = new System.Drawing.Point(217, 83);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(105, 36);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGUARDAR.FlatAppearance.BorderSize = 0;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 83);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(102, 36);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // frmASIGNAR_PLAN_OBRA_SOCIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1004, 341);
            this.Controls.Add(this.gbDATOS_PLAN_OBRA_SOCIAL);
            this.Controls.Add(this.gbLISTA_PACIENTES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmASIGNAR_PLAN_OBRA_SOCIAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNAR PLAN Y OBRAS SOCIALES A LOS PACIENTES";
            this.gbLISTA_PACIENTES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PACIENTES)).EndInit();
            this.gbDATOS_PLAN_OBRA_SOCIAL.ResumeLayout(false);
            this.gbDATOS_PLAN_OBRA_SOCIAL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLISTA_PACIENTES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnASIGNAR;
        private System.Windows.Forms.DataGridView dgvLISTA_PACIENTES;
        private System.Windows.Forms.GroupBox gbDATOS_PLAN_OBRA_SOCIAL;
        private System.Windows.Forms.ComboBox cmbPLAN;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.ComboBox cmbOBRA_SOCIAL;
        private System.Windows.Forms.Label lblOBRA_SOCIAL;
        private System.Windows.Forms.Label lblPLAN;
    }
}