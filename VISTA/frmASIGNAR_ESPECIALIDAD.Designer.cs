
namespace VISTA
{
    partial class frmASIGNAR_ESPECIALIDAD
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
            this.gbESPECIALIDADES = new System.Windows.Forms.GroupBox();
            this.cmbESPECIALIDADES = new System.Windows.Forms.ComboBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbLISTA_PROFESIONALES = new System.Windows.Forms.GroupBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnASIGNAR = new System.Windows.Forms.Button();
            this.dgvLISTA_PROFESIONALES = new System.Windows.Forms.DataGridView();
            this.gbESPECIALIDADES.SuspendLayout();
            this.gbLISTA_PROFESIONALES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).BeginInit();
            this.SuspendLayout();
            // 
            // gbESPECIALIDADES
            // 
            this.gbESPECIALIDADES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbESPECIALIDADES.Controls.Add(this.cmbESPECIALIDADES);
            this.gbESPECIALIDADES.Controls.Add(this.btnCANCELAR);
            this.gbESPECIALIDADES.Controls.Add(this.btnGUARDAR);
            this.gbESPECIALIDADES.ForeColor = System.Drawing.Color.White;
            this.gbESPECIALIDADES.Location = new System.Drawing.Point(691, 8);
            this.gbESPECIALIDADES.Name = "gbESPECIALIDADES";
            this.gbESPECIALIDADES.Size = new System.Drawing.Size(264, 99);
            this.gbESPECIALIDADES.TabIndex = 5;
            this.gbESPECIALIDADES.TabStop = false;
            this.gbESPECIALIDADES.Text = "ESPECIALIDADES";
            // 
            // cmbESPECIALIDADES
            // 
            this.cmbESPECIALIDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESPECIALIDADES.FormattingEnabled = true;
            this.cmbESPECIALIDADES.Location = new System.Drawing.Point(20, 19);
            this.cmbESPECIALIDADES.Name = "cmbESPECIALIDADES";
            this.cmbESPECIALIDADES.Size = new System.Drawing.Size(221, 21);
            this.cmbESPECIALIDADES.TabIndex = 8;
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
            this.btnCANCELAR.Location = new System.Drawing.Point(158, 57);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(6, 57);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(100, 36);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // gbLISTA_PROFESIONALES
            // 
            this.gbLISTA_PROFESIONALES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnCERRAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.btnASIGNAR);
            this.gbLISTA_PROFESIONALES.Controls.Add(this.dgvLISTA_PROFESIONALES);
            this.gbLISTA_PROFESIONALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLISTA_PROFESIONALES.ForeColor = System.Drawing.Color.White;
            this.gbLISTA_PROFESIONALES.Location = new System.Drawing.Point(7, 8);
            this.gbLISTA_PROFESIONALES.Name = "gbLISTA_PROFESIONALES";
            this.gbLISTA_PROFESIONALES.Size = new System.Drawing.Size(682, 350);
            this.gbLISTA_PROFESIONALES.TabIndex = 4;
            this.gbLISTA_PROFESIONALES.TabStop = false;
            this.gbLISTA_PROFESIONALES.Text = "LISTA DE PROFESIONALES";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCERRAR.FlatAppearance.BorderSize = 0;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.White;
            this.btnCERRAR.Location = new System.Drawing.Point(593, 314);
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
            this.btnASIGNAR.Location = new System.Drawing.Point(5, 314);
            this.btnASIGNAR.Name = "btnASIGNAR";
            this.btnASIGNAR.Size = new System.Drawing.Size(83, 30);
            this.btnASIGNAR.TabIndex = 11;
            this.btnASIGNAR.Text = "Asignar";
            this.btnASIGNAR.UseVisualStyleBackColor = false;
            this.btnASIGNAR.Click += new System.EventHandler(this.btnASIGNAR_Click);
            // 
            // dgvLISTA_PROFESIONALES
            // 
            this.dgvLISTA_PROFESIONALES.AllowUserToAddRows = false;
            this.dgvLISTA_PROFESIONALES.AllowUserToDeleteRows = false;
            this.dgvLISTA_PROFESIONALES.AllowUserToResizeColumns = false;
            this.dgvLISTA_PROFESIONALES.AllowUserToResizeRows = false;
            this.dgvLISTA_PROFESIONALES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTA_PROFESIONALES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTA_PROFESIONALES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvLISTA_PROFESIONALES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTA_PROFESIONALES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLISTA_PROFESIONALES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_PROFESIONALES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLISTA_PROFESIONALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLISTA_PROFESIONALES.EnableHeadersVisualStyles = false;
            this.dgvLISTA_PROFESIONALES.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.dgvLISTA_PROFESIONALES.Location = new System.Drawing.Point(5, 19);
            this.dgvLISTA_PROFESIONALES.Name = "dgvLISTA_PROFESIONALES";
            this.dgvLISTA_PROFESIONALES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLISTA_PROFESIONALES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLISTA_PROFESIONALES.RowHeadersVisible = false;
            this.dgvLISTA_PROFESIONALES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLISTA_PROFESIONALES.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLISTA_PROFESIONALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTA_PROFESIONALES.Size = new System.Drawing.Size(670, 289);
            this.dgvLISTA_PROFESIONALES.TabIndex = 0;
            // 
            // frmASIGNAR_ESPECIALIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(963, 366);
            this.Controls.Add(this.gbESPECIALIDADES);
            this.Controls.Add(this.gbLISTA_PROFESIONALES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmASIGNAR_ESPECIALIDAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNAR ESPECIALIDADES A PROFESIONALES";
            this.gbESPECIALIDADES.ResumeLayout(false);
            this.gbLISTA_PROFESIONALES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTA_PROFESIONALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbESPECIALIDADES;
        private System.Windows.Forms.ComboBox cmbESPECIALIDADES;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbLISTA_PROFESIONALES;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnASIGNAR;
        private System.Windows.Forms.DataGridView dgvLISTA_PROFESIONALES;
    }
}